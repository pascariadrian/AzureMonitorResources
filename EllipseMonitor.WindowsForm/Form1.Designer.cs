namespace EllipseMonitor.WindowsForm
{
    partial class EllipseMonitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbMainPage = new System.Windows.Forms.TabControl();
            this.tpVMDetails = new System.Windows.Forms.TabPage();
            this.lblVMStatus = new System.Windows.Forms.Label();
            this.pbVMStatus = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tcVMDetails = new System.Windows.Forms.TabControl();
            this.tpMainDetails = new System.Windows.Forms.TabPage();
            this.lblVMTypeValue = new System.Windows.Forms.Label();
            this.lblVMType = new System.Windows.Forms.Label();
            this.lblGeneralStatusValue = new System.Windows.Forms.Label();
            this.lblGeneralStatus = new System.Windows.Forms.Label();
            this.lblAdminUserNameValue = new System.Windows.Forms.Label();
            this.lblAdminUSerName = new System.Windows.Forms.Label();
            this.lblOSTypeValue = new System.Windows.Forms.Label();
            this.lblOsTypeLabel = new System.Windows.Forms.Label();
            this.lblVMDetailsNameValue = new System.Windows.Forms.Label();
            this.lblVMDetailsNameLabel = new System.Windows.Forms.Label();
            this.tpUsers = new System.Windows.Forms.TabPage();
            this.lwInstanceViewStatus = new System.Windows.Forms.ListView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnGetVMDetails = new System.Windows.Forms.Button();
            this.lblVMName = new System.Windows.Forms.Label();
            this.txtVmName = new System.Windows.Forms.TextBox();
            this.lblResourceGroup = new System.Windows.Forms.Label();
            this.txtResourceGroup = new System.Windows.Forms.TextBox();
            this.tpVMList = new System.Windows.Forms.TabPage();
            this.btnVMOperation = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblNumberOfVirtualMachines = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lwVirtualMachines = new System.Windows.Forms.ListView();
            this.btnGetAllVM = new System.Windows.Forms.Button();
            this.tpResourceGrListups = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStopResourceByIdNumber = new System.Windows.Forms.Button();
            this.btnRestartResourceByNumber = new System.Windows.Forms.Button();
            this.btnStartResourceById = new System.Windows.Forms.Button();
            this.tpResourceGroupMain = new System.Windows.Forms.TabControl();
            this.tpResouorceGeneral = new System.Windows.Forms.TabPage();
            this.lblResourceGroupsNumber = new System.Windows.Forms.Label();
            this.tpResourceGroupList = new System.Windows.Forms.TabPage();
            this.lwResourceGroups = new System.Windows.Forms.ListView();
            this.tpResourceGroupResources = new System.Windows.Forms.TabPage();
            this.lwResourcesInREsourceGroup = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lwCloudServices = new System.Windows.Forms.ListView();
            this.btnGetResourceGroups = new System.Windows.Forms.Button();
            this.lblSubscription = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnLoadCredentials = new System.Windows.Forms.Button();
            this.cbGetStagingSlot = new System.Windows.Forms.CheckBox();
            this.tbMainPage.SuspendLayout();
            this.tpVMDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVMStatus)).BeginInit();
            this.tcVMDetails.SuspendLayout();
            this.tpMainDetails.SuspendLayout();
            this.tpUsers.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpVMList.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tpResourceGrListups.SuspendLayout();
            this.tpResourceGroupMain.SuspendLayout();
            this.tpResouorceGeneral.SuspendLayout();
            this.tpResourceGroupList.SuspendLayout();
            this.tpResourceGroupResources.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMainPage
            // 
            this.tbMainPage.Controls.Add(this.tpVMDetails);
            this.tbMainPage.Controls.Add(this.tpVMList);
            this.tbMainPage.Controls.Add(this.tpResourceGrListups);
            this.tbMainPage.Location = new System.Drawing.Point(0, 121);
            this.tbMainPage.Name = "tbMainPage";
            this.tbMainPage.SelectedIndex = 0;
            this.tbMainPage.Size = new System.Drawing.Size(1323, 418);
            this.tbMainPage.TabIndex = 0;
            // 
            // tpVMDetails
            // 
            this.tpVMDetails.Controls.Add(this.lblVMStatus);
            this.tpVMDetails.Controls.Add(this.pbVMStatus);
            this.tpVMDetails.Controls.Add(this.btnRestart);
            this.tpVMDetails.Controls.Add(this.btnStop);
            this.tpVMDetails.Controls.Add(this.btnStart);
            this.tpVMDetails.Controls.Add(this.tcVMDetails);
            this.tpVMDetails.Controls.Add(this.btnGetVMDetails);
            this.tpVMDetails.Controls.Add(this.lblVMName);
            this.tpVMDetails.Controls.Add(this.txtVmName);
            this.tpVMDetails.Controls.Add(this.lblResourceGroup);
            this.tpVMDetails.Controls.Add(this.txtResourceGroup);
            this.tpVMDetails.Location = new System.Drawing.Point(4, 22);
            this.tpVMDetails.Name = "tpVMDetails";
            this.tpVMDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpVMDetails.Size = new System.Drawing.Size(1315, 392);
            this.tpVMDetails.TabIndex = 1;
            this.tpVMDetails.Text = "VM details";
            this.tpVMDetails.UseVisualStyleBackColor = true;
            // 
            // lblVMStatus
            // 
            this.lblVMStatus.AutoSize = true;
            this.lblVMStatus.Location = new System.Drawing.Point(284, 90);
            this.lblVMStatus.Name = "lblVMStatus";
            this.lblVMStatus.Size = new System.Drawing.Size(59, 13);
            this.lblVMStatus.TabIndex = 11;
            this.lblVMStatus.Text = "VM Status:";
            // 
            // pbVMStatus
            // 
            this.pbVMStatus.Location = new System.Drawing.Point(349, 61);
            this.pbVMStatus.Name = "pbVMStatus";
            this.pbVMStatus.Size = new System.Drawing.Size(73, 69);
            this.pbVMStatus.TabIndex = 10;
            this.pbVMStatus.TabStop = false;
            this.pbVMStatus.Visible = false;
            // 
            // btnRestart
            // 
            this.btnRestart.Enabled = false;
            this.btnRestart.Location = new System.Drawing.Point(221, 136);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 9;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(112, 137);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(13, 136);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tcVMDetails
            // 
            this.tcVMDetails.Controls.Add(this.tpMainDetails);
            this.tcVMDetails.Controls.Add(this.tpUsers);
            this.tcVMDetails.Controls.Add(this.tabPage1);
            this.tcVMDetails.Location = new System.Drawing.Point(510, 0);
            this.tcVMDetails.Name = "tcVMDetails";
            this.tcVMDetails.SelectedIndex = 0;
            this.tcVMDetails.Size = new System.Drawing.Size(799, 386);
            this.tcVMDetails.TabIndex = 6;
            // 
            // tpMainDetails
            // 
            this.tpMainDetails.Controls.Add(this.lblVMTypeValue);
            this.tpMainDetails.Controls.Add(this.lblVMType);
            this.tpMainDetails.Controls.Add(this.lblGeneralStatusValue);
            this.tpMainDetails.Controls.Add(this.lblGeneralStatus);
            this.tpMainDetails.Controls.Add(this.lblAdminUserNameValue);
            this.tpMainDetails.Controls.Add(this.lblAdminUSerName);
            this.tpMainDetails.Controls.Add(this.lblOSTypeValue);
            this.tpMainDetails.Controls.Add(this.lblOsTypeLabel);
            this.tpMainDetails.Controls.Add(this.lblVMDetailsNameValue);
            this.tpMainDetails.Controls.Add(this.lblVMDetailsNameLabel);
            this.tpMainDetails.Location = new System.Drawing.Point(4, 22);
            this.tpMainDetails.Name = "tpMainDetails";
            this.tpMainDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpMainDetails.Size = new System.Drawing.Size(791, 360);
            this.tpMainDetails.TabIndex = 0;
            this.tpMainDetails.Text = "VM main details";
            this.tpMainDetails.UseVisualStyleBackColor = true;
            // 
            // lblVMTypeValue
            // 
            this.lblVMTypeValue.AutoSize = true;
            this.lblVMTypeValue.Location = new System.Drawing.Point(172, 125);
            this.lblVMTypeValue.Name = "lblVMTypeValue";
            this.lblVMTypeValue.Size = new System.Drawing.Size(35, 13);
            this.lblVMTypeValue.TabIndex = 9;
            this.lblVMTypeValue.Text = "Name";
            // 
            // lblVMType
            // 
            this.lblVMType.AutoSize = true;
            this.lblVMType.Location = new System.Drawing.Point(0, 125);
            this.lblVMType.Name = "lblVMType";
            this.lblVMType.Size = new System.Drawing.Size(31, 13);
            this.lblVMType.TabIndex = 8;
            this.lblVMType.Text = "Type";
            // 
            // lblGeneralStatusValue
            // 
            this.lblGeneralStatusValue.AutoSize = true;
            this.lblGeneralStatusValue.Location = new System.Drawing.Point(172, 95);
            this.lblGeneralStatusValue.Name = "lblGeneralStatusValue";
            this.lblGeneralStatusValue.Size = new System.Drawing.Size(35, 13);
            this.lblGeneralStatusValue.TabIndex = 7;
            this.lblGeneralStatusValue.Text = "Name";
            // 
            // lblGeneralStatus
            // 
            this.lblGeneralStatus.AutoSize = true;
            this.lblGeneralStatus.Location = new System.Drawing.Point(0, 95);
            this.lblGeneralStatus.Name = "lblGeneralStatus";
            this.lblGeneralStatus.Size = new System.Drawing.Size(75, 13);
            this.lblGeneralStatus.TabIndex = 6;
            this.lblGeneralStatus.Text = "General status";
            // 
            // lblAdminUserNameValue
            // 
            this.lblAdminUserNameValue.AutoSize = true;
            this.lblAdminUserNameValue.Location = new System.Drawing.Point(172, 68);
            this.lblAdminUserNameValue.Name = "lblAdminUserNameValue";
            this.lblAdminUserNameValue.Size = new System.Drawing.Size(35, 13);
            this.lblAdminUserNameValue.TabIndex = 5;
            this.lblAdminUserNameValue.Text = "Name";
            // 
            // lblAdminUSerName
            // 
            this.lblAdminUSerName.AutoSize = true;
            this.lblAdminUSerName.Location = new System.Drawing.Point(0, 68);
            this.lblAdminUSerName.Name = "lblAdminUSerName";
            this.lblAdminUSerName.Size = new System.Drawing.Size(88, 13);
            this.lblAdminUSerName.TabIndex = 4;
            this.lblAdminUSerName.Text = "Admin user name";
            // 
            // lblOSTypeValue
            // 
            this.lblOSTypeValue.AutoSize = true;
            this.lblOSTypeValue.Location = new System.Drawing.Point(172, 39);
            this.lblOSTypeValue.Name = "lblOSTypeValue";
            this.lblOSTypeValue.Size = new System.Drawing.Size(35, 13);
            this.lblOSTypeValue.TabIndex = 3;
            this.lblOSTypeValue.Text = "Name";
            // 
            // lblOsTypeLabel
            // 
            this.lblOsTypeLabel.AutoSize = true;
            this.lblOsTypeLabel.Location = new System.Drawing.Point(0, 39);
            this.lblOsTypeLabel.Name = "lblOsTypeLabel";
            this.lblOsTypeLabel.Size = new System.Drawing.Size(45, 13);
            this.lblOsTypeLabel.TabIndex = 2;
            this.lblOsTypeLabel.Text = "OS type";
            // 
            // lblVMDetailsNameValue
            // 
            this.lblVMDetailsNameValue.AutoSize = true;
            this.lblVMDetailsNameValue.Location = new System.Drawing.Point(172, 13);
            this.lblVMDetailsNameValue.Name = "lblVMDetailsNameValue";
            this.lblVMDetailsNameValue.Size = new System.Drawing.Size(35, 13);
            this.lblVMDetailsNameValue.TabIndex = 1;
            this.lblVMDetailsNameValue.Text = "Name";
            // 
            // lblVMDetailsNameLabel
            // 
            this.lblVMDetailsNameLabel.AutoSize = true;
            this.lblVMDetailsNameLabel.Location = new System.Drawing.Point(0, 13);
            this.lblVMDetailsNameLabel.Name = "lblVMDetailsNameLabel";
            this.lblVMDetailsNameLabel.Size = new System.Drawing.Size(52, 13);
            this.lblVMDetailsNameLabel.TabIndex = 0;
            this.lblVMDetailsNameLabel.Text = "VM name";
            // 
            // tpUsers
            // 
            this.tpUsers.Controls.Add(this.lwInstanceViewStatus);
            this.tpUsers.Location = new System.Drawing.Point(4, 22);
            this.tpUsers.Name = "tpUsers";
            this.tpUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsers.Size = new System.Drawing.Size(791, 360);
            this.tpUsers.TabIndex = 1;
            this.tpUsers.Text = "Instance View Status";
            this.tpUsers.UseVisualStyleBackColor = true;
            // 
            // lwInstanceViewStatus
            // 
            this.lwInstanceViewStatus.Location = new System.Drawing.Point(0, 36);
            this.lwInstanceViewStatus.Name = "lwInstanceViewStatus";
            this.lwInstanceViewStatus.Size = new System.Drawing.Size(785, 318);
            this.lwInstanceViewStatus.TabIndex = 0;
            this.lwInstanceViewStatus.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 360);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(782, 356);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnGetVMDetails
            // 
            this.btnGetVMDetails.Location = new System.Drawing.Point(24, 80);
            this.btnGetVMDetails.Name = "btnGetVMDetails";
            this.btnGetVMDetails.Size = new System.Drawing.Size(163, 23);
            this.btnGetVMDetails.TabIndex = 5;
            this.btnGetVMDetails.Text = "Get VM Details";
            this.btnGetVMDetails.UseVisualStyleBackColor = true;
            this.btnGetVMDetails.Click += new System.EventHandler(this.btnGetVMDetails_Click);
            // 
            // lblVMName
            // 
            this.lblVMName.AutoSize = true;
            this.lblVMName.Location = new System.Drawing.Point(8, 35);
            this.lblVMName.Name = "lblVMName";
            this.lblVMName.Size = new System.Drawing.Size(57, 13);
            this.lblVMName.TabIndex = 4;
            this.lblVMName.Text = "VM Name:";
            // 
            // txtVmName
            // 
            this.txtVmName.Location = new System.Drawing.Point(118, 32);
            this.txtVmName.Name = "txtVmName";
            this.txtVmName.Size = new System.Drawing.Size(283, 20);
            this.txtVmName.TabIndex = 3;
            this.txtVmName.Text = "TestVirtualM";
            // 
            // lblResourceGroup
            // 
            this.lblResourceGroup.AutoSize = true;
            this.lblResourceGroup.Location = new System.Drawing.Point(8, 9);
            this.lblResourceGroup.Name = "lblResourceGroup";
            this.lblResourceGroup.Size = new System.Drawing.Size(83, 13);
            this.lblResourceGroup.TabIndex = 2;
            this.lblResourceGroup.Text = "Resource group";
            // 
            // txtResourceGroup
            // 
            this.txtResourceGroup.Location = new System.Drawing.Point(118, 6);
            this.txtResourceGroup.Name = "txtResourceGroup";
            this.txtResourceGroup.Size = new System.Drawing.Size(283, 20);
            this.txtResourceGroup.TabIndex = 0;
            this.txtResourceGroup.Text = "DEV-21-DEV-D2";
            // 
            // tpVMList
            // 
            this.tpVMList.Controls.Add(this.btnVMOperation);
            this.tpVMList.Controls.Add(this.tabControl1);
            this.tpVMList.Controls.Add(this.btnGetAllVM);
            this.tpVMList.Location = new System.Drawing.Point(4, 22);
            this.tpVMList.Name = "tpVMList";
            this.tpVMList.Padding = new System.Windows.Forms.Padding(3);
            this.tpVMList.Size = new System.Drawing.Size(1315, 392);
            this.tpVMList.TabIndex = 2;
            this.tpVMList.Text = "VM List";
            this.tpVMList.UseVisualStyleBackColor = true;
            // 
            // btnVMOperation
            // 
            this.btnVMOperation.Enabled = false;
            this.btnVMOperation.Location = new System.Drawing.Point(40, 106);
            this.btnVMOperation.Name = "btnVMOperation";
            this.btnVMOperation.Size = new System.Drawing.Size(108, 23);
            this.btnVMOperation.TabIndex = 3;
            this.btnVMOperation.Text = "VM operation";
            this.btnVMOperation.UseVisualStyleBackColor = true;
            this.btnVMOperation.Click += new System.EventHandler(this.btnVMOperation_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(199, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1096, 392);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblNumberOfVirtualMachines);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1088, 366);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "VM info";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblNumberOfVirtualMachines
            // 
            this.lblNumberOfVirtualMachines.AutoSize = true;
            this.lblNumberOfVirtualMachines.Location = new System.Drawing.Point(7, 58);
            this.lblNumberOfVirtualMachines.Name = "lblNumberOfVirtualMachines";
            this.lblNumberOfVirtualMachines.Size = new System.Drawing.Size(201, 13);
            this.lblNumberOfVirtualMachines.TabIndex = 0;
            this.lblNumberOfVirtualMachines.Text = "Number of Virtual machines(not classic):0";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lwVirtualMachines);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1088, 366);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Virtual machines list";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lwVirtualMachines
            // 
            this.lwVirtualMachines.Location = new System.Drawing.Point(2, 0);
            this.lwVirtualMachines.Name = "lwVirtualMachines";
            this.lwVirtualMachines.Size = new System.Drawing.Size(1090, 363);
            this.lwVirtualMachines.TabIndex = 2;
            this.lwVirtualMachines.UseCompatibleStateImageBehavior = false;
            this.lwVirtualMachines.Visible = false;
            // 
            // btnGetAllVM
            // 
            this.btnGetAllVM.Location = new System.Drawing.Point(30, 17);
            this.btnGetAllVM.Name = "btnGetAllVM";
            this.btnGetAllVM.Size = new System.Drawing.Size(177, 39);
            this.btnGetAllVM.TabIndex = 0;
            this.btnGetAllVM.Text = "Get all virtual machines";
            this.btnGetAllVM.UseVisualStyleBackColor = true;
            this.btnGetAllVM.Click += new System.EventHandler(this.btnGetAllVM_Click);
            // 
            // tpResourceGrListups
            // 
            this.tpResourceGrListups.Controls.Add(this.cbGetStagingSlot);
            this.tpResourceGrListups.Controls.Add(this.button1);
            this.tpResourceGrListups.Controls.Add(this.btnStopResourceByIdNumber);
            this.tpResourceGrListups.Controls.Add(this.btnRestartResourceByNumber);
            this.tpResourceGrListups.Controls.Add(this.btnStartResourceById);
            this.tpResourceGrListups.Controls.Add(this.tpResourceGroupMain);
            this.tpResourceGrListups.Controls.Add(this.btnGetResourceGroups);
            this.tpResourceGrListups.Location = new System.Drawing.Point(4, 22);
            this.tpResourceGrListups.Name = "tpResourceGrListups";
            this.tpResourceGrListups.Padding = new System.Windows.Forms.Padding(3);
            this.tpResourceGrListups.Size = new System.Drawing.Size(1315, 392);
            this.tpResourceGrListups.TabIndex = 4;
            this.tpResourceGrListups.Text = "Resource group List";
            this.tpResourceGrListups.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "btnGetResourceStatus";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStopResourceByIdNumber
            // 
            this.btnStopResourceByIdNumber.Location = new System.Drawing.Point(13, 171);
            this.btnStopResourceByIdNumber.Name = "btnStopResourceByIdNumber";
            this.btnStopResourceByIdNumber.Size = new System.Drawing.Size(173, 23);
            this.btnStopResourceByIdNumber.TabIndex = 4;
            this.btnStopResourceByIdNumber.Text = "Stop resource by id number";
            this.btnStopResourceByIdNumber.UseVisualStyleBackColor = true;
            this.btnStopResourceByIdNumber.Visible = false;
            // 
            // btnRestartResourceByNumber
            // 
            this.btnRestartResourceByNumber.Location = new System.Drawing.Point(13, 131);
            this.btnRestartResourceByNumber.Name = "btnRestartResourceByNumber";
            this.btnRestartResourceByNumber.Size = new System.Drawing.Size(173, 23);
            this.btnRestartResourceByNumber.TabIndex = 3;
            this.btnRestartResourceByNumber.Text = "Restart resource by id number";
            this.btnRestartResourceByNumber.UseVisualStyleBackColor = true;
            this.btnRestartResourceByNumber.Visible = false;
            // 
            // btnStartResourceById
            // 
            this.btnStartResourceById.Location = new System.Drawing.Point(13, 89);
            this.btnStartResourceById.Name = "btnStartResourceById";
            this.btnStartResourceById.Size = new System.Drawing.Size(173, 23);
            this.btnStartResourceById.TabIndex = 2;
            this.btnStartResourceById.Text = "Start resource by id number";
            this.btnStartResourceById.UseVisualStyleBackColor = true;
            this.btnStartResourceById.Visible = false;
            this.btnStartResourceById.Click += new System.EventHandler(this.btnStartResourceById_Click);
            // 
            // tpResourceGroupMain
            // 
            this.tpResourceGroupMain.Controls.Add(this.tpResouorceGeneral);
            this.tpResourceGroupMain.Controls.Add(this.tpResourceGroupList);
            this.tpResourceGroupMain.Controls.Add(this.tpResourceGroupResources);
            this.tpResourceGroupMain.Controls.Add(this.tabPage2);
            this.tpResourceGroupMain.Location = new System.Drawing.Point(232, 7);
            this.tpResourceGroupMain.Name = "tpResourceGroupMain";
            this.tpResourceGroupMain.SelectedIndex = 0;
            this.tpResourceGroupMain.Size = new System.Drawing.Size(1080, 385);
            this.tpResourceGroupMain.TabIndex = 1;
            // 
            // tpResouorceGeneral
            // 
            this.tpResouorceGeneral.Controls.Add(this.lblResourceGroupsNumber);
            this.tpResouorceGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpResouorceGeneral.Name = "tpResouorceGeneral";
            this.tpResouorceGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpResouorceGeneral.Size = new System.Drawing.Size(1072, 359);
            this.tpResouorceGeneral.TabIndex = 1;
            this.tpResouorceGeneral.Text = "General";
            this.tpResouorceGeneral.UseVisualStyleBackColor = true;
            // 
            // lblResourceGroupsNumber
            // 
            this.lblResourceGroupsNumber.AutoSize = true;
            this.lblResourceGroupsNumber.Location = new System.Drawing.Point(34, 41);
            this.lblResourceGroupsNumber.Name = "lblResourceGroupsNumber";
            this.lblResourceGroupsNumber.Size = new System.Drawing.Size(109, 13);
            this.lblResourceGroupsNumber.TabIndex = 0;
            this.lblResourceGroupsNumber.Text = "Number of groups = 0";
            // 
            // tpResourceGroupList
            // 
            this.tpResourceGroupList.Controls.Add(this.lwResourceGroups);
            this.tpResourceGroupList.Location = new System.Drawing.Point(4, 22);
            this.tpResourceGroupList.Name = "tpResourceGroupList";
            this.tpResourceGroupList.Padding = new System.Windows.Forms.Padding(3);
            this.tpResourceGroupList.Size = new System.Drawing.Size(1072, 359);
            this.tpResourceGroupList.TabIndex = 2;
            this.tpResourceGroupList.Text = "Resource Group List";
            this.tpResourceGroupList.UseVisualStyleBackColor = true;
            // 
            // lwResourceGroups
            // 
            this.lwResourceGroups.Location = new System.Drawing.Point(5, 1);
            this.lwResourceGroups.Name = "lwResourceGroups";
            this.lwResourceGroups.Size = new System.Drawing.Size(1063, 356);
            this.lwResourceGroups.TabIndex = 9;
            this.lwResourceGroups.UseCompatibleStateImageBehavior = false;
            // 
            // tpResourceGroupResources
            // 
            this.tpResourceGroupResources.Controls.Add(this.lwResourcesInREsourceGroup);
            this.tpResourceGroupResources.Location = new System.Drawing.Point(4, 22);
            this.tpResourceGroupResources.Name = "tpResourceGroupResources";
            this.tpResourceGroupResources.Padding = new System.Windows.Forms.Padding(3);
            this.tpResourceGroupResources.Size = new System.Drawing.Size(1072, 359);
            this.tpResourceGroupResources.TabIndex = 3;
            this.tpResourceGroupResources.Text = "Resources in Resource group";
            this.tpResourceGroupResources.UseVisualStyleBackColor = true;
            // 
            // lwResourcesInREsourceGroup
            // 
            this.lwResourcesInREsourceGroup.Location = new System.Drawing.Point(0, 16);
            this.lwResourcesInREsourceGroup.Name = "lwResourcesInREsourceGroup";
            this.lwResourcesInREsourceGroup.Size = new System.Drawing.Size(1073, 343);
            this.lwResourcesInREsourceGroup.TabIndex = 0;
            this.lwResourcesInREsourceGroup.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lwCloudServices);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1072, 359);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Cloud services";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lwCloudServices
            // 
            this.lwCloudServices.Location = new System.Drawing.Point(0, 8);
            this.lwCloudServices.Name = "lwCloudServices";
            this.lwCloudServices.Size = new System.Drawing.Size(1073, 343);
            this.lwCloudServices.TabIndex = 1;
            this.lwCloudServices.UseCompatibleStateImageBehavior = false;
            // 
            // btnGetResourceGroups
            // 
            this.btnGetResourceGroups.Location = new System.Drawing.Point(13, 28);
            this.btnGetResourceGroups.Name = "btnGetResourceGroups";
            this.btnGetResourceGroups.Size = new System.Drawing.Size(173, 31);
            this.btnGetResourceGroups.TabIndex = 0;
            this.btnGetResourceGroups.Text = "Get resource groups";
            this.btnGetResourceGroups.UseVisualStyleBackColor = true;
            this.btnGetResourceGroups.Click += new System.EventHandler(this.btnGetResourceGroups_Click);
            // 
            // lblSubscription
            // 
            this.lblSubscription.AutoSize = true;
            this.lblSubscription.Location = new System.Drawing.Point(12, 21);
            this.lblSubscription.Name = "lblSubscription";
            this.lblSubscription.Size = new System.Drawing.Size(68, 13);
            this.lblSubscription.TabIndex = 1;
            this.lblSubscription.Text = "Subscription:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(13, 49);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(256, 24);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Load subscription keys file";
            // 
            // btnLoadCredentials
            // 
            this.btnLoadCredentials.Location = new System.Drawing.Point(12, 76);
            this.btnLoadCredentials.Name = "btnLoadCredentials";
            this.btnLoadCredentials.Size = new System.Drawing.Size(240, 23);
            this.btnLoadCredentials.TabIndex = 3;
            this.btnLoadCredentials.Text = "Load credentials";
            this.btnLoadCredentials.UseVisualStyleBackColor = true;
            this.btnLoadCredentials.Click += new System.EventHandler(this.btnLoadCredentials_Click);
            // 
            // cbGetStagingSlot
            // 
            this.cbGetStagingSlot.AutoSize = true;
            this.cbGetStagingSlot.Location = new System.Drawing.Point(33, 65);
            this.cbGetStagingSlot.Name = "cbGetStagingSlot";
            this.cbGetStagingSlot.Size = new System.Drawing.Size(101, 17);
            this.cbGetStagingSlot.TabIndex = 6;
            this.cbGetStagingSlot.Text = "Get Staging slot";
            this.cbGetStagingSlot.UseVisualStyleBackColor = true;
            // 
            // EllipseMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 541);
            this.Controls.Add(this.btnLoadCredentials);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblSubscription);
            this.Controls.Add(this.tbMainPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EllipseMonitor";
            this.Text = "Ellipse monitor";
            this.Load += new System.EventHandler(this.EllipseMonitor_Load);
            this.tbMainPage.ResumeLayout(false);
            this.tpVMDetails.ResumeLayout(false);
            this.tpVMDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVMStatus)).EndInit();
            this.tcVMDetails.ResumeLayout(false);
            this.tpMainDetails.ResumeLayout(false);
            this.tpMainDetails.PerformLayout();
            this.tpUsers.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tpVMList.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tpResourceGrListups.ResumeLayout(false);
            this.tpResourceGrListups.PerformLayout();
            this.tpResourceGroupMain.ResumeLayout(false);
            this.tpResouorceGeneral.ResumeLayout(false);
            this.tpResouorceGeneral.PerformLayout();
            this.tpResourceGroupList.ResumeLayout(false);
            this.tpResourceGroupResources.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbMainPage;
        private System.Windows.Forms.TabPage tpVMDetails;
        private System.Windows.Forms.TabPage tpVMList;
        private System.Windows.Forms.Label lblVMName;
        private System.Windows.Forms.TextBox txtVmName;
        private System.Windows.Forms.Label lblResourceGroup;
        private System.Windows.Forms.TextBox txtResourceGroup;
        private System.Windows.Forms.Label lblSubscription;
        private System.Windows.Forms.Button btnGetVMDetails;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TabControl tcVMDetails;
        private System.Windows.Forms.TabPage tpMainDetails;
        private System.Windows.Forms.Label lblVMDetailsNameValue;
        private System.Windows.Forms.Label lblVMDetailsNameLabel;
        private System.Windows.Forms.TabPage tpUsers;
        private System.Windows.Forms.Label lblOSTypeValue;
        private System.Windows.Forms.Label lblOsTypeLabel;
        private System.Windows.Forms.Label lblAdminUserNameValue;
        private System.Windows.Forms.Label lblAdminUSerName;
        private System.Windows.Forms.Label lblGeneralStatusValue;
        private System.Windows.Forms.Label lblGeneralStatus;
        private System.Windows.Forms.ListView lwInstanceViewStatus;
        private System.Windows.Forms.Label lblVMTypeValue;
        private System.Windows.Forms.Label lblVMType;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblVMStatus;
        private System.Windows.Forms.PictureBox pbVMStatus;
        private System.Windows.Forms.TabPage tpResourceGrListups;
        private System.Windows.Forms.Button btnGetResourceGroups;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tpResourceGroupMain;
        private System.Windows.Forms.TabPage tpResouorceGeneral;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tpResourceGroupList;
        private System.Windows.Forms.ListView lwResourceGroups;
        private System.Windows.Forms.Label lblResourceGroupsNumber;
        private System.Windows.Forms.Button btnGetAllVM;
        private System.Windows.Forms.TabPage tpResourceGroupResources;
        private System.Windows.Forms.ListView lwResourcesInREsourceGroup;
        private System.Windows.Forms.Button btnStopResourceByIdNumber;
        private System.Windows.Forms.Button btnRestartResourceByNumber;
        private System.Windows.Forms.Button btnStartResourceById;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lwCloudServices;
        private System.Windows.Forms.Button btnLoadCredentials;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView lwVirtualMachines;
        private System.Windows.Forms.Label lblNumberOfVirtualMachines;
        private System.Windows.Forms.Button btnVMOperation;
        private System.Windows.Forms.CheckBox cbGetStagingSlot;
    }
}

