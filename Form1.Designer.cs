namespace WinSrvAppfabricTester
{
    partial class frmWinSrvAppfabricTester
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCacheServer = new System.Windows.Forms.TextBox();
            this.panConnections = new System.Windows.Forms.Panel();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.checkBoxDomainAcc = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCacheName = new System.Windows.Forms.TextBox();
            this.checkBoxLocalCache = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxSecurity = new System.Windows.Forms.CheckBox();
            this.tab1BasicCacheOperations = new System.Windows.Forms.TabControl();
            this.tabBasicOperations = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGetCacheItem = new System.Windows.Forms.TextBox();
            this.btnAddDataCacheItem = new System.Windows.Forms.Button();
            this.btnGetCacheItem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lstboxGuidCache = new System.Windows.Forms.ListBox();
            this.txtObjectToCache = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabRegionOperations = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lstObjectInRegion = new System.Windows.Forms.ListBox();
            this.btnClearnAllObjectFromRegion = new System.Windows.Forms.Button();
            this.lstAllObjectAllRegions = new System.Windows.Forms.ListBox();
            this.lstRegions = new System.Windows.Forms.ListBox();
            this.btnListRegionsInCache = new System.Windows.Forms.Button();
            this.tabNotifications = new System.Windows.Forms.TabPage();
            this.rtbMontiorCache = new System.Windows.Forms.RichTextBox();
            this.btnClearMonitorItemHistory = new System.Windows.Forms.Button();
            this.txtMonitorItem = new System.Windows.Forms.TextBox();
            this.btnMonitorCacheItem = new System.Windows.Forms.Button();
            this.txtMonitorCacheItem = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMonitorCacheItemValue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCacheItemKeyInFocus = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rtbStatus = new System.Windows.Forms.RichTextBox();
            this.rtbGetCacheItem = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panConnections.SuspendLayout();
            this.tab1BasicCacheOperations.SuspendLayout();
            this.tabBasicOperations.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabRegionOperations.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabNotifications.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "CacheServer";
            // 
            // txtCacheServer
            // 
            this.txtCacheServer.Location = new System.Drawing.Point(102, 3);
            this.txtCacheServer.Name = "txtCacheServer";
            this.txtCacheServer.Size = new System.Drawing.Size(107, 20);
            this.txtCacheServer.TabIndex = 3;
            this.txtCacheServer.Text = "localhost";
            // 
            // panConnections
            // 
            this.panConnections.Controls.Add(this.lblConnectionStatus);
            this.panConnections.Controls.Add(this.label4);
            this.panConnections.Controls.Add(this.btnDisconnect);
            this.panConnections.Controls.Add(this.btnConnect);
            this.panConnections.Controls.Add(this.txtTimeout);
            this.panConnections.Controls.Add(this.checkBoxDomainAcc);
            this.panConnections.Controls.Add(this.label5);
            this.panConnections.Controls.Add(this.txtCacheName);
            this.panConnections.Controls.Add(this.checkBoxLocalCache);
            this.panConnections.Controls.Add(this.label3);
            this.panConnections.Controls.Add(this.txtPort);
            this.panConnections.Controls.Add(this.label2);
            this.panConnections.Controls.Add(this.checkBoxSecurity);
            this.panConnections.Controls.Add(this.txtCacheServer);
            this.panConnections.Controls.Add(this.label1);
            this.panConnections.Location = new System.Drawing.Point(12, 12);
            this.panConnections.Name = "panConnections";
            this.panConnections.Size = new System.Drawing.Size(483, 140);
            this.panConnections.TabIndex = 5;
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(329, 63);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(100, 13);
            this.lblConnectionStatus.TabIndex = 27;
            this.lblConnectionStatus.Text = "NOT CONNECTED";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Connection Status:";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(345, 88);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(118, 41);
            this.btnDisconnect.TabIndex = 16;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(223, 88);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(118, 41);
            this.btnConnect.TabIndex = 15;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtTimeout
            // 
            this.txtTimeout.Location = new System.Drawing.Point(169, 85);
            this.txtTimeout.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(40, 20);
            this.txtTimeout.TabIndex = 24;
            this.txtTimeout.Text = "60";
            // 
            // checkBoxDomainAcc
            // 
            this.checkBoxDomainAcc.AutoSize = true;
            this.checkBoxDomainAcc.Location = new System.Drawing.Point(223, 21);
            this.checkBoxDomainAcc.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxDomainAcc.Name = "checkBoxDomainAcc";
            this.checkBoxDomainAcc.Size = new System.Drawing.Size(203, 17);
            this.checkBoxDomainAcc.TabIndex = 25;
            this.checkBoxDomainAcc.Text = "Cache Service uses Domain Account";
            this.checkBoxDomainAcc.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Connection Timeout (Sec)";
            // 
            // txtCacheName
            // 
            this.txtCacheName.Location = new System.Drawing.Point(102, 60);
            this.txtCacheName.Name = "txtCacheName";
            this.txtCacheName.Size = new System.Drawing.Size(107, 20);
            this.txtCacheName.TabIndex = 9;
            this.txtCacheName.Text = "default";
            // 
            // checkBoxLocalCache
            // 
            this.checkBoxLocalCache.AutoSize = true;
            this.checkBoxLocalCache.Location = new System.Drawing.Point(223, 42);
            this.checkBoxLocalCache.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxLocalCache.Name = "checkBoxLocalCache";
            this.checkBoxLocalCache.Size = new System.Drawing.Size(122, 17);
            this.checkBoxLocalCache.TabIndex = 22;
            this.checkBoxLocalCache.Text = "Enable Local Cache";
            this.checkBoxLocalCache.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cache Name";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(102, 29);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(107, 20);
            this.txtPort.TabIndex = 6;
            this.txtPort.Text = "22233";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cache Server Port";
            // 
            // checkBoxSecurity
            // 
            this.checkBoxSecurity.AutoSize = true;
            this.checkBoxSecurity.Checked = true;
            this.checkBoxSecurity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSecurity.Location = new System.Drawing.Point(223, 0);
            this.checkBoxSecurity.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxSecurity.Name = "checkBoxSecurity";
            this.checkBoxSecurity.Size = new System.Drawing.Size(100, 17);
            this.checkBoxSecurity.TabIndex = 21;
            this.checkBoxSecurity.Text = "Enable Security";
            this.checkBoxSecurity.UseVisualStyleBackColor = true;
            // 
            // tab1BasicCacheOperations
            // 
            this.tab1BasicCacheOperations.Controls.Add(this.tabBasicOperations);
            this.tab1BasicCacheOperations.Controls.Add(this.tabRegionOperations);
            this.tab1BasicCacheOperations.Controls.Add(this.tabNotifications);
            this.tab1BasicCacheOperations.Location = new System.Drawing.Point(5, 538);
            this.tab1BasicCacheOperations.Name = "tab1BasicCacheOperations";
            this.tab1BasicCacheOperations.SelectedIndex = 0;
            this.tab1BasicCacheOperations.Size = new System.Drawing.Size(1135, 531);
            this.tab1BasicCacheOperations.TabIndex = 7;
            // 
            // tabBasicOperations
            // 
            this.tabBasicOperations.Controls.Add(this.panel1);
            this.tabBasicOperations.Location = new System.Drawing.Point(4, 22);
            this.tabBasicOperations.Name = "tabBasicOperations";
            this.tabBasicOperations.Padding = new System.Windows.Forms.Padding(3);
            this.tabBasicOperations.Size = new System.Drawing.Size(1127, 505);
            this.tabBasicOperations.TabIndex = 0;
            this.tabBasicOperations.Text = "Basic Operations";
            this.tabBasicOperations.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtGetCacheItem);
            this.panel1.Controls.Add(this.btnAddDataCacheItem);
            this.panel1.Controls.Add(this.btnGetCacheItem);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lstboxGuidCache);
            this.panel1.Controls.Add(this.txtObjectToCache);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnGet);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 344);
            this.panel1.TabIndex = 7;
            // 
            // txtGetCacheItem
            // 
            this.txtGetCacheItem.Location = new System.Drawing.Point(210, 304);
            this.txtGetCacheItem.Name = "txtGetCacheItem";
            this.txtGetCacheItem.Size = new System.Drawing.Size(896, 20);
            this.txtGetCacheItem.TabIndex = 41;
            // 
            // btnAddDataCacheItem
            // 
            this.btnAddDataCacheItem.Location = new System.Drawing.Point(6, 194);
            this.btnAddDataCacheItem.Name = "btnAddDataCacheItem";
            this.btnAddDataCacheItem.Size = new System.Drawing.Size(199, 23);
            this.btnAddDataCacheItem.TabIndex = 39;
            this.btnAddDataCacheItem.Text = "AddDataCacheItem - 5 day timeout";
            this.btnAddDataCacheItem.UseVisualStyleBackColor = true;
            this.btnAddDataCacheItem.Click += new System.EventHandler(this.btnAddDataCacheItem_Click);
            // 
            // btnGetCacheItem
            // 
            this.btnGetCacheItem.Location = new System.Drawing.Point(6, 301);
            this.btnGetCacheItem.Name = "btnGetCacheItem";
            this.btnGetCacheItem.Size = new System.Drawing.Size(199, 23);
            this.btnGetCacheItem.TabIndex = 37;
            this.btnGetCacheItem.Text = "GetCacheItem";
            this.btnGetCacheItem.UseVisualStyleBackColor = true;
            this.btnGetCacheItem.Click += new System.EventHandler(this.btnGetCacheItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "List of Added Objects";
            // 
            // lstboxGuidCache
            // 
            this.lstboxGuidCache.FormattingEnabled = true;
            this.lstboxGuidCache.HorizontalScrollbar = true;
            this.lstboxGuidCache.Location = new System.Drawing.Point(210, 22);
            this.lstboxGuidCache.Name = "lstboxGuidCache";
            this.lstboxGuidCache.ScrollAlwaysVisible = true;
            this.lstboxGuidCache.Size = new System.Drawing.Size(896, 264);
            this.lstboxGuidCache.TabIndex = 30;
            this.lstboxGuidCache.DoubleClick += new System.EventHandler(this.lstboxGuidCache_DoubleClick);
            // 
            // txtObjectToCache
            // 
            this.txtObjectToCache.Enabled = false;
            this.txtObjectToCache.Location = new System.Drawing.Point(97, 7);
            this.txtObjectToCache.Name = "txtObjectToCache";
            this.txtObjectToCache.Size = new System.Drawing.Size(107, 20);
            this.txtObjectToCache.TabIndex = 19;
            this.txtObjectToCache.Text = "Test Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Object To Cache";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(5, 117);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(199, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update Item Cache Item";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(5, 154);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(199, 23);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "Remove Item Cache";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(5, 79);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(199, 23);
            this.btnGet.TabIndex = 15;
            this.btnGet.Text = "Get Item From Cache";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(199, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add Item To Cache";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabRegionOperations
            // 
            this.tabRegionOperations.Controls.Add(this.panel3);
            this.tabRegionOperations.Location = new System.Drawing.Point(4, 22);
            this.tabRegionOperations.Name = "tabRegionOperations";
            this.tabRegionOperations.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegionOperations.Size = new System.Drawing.Size(1127, 505);
            this.tabRegionOperations.TabIndex = 1;
            this.tabRegionOperations.Text = "Region Details";
            this.tabRegionOperations.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lstObjectInRegion);
            this.panel3.Controls.Add(this.btnClearnAllObjectFromRegion);
            this.panel3.Controls.Add(this.lstAllObjectAllRegions);
            this.panel3.Controls.Add(this.lstRegions);
            this.panel3.Controls.Add(this.btnListRegionsInCache);
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1115, 481);
            this.panel3.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(635, 13);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(354, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Double Click key to pull from cache. See results on Basic Operations TAB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(337, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Object In Selected Region";
            // 
            // lstObjectInRegion
            // 
            this.lstObjectInRegion.FormattingEnabled = true;
            this.lstObjectInRegion.HorizontalScrollbar = true;
            this.lstObjectInRegion.Location = new System.Drawing.Point(336, 222);
            this.lstObjectInRegion.Name = "lstObjectInRegion";
            this.lstObjectInRegion.ScrollAlwaysVisible = true;
            this.lstObjectInRegion.Size = new System.Drawing.Size(771, 238);
            this.lstObjectInRegion.TabIndex = 30;
            this.lstObjectInRegion.DoubleClick += new System.EventHandler(this.lstObjectInRegion_DoubleClick);
            // 
            // btnClearnAllObjectFromRegion
            // 
            this.btnClearnAllObjectFromRegion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearnAllObjectFromRegion.Enabled = false;
            this.btnClearnAllObjectFromRegion.Location = new System.Drawing.Point(341, 3);
            this.btnClearnAllObjectFromRegion.Name = "btnClearnAllObjectFromRegion";
            this.btnClearnAllObjectFromRegion.Size = new System.Drawing.Size(289, 23);
            this.btnClearnAllObjectFromRegion.TabIndex = 29;
            this.btnClearnAllObjectFromRegion.Text = "Clear All Objects From All Regions";
            this.btnClearnAllObjectFromRegion.UseVisualStyleBackColor = true;
            this.btnClearnAllObjectFromRegion.Click += new System.EventHandler(this.btnClearnAllObjectFromRegion_Click);
            // 
            // lstAllObjectAllRegions
            // 
            this.lstAllObjectAllRegions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstAllObjectAllRegions.FormattingEnabled = true;
            this.lstAllObjectAllRegions.HorizontalScrollbar = true;
            this.lstAllObjectAllRegions.Location = new System.Drawing.Point(341, 32);
            this.lstAllObjectAllRegions.Name = "lstAllObjectAllRegions";
            this.lstAllObjectAllRegions.ScrollAlwaysVisible = true;
            this.lstAllObjectAllRegions.Size = new System.Drawing.Size(771, 160);
            this.lstAllObjectAllRegions.TabIndex = 28;
            this.lstAllObjectAllRegions.DoubleClick += new System.EventHandler(this.lstAllObjectAllRegions_DoubleClick);
            // 
            // lstRegions
            // 
            this.lstRegions.FormattingEnabled = true;
            this.lstRegions.HorizontalScrollbar = true;
            this.lstRegions.Location = new System.Drawing.Point(7, 28);
            this.lstRegions.Name = "lstRegions";
            this.lstRegions.ScrollAlwaysVisible = true;
            this.lstRegions.Size = new System.Drawing.Size(324, 433);
            this.lstRegions.TabIndex = 23;
            this.lstRegions.SelectedIndexChanged += new System.EventHandler(this.lstRegions_SelectedIndexChanged);
            this.lstRegions.DoubleClick += new System.EventHandler(this.lstRegions_DoubleClick);
            // 
            // btnListRegionsInCache
            // 
            this.btnListRegionsInCache.Location = new System.Drawing.Point(7, 3);
            this.btnListRegionsInCache.Name = "btnListRegionsInCache";
            this.btnListRegionsInCache.Size = new System.Drawing.Size(324, 23);
            this.btnListRegionsInCache.TabIndex = 22;
            this.btnListRegionsInCache.Text = "List Regions in Cache";
            this.btnListRegionsInCache.UseVisualStyleBackColor = true;
            this.btnListRegionsInCache.Click += new System.EventHandler(this.btnListRegionsInCache_Click);
            // 
            // tabNotifications
            // 
            this.tabNotifications.Controls.Add(this.label13);
            this.tabNotifications.Controls.Add(this.rtbMontiorCache);
            this.tabNotifications.Controls.Add(this.btnClearMonitorItemHistory);
            this.tabNotifications.Controls.Add(this.txtMonitorItem);
            this.tabNotifications.Controls.Add(this.btnMonitorCacheItem);
            this.tabNotifications.Location = new System.Drawing.Point(4, 22);
            this.tabNotifications.Name = "tabNotifications";
            this.tabNotifications.Size = new System.Drawing.Size(1127, 505);
            this.tabNotifications.TabIndex = 2;
            this.tabNotifications.Text = "Cache Notifications";
            this.tabNotifications.UseVisualStyleBackColor = true;
            // 
            // rtbMontiorCache
            // 
            this.rtbMontiorCache.Location = new System.Drawing.Point(7, 71);
            this.rtbMontiorCache.Name = "rtbMontiorCache";
            this.rtbMontiorCache.Size = new System.Drawing.Size(1117, 431);
            this.rtbMontiorCache.TabIndex = 36;
            this.rtbMontiorCache.Text = "";
            this.rtbMontiorCache.TextChanged += new System.EventHandler(this.rtbMontiorCache_TextChanged);
            // 
            // btnClearMonitorItemHistory
            // 
            this.btnClearMonitorItemHistory.Location = new System.Drawing.Point(7, 42);
            this.btnClearMonitorItemHistory.Name = "btnClearMonitorItemHistory";
            this.btnClearMonitorItemHistory.Size = new System.Drawing.Size(198, 23);
            this.btnClearMonitorItemHistory.TabIndex = 35;
            this.btnClearMonitorItemHistory.Text = "Clear Monitor Cache Item History";
            this.btnClearMonitorItemHistory.UseVisualStyleBackColor = true;
            this.btnClearMonitorItemHistory.Click += new System.EventHandler(this.btnClearMonitorItemHistory_Click);
            // 
            // txtMonitorItem
            // 
            this.txtMonitorItem.CausesValidation = false;
            this.txtMonitorItem.Location = new System.Drawing.Point(210, 14);
            this.txtMonitorItem.Name = "txtMonitorItem";
            this.txtMonitorItem.Size = new System.Drawing.Size(914, 20);
            this.txtMonitorItem.TabIndex = 34;
            // 
            // btnMonitorCacheItem
            // 
            this.btnMonitorCacheItem.Location = new System.Drawing.Point(7, 14);
            this.btnMonitorCacheItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnMonitorCacheItem.Name = "btnMonitorCacheItem";
            this.btnMonitorCacheItem.Size = new System.Drawing.Size(198, 23);
            this.btnMonitorCacheItem.TabIndex = 32;
            this.btnMonitorCacheItem.Text = "Monitor Cache Item";
            this.btnMonitorCacheItem.UseVisualStyleBackColor = true;
            this.btnMonitorCacheItem.Click += new System.EventHandler(this.btnMonitorCacheItem_Click);
            // 
            // txtMonitorCacheItem
            // 
            this.txtMonitorCacheItem.Location = new System.Drawing.Point(119, 32);
            this.txtMonitorCacheItem.Name = "txtMonitorCacheItem";
            this.txtMonitorCacheItem.Size = new System.Drawing.Size(502, 20);
            this.txtMonitorCacheItem.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtMonitorCacheItemValue);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtMonitorCacheItem);
            this.panel2.Controls.Add(this.lblCacheItemKeyInFocus);
            this.panel2.Location = new System.Drawing.Point(519, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 137);
            this.panel2.TabIndex = 34;
            // 
            // txtMonitorCacheItemValue
            // 
            this.txtMonitorCacheItemValue.Location = new System.Drawing.Point(119, 57);
            this.txtMonitorCacheItemValue.Name = "txtMonitorCacheItemValue";
            this.txtMonitorCacheItemValue.Size = new System.Drawing.Size(502, 20);
            this.txtMonitorCacheItemValue.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Selected Item VALUE";
            // 
            // lblCacheItemKeyInFocus
            // 
            this.lblCacheItemKeyInFocus.AutoSize = true;
            this.lblCacheItemKeyInFocus.Location = new System.Drawing.Point(3, 35);
            this.lblCacheItemKeyInFocus.Name = "lblCacheItemKeyInFocus";
            this.lblCacheItemKeyInFocus.Size = new System.Drawing.Size(96, 13);
            this.lblCacheItemKeyInFocus.TabIndex = 5;
            this.lblCacheItemKeyInFocus.Text = "Selected Item KEY";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rtbStatus);
            this.panel4.Controls.Add(this.rtbGetCacheItem);
            this.panel4.Location = new System.Drawing.Point(12, 171);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1131, 344);
            this.panel4.TabIndex = 35;
            // 
            // rtbStatus
            // 
            this.rtbStatus.Location = new System.Drawing.Point(5, 3);
            this.rtbStatus.Name = "rtbStatus";
            this.rtbStatus.Size = new System.Drawing.Size(601, 338);
            this.rtbStatus.TabIndex = 1;
            this.rtbStatus.Text = "";
            this.rtbStatus.TextChanged += new System.EventHandler(this.rtbStatus_TextChanged);
            // 
            // rtbGetCacheItem
            // 
            this.rtbGetCacheItem.Location = new System.Drawing.Point(626, 0);
            this.rtbGetCacheItem.Name = "rtbGetCacheItem";
            this.rtbGetCacheItem.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbGetCacheItem.Size = new System.Drawing.Size(490, 341);
            this.rtbGetCacheItem.TabIndex = 41;
            this.rtbGetCacheItem.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "UPDATE STATUS: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(635, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Selected Item Details";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(214, 47);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(291, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "NOTE: Update to cache items can take 5 minutes to appear";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 7);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Select Item Details";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // frmWinSrvAppfabricTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 1081);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tab1BasicCacheOperations);
            this.Controls.Add(this.panConnections);
            this.Name = "frmWinSrvAppfabricTester";
            this.Text = "Windows Server AppFabric Testing Utility";
            this.Load += new System.EventHandler(this.frmWinSrvAppfabricTester_Load);
            this.panConnections.ResumeLayout(false);
            this.panConnections.PerformLayout();
            this.tab1BasicCacheOperations.ResumeLayout(false);
            this.tabBasicOperations.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabRegionOperations.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabNotifications.ResumeLayout(false);
            this.tabNotifications.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCacheServer;
        private System.Windows.Forms.Panel panConnections;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtTimeout;
        private System.Windows.Forms.CheckBox checkBoxDomainAcc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCacheName;
        private System.Windows.Forms.CheckBox checkBoxLocalCache;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxSecurity;
        private System.Windows.Forms.TabControl tab1BasicCacheOperations;
        private System.Windows.Forms.TabPage tabBasicOperations;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtGetCacheItem;
        private System.Windows.Forms.Button btnAddDataCacheItem;
        private System.Windows.Forms.Button btnGetCacheItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstboxGuidCache;
        private System.Windows.Forms.TextBox txtObjectToCache;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabPage tabRegionOperations;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstObjectInRegion;
        private System.Windows.Forms.Button btnClearnAllObjectFromRegion;
        private System.Windows.Forms.ListBox lstAllObjectAllRegions;
        private System.Windows.Forms.ListBox lstRegions;
        private System.Windows.Forms.Button btnListRegionsInCache;
        private System.Windows.Forms.TabPage tabNotifications;
        private System.Windows.Forms.RichTextBox rtbMontiorCache;
        private System.Windows.Forms.Button btnClearMonitorItemHistory;
        private System.Windows.Forms.TextBox txtMonitorItem;
        private System.Windows.Forms.Button btnMonitorCacheItem;
        private System.Windows.Forms.TextBox txtMonitorCacheItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMonitorCacheItemValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCacheItemKeyInFocus;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox rtbStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox rtbGetCacheItem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

