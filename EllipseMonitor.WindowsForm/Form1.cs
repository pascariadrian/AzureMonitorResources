using EllipseMonitor.Model;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAzure.ManageDeployments;
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace EllipseMonitor.WindowsForm
{
    
    public partial class EllipseMonitor : Form
    {
        public List<Utils.AzureCredentials> AzureCredentialsList;
        public List<VirtualMachineBox> VirtualMachinesList = new List<VirtualMachineBox>();


        public EllipseMonitor()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private async void btnGetVMDetails_Click(object sender, EventArgs e)
        {
            foreach (var credential in AzureCredentialsList)
            {
                //INIT API
                API.CertThumbPrint = credential.CertThumbPrint;
                API.ClientId = credential.ClientId;
                API.ClientSecret = credential.ClientSecret;
                API.SubscriptionId = credential.SubscriptionId;
                API.TenantId = credential.TenantId;

                await API.Init();

                try
                {

                    if (API.Credential != null)
                    {
                        // perform VM info call
                        Model.VirtualBox vm = new Model.VirtualBox();

                        var vmDetails = await vm.GetVirtualMachine(API.Credential, txtResourceGroup.Text, txtVmName.Text, API.SubscriptionId);

                        if (vmDetails != null)
                        {
                            lblVMDetailsNameValue.Text = vmDetails.Name;
                            lblOSTypeValue.Text = vmDetails.StorageProfile.OsDisk.OsType.ToString();
                            lblAdminUserNameValue.Text = vmDetails.OsProfile.AdminUsername.ToString();
                            lblGeneralStatusValue.Text = vmDetails.ProvisioningState;
                            lblVMTypeValue.Text = vmDetails.Type.ToString();
                            //Init InstanceViewStatus list view
                            initInstanceViewListView();
                            foreach (InstanceViewStatus istat in vmDetails.InstanceView.Statuses)
                            {
                                var item = new ListViewItem(new[] { istat.Code.ToString(), istat.Level.ToString(), istat.DisplayStatus });
                                lwInstanceViewStatus.Items.Add(item);

                                //Set status of the box

                                if (istat.Code.ToLower().Contains("power"))
                                {
                                    if (istat.DisplayStatus.ToLower().Contains("running"))
                                    {
                                        pbVMStatus.Image = Image.FromFile("c:\\users\\apascari\\documents\\visual studio 2015\\Projects\\EllipseMonitor\\EllipseMonitor.WindowsForm\\Images\\Started.png");

                                        pbVMStatus.Visible = true;
                                        btnStop.Enabled = true;
                                        btnRestart.Enabled = true;
                                    }
                                    else
                                    {
                                        pbVMStatus.Image = Image.FromFile("c:\\users\\apascari\\documents\\visual studio 2015\\Projects\\EllipseMonitor\\EllipseMonitor.WindowsForm\\Images\\Stopped.png");

                                        pbVMStatus.Visible = true;
                                        btnStart.Enabled = true;
                                    }
                                }
                            }
                            break;
                        }
                    }
                }
                catch (Exception exc)
                {
                    lblStatus.Text = exc.Message;
                }
            }
        }

        private async void EllipseMonitor_Load(object sender, EventArgs e)
        {
            lblSubscription.Text = "Subscriptions not loaded";
            var result = API.Init();
            if (await result)
            {
                //
            }

        }



        #region private methods
        private void initInstanceViewListView()
        {
            // Add columns
            lwInstanceViewStatus.Columns.Add("Code", -2, HorizontalAlignment.Left);
            lwInstanceViewStatus.Columns.Add("Level", -2, HorizontalAlignment.Left);
            lwInstanceViewStatus.Columns.Add("Status", -2, HorizontalAlignment.Left);
            lwInstanceViewStatus.View = View.Details;
        }

        private void initResourceGroupsListView()
        {
            lwResourceGroups.Columns.Add("Subscription", -2, HorizontalAlignment.Left);
            lwResourceGroups.Columns.Add("Name", -2, HorizontalAlignment.Left);
            lwResourceGroups.Columns.Add("Location", -2, HorizontalAlignment.Left);
            lwResourceGroups.Columns.Add("State", -2, HorizontalAlignment.Left);
            lwResourceGroups.View = View.Details;
        }

        private void initVirtualMachinesListView()
        {
            lwVirtualMachines.Columns.Add("#", -2, HorizontalAlignment.Left);
            lwVirtualMachines.Columns.Add("Subscription", -2, HorizontalAlignment.Left);
            lwVirtualMachines.Columns.Add("Name", -2, HorizontalAlignment.Left);
            lwVirtualMachines.Columns.Add("ResourceGroup", -2, HorizontalAlignment.Left);
            lwVirtualMachines.Columns.Add("Location", -2, HorizontalAlignment.Left);
            lwVirtualMachines.Columns.Add("AdminUserName", -2, HorizontalAlignment.Left);
            lwVirtualMachines.Columns.Add("GeneralStatus", -2, HorizontalAlignment.Left);
            lwVirtualMachines.Columns.Add("InstanceStatus", -2, HorizontalAlignment.Left);
            lwVirtualMachines.View = View.Details;
        }

        private void initResourcesListView()
        {
            lwResourcesInREsourceGroup.Columns.Add("Number", -2, HorizontalAlignment.Left);
            lwResourcesInREsourceGroup.Columns.Add("Name", -2, HorizontalAlignment.Left);
            lwResourcesInREsourceGroup.Columns.Add("Resource group name", -2, HorizontalAlignment.Left);
            lwResourcesInREsourceGroup.Columns.Add("Location", -2, HorizontalAlignment.Left);
            lwResourcesInREsourceGroup.Columns.Add("Type", -2, HorizontalAlignment.Left);
            lwResourcesInREsourceGroup.Columns.Add("Production slot status", -2, HorizontalAlignment.Left);
            lwResourcesInREsourceGroup.Columns.Add("Staging slot status", -2, HorizontalAlignment.Left);
            lwResourcesInREsourceGroup.View = View.Details;
        }

        private void initCloudServicesListView()
        {
            lwCloudServices.Columns.Add("Name", -2, HorizontalAlignment.Left);
            lwCloudServices.Columns.Add("Production slot Status", -2, HorizontalAlignment.Left);
            lwCloudServices.Columns.Add("Production slot VM", -2, HorizontalAlignment.Left);
            lwCloudServices.Columns.Add("Staging slot status", -2, HorizontalAlignment.Left);
            lwCloudServices.Columns.Add("Staging slot VM", -2, HorizontalAlignment.Left);
            lwCloudServices.View = View.Details;
        }
        #endregion

        private async void btnStart_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Starting Virtual box";
            Model.VirtualBox vb = new Model.VirtualBox();
            var test = vb.StartVirtualMachine(API.Credential, txtResourceGroup.Text, txtVmName.Text, API.SubscriptionId);

            if (await test)
            {
                lblStatus.Text = "VM started";
            }
        }

        private async void btnStop_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Starting Virtual box";
            Model.VirtualBox vb = new Model.VirtualBox();

            var stopVm = vb.StopVirtualMachine(API.Credential, txtResourceGroup.Text, txtVmName.Text, API.SubscriptionId);

            if (await stopVm)
            {
                lblStatus.Text = "VM stopped";
            }
        }
        private async void btnRestart_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Restarting Virtual box";
            Model.VirtualBox vb = new Model.VirtualBox();

            var restartVM = vb.RestartVirtualMachine(API.Credential, txtResourceGroup.Text, txtVmName.Text, API.SubscriptionId);

            if (await restartVM)
            {
                lblStatus.Text = "VM restarted";
            }

        }

        private async void btnGetResourceGroups_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Loading resources";
            if (AzureCredentialsList == null || AzureCredentialsList.Count == 0)
            { return; }

            lwResourceGroups.Clear();

            initResourceGroupsListView();
            initResourcesListView();
            initCloudServicesListView();
            
            int counter = 0;

            foreach (var credential in AzureCredentialsList)
            {

                //INIT API
                API.CertThumbPrint = credential.CertThumbPrint;
                API.ClientId = credential.ClientId;
                API.ClientSecret = credential.ClientSecret;
                API.SubscriptionId = credential.SubscriptionId;
                API.TenantId = credential.TenantId;

                await API.Init();


                Model.ResourceGroup resourceGroup = new Model.ResourceGroup();

                var resourceGroups = resourceGroup.GetResourceGroupList(API.Credential, API.SubscriptionId);

                var resourceGroupsList = await resourceGroups;

                

                foreach (var rs in resourceGroupsList)
                {
                    var item = new ListViewItem(new[] { credential.SubscriptionName, rs.Name, rs.Location, rs.Properties.ProvisioningState });
                    lwResourceGroups.Items.Add(item);

                    //Get resources fro each resource group
                    var resources = resourceGroup.ResourceGroupListResources(API.Credential, rs.Name, API.SubscriptionId);
                    var resourcesList = await resources;



                    ResourceDeployments resourceDeployments = new ResourceDeployments(API.SubscriptionId, API.CertThumbPrint);

                    foreach (var r in resourcesList)
                    {

                       
                        string ProductionSlot = string.Empty;
                        string ProductionSlotStatus = string.Empty;
                        string StagingSlot = string.Empty;
                        string StagingSlotStatus = string.Empty;

                        //Check if resource group is domain
                        if (r.Type == "Microsoft.ClassicCompute/domainNames")
                        {
                            try
                            {
                                //Get production slot
                                var deployments = resourceDeployments.GetDeployments(r.Name, DeploymentSlot.Production);

                                foreach (var deploy in deployments)
                                {
                                    ProductionSlot += "VM Name =" + deploy.InstanceName + " VM status = " + deploy.PowerState;
                                    ProductionSlotStatus = deploy.InstanceStatus;
                                }
                            }
                            catch (Exception exc)
                            {
                                //Status will ne empty
                                ProductionSlot = exc.Message;
                            }

                            if (cbGetStagingSlot.Checked)
                            {
                                try
                                {
                                    //Get Staging slot
                                    var deployments = resourceDeployments.GetDeployments(r.Name, DeploymentSlot.Staging);

                                    foreach (var deploy in deployments)
                                    {
                                        StagingSlot += "VM Name =" + deploy.InstanceName + " VM status = " + deploy.PowerState;
                                        StagingSlotStatus = deploy.InstanceStatus;
                                    }
                                }
                                catch (Exception exc)
                                {
                                    //Status will ne empty
                                    StagingSlot = exc.Message;
                                }
                            }

                            var itemCloudService = new ListViewItem(new[] { r.Name, ProductionSlotStatus, ProductionSlot, StagingSlot , StagingSlotStatus});
                            lwCloudServices.Items.Add(itemCloudService);
                        }

                        counter++;
                        //TODO: get status of the resource
                        //add in the list
                        var itemResource = new ListViewItem(new[] { counter.ToString(), r.Name, rs.Name, r.Location, r.Type, ProductionSlotStatus, StagingSlotStatus });
                        lwResourcesInREsourceGroup.Items.Add(itemResource);
                    }
                }
            }
            lwResourceGroups.Refresh();

            lblResourceGroupsNumber.Text = "Resource groups number = " + lwResourceGroups.Items.Count.ToString();

            lblStatus.Text = "Resources loaded";
        }

        private async void btnGetAllVM_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Getting all virtual boxes";
            Model.VirtualBox vb = new Model.VirtualBox();
            int virtualMachinesNumber = 0;
            lwVirtualMachines.Clear();
            initVirtualMachinesListView();
            if (AzureCredentialsList == null || AzureCredentialsList.Count == 0)
            {
                MessageBox.Show("Load subscription keys");
                return;
            }

            foreach (var credential in AzureCredentialsList)
            {
                //INIT API
                API.CertThumbPrint = credential.CertThumbPrint;
                API.ClientId = credential.ClientId;
                API.ClientSecret = credential.ClientSecret;
                API.SubscriptionId = credential.SubscriptionId;
                API.TenantId = credential.TenantId;

                await API.Init();

                var virtualMahines = vb.GetAllVirtualMachines(API.Credential, API.SubscriptionId);


                var virtualMahinesList = await virtualMahines;

                

                foreach (var vm in virtualMahinesList)
                {
                    //Get resource group name
                    var resourceGroupNameList = vm.Id.Split('/');
                    var resourceGroupName = resourceGroupNameList[4];

                    string vmStatus = "Stopped";

                    try
                    {
                        //Get the machine details
                        var vmDetails = await vb.GetVirtualMachine(API.Credential, resourceGroupName, vm.Name, API.SubscriptionId);

                        //Get status of the box TODO:

                        try
                        {
                            if (vmDetails.InstanceView != null)
                            {
                                foreach (InstanceViewStatus istat in vmDetails.InstanceView.Statuses)
                                {
                                    //Set status of the box

                                    if (istat.Code.ToLower().Contains("power"))
                                    {
                                        if (istat.DisplayStatus.ToLower().Contains("running"))
                                        {
                                            vmStatus = "Running";
                                        }
                                        else
                                        {
                                            vmStatus = istat.DisplayStatus;
                                        }
                                    }
                                }
                            }
                        }
                        catch
                        {

                        }
                    }
                    catch
                    { }


                    virtualMachinesNumber++;

                    //Add vm's to the list
                    

                    var item = new ListViewItem(new[] { virtualMachinesNumber.ToString(), credential.SubscriptionName, vm.Name, resourceGroupName, vm.Location, vm.OsProfile.AdminUsername.ToString(), vm.ProvisioningState, vmStatus });
                    lwVirtualMachines.Items.Add(item);

                   
                    var itemVM = new VirtualMachineBox(API.SubscriptionId, vmStatus, vm.Name, resourceGroupName, vm);
                    VirtualMachinesList.Add(itemVM);
                    btnVMOperation.Enabled = true;
                }

                
                
                lblStatus.Text = "Got all virtual boxes";
                lblNumberOfVirtualMachines.Text = "Number of Virtual machines(not classic): " + virtualMachinesNumber.ToString();
                lwVirtualMachines.Refresh();
                lwVirtualMachines.Visible = true;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnGetCloudServices_Click(object sender, EventArgs e)
        {
            /*CloudService cloudService = new CloudService();
            var cloudServices = cloudService.GetCloudServicesList(API.CloudCredential, API.SubscriptionId);

            var cloudServicesList = await cloudServices;

            foreach (var cs in cloudServicesList)
            {
                    
            }*/

        }

        private async void btnStartResourceById_Click(object sender, EventArgs e)
        {
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {


            ResourceDeployments rd = new ResourceDeployments(ConfigurationManager.AppSettings["AzureSubscription"], ConfigurationManager.AppSettings["CertificateThumbNumber"]);

            var test = rd.GetDeployments("DEV-21-DEV-D2", DeploymentSlot.Production);



            foreach (var t in test)
            {
                //t.PowerState
            }

           

        }

        private void btnLoadCredentials_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select key file";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.txt)|*.txt|All files (*.txt)|*.txt";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            string fileName = string.Empty;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                fileName = fdlg.FileName;
            }


            Utils.LoginData loginData = new Utils.LoginData(fileName);
            AzureCredentialsList = loginData.AzureList;
            if (AzureCredentialsList.Count >= 0)
            {
                lblSubscription.Text = "Subscriptions: ";
                foreach (var c in AzureCredentialsList)
                {
                    lblSubscription.Text += c.SubscriptionName + ";";
                    lblStatus.Text = "Subscription details loaded";
                }
            }

        }

        private void btnVMOperation_Click(object sender, EventArgs e)
        {
            VMOperation vm = new VMOperation(VirtualMachinesList, AzureCredentialsList);
            vm.ShowDialog();

        }
        


    }
}
