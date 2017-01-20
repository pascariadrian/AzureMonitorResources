using EllipseMonitor.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EllipseMonitor.WindowsForm
{
    public partial class VMOperation : Form
    {
        public List<VirtualMachineBox> VirtualBoxList;
        List<Utils.AzureCredentials> AzureCredentialsList;
        public VMOperation( List<VirtualMachineBox> _virtualBoxList, List<Utils.AzureCredentials> _azureCredentialsList)
        {
            InitializeComponent();
            VirtualBoxList = _virtualBoxList;
            AzureCredentialsList = _azureCredentialsList;
        }

        private void VMOperation_Load(object sender, EventArgs e)
        {
            //Get virtual boxes
            foreach (var vm in VirtualBoxList)
            {
                cmbVMList.Items.Add(vm.Name + "(" + vm.GroupName + ")");
            }

        }

        

        private void cmbVMList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var vm in VirtualBoxList)
            {
                var vmName = vm.Name + "(" + vm.GroupName + ")";
                if (vmName.Equals(cmbVMList.SelectedItem.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    if (vm.Status == "Running")
                    {
                        pbVMStatusVM.Image = Image.FromFile("c:\\users\\apascari\\documents\\visual studio 2015\\Projects\\EllipseMonitor\\EllipseMonitor.WindowsForm\\Images\\Started.png");

                        pbVMStatusVM.Visible = true;
                        btnStopVM.Enabled = true;
                        btnRestartVM.Enabled = true;
                    }
                    else
                    {
                        pbVMStatusVM.Image = Image.FromFile("c:\\users\\apascari\\documents\\visual studio 2015\\Projects\\EllipseMonitor\\EllipseMonitor.WindowsForm\\Images\\Stopped.png");

                        pbVMStatusVM.Visible = true;
                        btnStartVM.Enabled = true;
                    }
                    break;
                     
                }
            }


        }

        private async void btnStartVM_Click(object sender, EventArgs e)
        {
            Model.VirtualBox vb = new Model.VirtualBox();

            foreach (var vm in VirtualBoxList)
            {
                var vmName = vm.Name + "(" + vm.GroupName + ")";

                if (vmName.Equals(cmbVMList.SelectedItem.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    //Init subsciption
                    var azureCredential = new Utils.AzureCredentials();

                    var credentials = azureCredential.find(AzureCredentialsList, vm.Subscription);

                    API.CertThumbPrint = credentials.CertThumbPrint;
                    API.ClientId = credentials.ClientId;
                    API.ClientSecret = credentials.ClientSecret;
                    API.SubscriptionId = credentials.SubscriptionId;
                    API.TenantId = credentials.TenantId;

                    await API.Init();


                    var vmOperation = vb.StartVirtualMachine(API.Credential, vm.GroupName, vm.Name, API.SubscriptionId);

                    if (await vmOperation)
                    {
                        this.Close();
                    }

                    break;
                }
            }
                
        }

        private async void btnStopVM_Click(object sender, EventArgs e)
        {
            Model.VirtualBox vb = new Model.VirtualBox();

            foreach (var vm in VirtualBoxList)
            {
                var vmName = vm.Name + "(" + vm.GroupName + ")";

                if (vmName.Equals(cmbVMList.SelectedItem.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    //Init subsciption
                    var azureCredential = new Utils.AzureCredentials();

                    var credentials = azureCredential.find(AzureCredentialsList, vm.Subscription);

                    API.CertThumbPrint = credentials.CertThumbPrint;
                    API.ClientId = credentials.ClientId;
                    API.ClientSecret = credentials.ClientSecret;
                    API.SubscriptionId = credentials.SubscriptionId;
                    API.TenantId = credentials.TenantId;

                    await API.Init();


                    var vmOperation = vb.StopVirtualMachine(API.Credential, vm.GroupName, vm.Name, API.SubscriptionId);

                    if (await vmOperation)
                    {
                        this.Close();
                    }

                    break;
                }
            }
        }

        private async void btnRestartVM_Click(object sender, EventArgs e)
        {
            Model.VirtualBox vb = new Model.VirtualBox();

            foreach (var vm in VirtualBoxList)
            {
                var vmName = vm.Name + "(" + vm.GroupName + ")";

                if (vmName.Equals(cmbVMList.SelectedItem.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    //Init subsciption
                    var azureCredential = new Utils.AzureCredentials();

                    var credentials = azureCredential.find(AzureCredentialsList, vm.Subscription);

                    API.CertThumbPrint = credentials.CertThumbPrint;
                    API.ClientId = credentials.ClientId;
                    API.ClientSecret = credentials.ClientSecret;
                    API.SubscriptionId = credentials.SubscriptionId;
                    API.TenantId = credentials.TenantId;

                    await API.Init();


                    var vmOperation = vb.RestartVirtualMachine(API.Credential, vm.GroupName, vm.Name, API.SubscriptionId);

                    if (await vmOperation)
                    {
                        this.Close();
                    }

                    break;
                }
            }
        }
    }
}
