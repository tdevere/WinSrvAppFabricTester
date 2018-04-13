using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ApplicationServer.Caching;

namespace WinSrvAppfabricTester
{
    public partial class frmWinSrvAppfabricTester : Form
    {
        System.Timers.Timer SetObjectTime = new System.Timers.Timer(1000);
        static DataCache myCache;
        static DataCacheFactory myCacheFactory;
        static List<DataCacheNotificationDescriptor> callbacks = new List<DataCacheNotificationDescriptor>();

        //DataCacheItemNotifcation
        DataCacheNotificationDescriptor dcnd;


        public frmWinSrvAppfabricTester()
        {
            InitializeComponent();
        }

        private void frmWinSrvAppfabricTester_Load(object sender, EventArgs e)
        {
            SetObjectTime.Elapsed += SetObjectTime_Elapsed;
            SetObjectTime.Start();
            txtCacheServer.Text = System.Environment.MachineName.ToString();
            txtObjectToCache.Text = DateTime.Now.ToLongTimeString();
        }

        private void SetObjectTime_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                txtObjectToCache.Invoke((MethodInvoker)delegate { txtObjectToCache.Text = DateTime.Now.ToLongTimeString(); });
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void HandleException(Exception ex)
        {
            rtbStatus.Text += "Exception Caught at: " + DateTime.Now.ToLongTimeString();
            if (ex.Message != null)
            {
                rtbStatus.AppendText("\r" + "Exception Message");
                rtbStatus.AppendText("\r" + ex.Message.ToString());
                
            }
            if (ex.InnerException != null)
            {
                rtbStatus.AppendText("\r" + "InnerException");
                rtbStatus.AppendText("\r" + ex.InnerException.ToString());
                
            }
            if (ex.StackTrace != null)
            {
                rtbStatus.AppendText("\r" + "StackTrace");
                rtbStatus.AppendText("\r" + ex.StackTrace.ToString());
                
            }
        }

        private void UpdateStatus(string status)
        {
            rtbStatus.AppendText("\r"+ "Status Update at: " + DateTime.Now.ToLongTimeString());
            rtbStatus.AppendText("\r" + status);
            rtbStatus.AppendText("\r" + "Status Update End");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (myCache == null)
            {
                try
                {
                    DataCacheServerEndpoint[] servers = new DataCacheServerEndpoint[1];
                    servers[0] = new DataCacheServerEndpoint(txtCacheServer.Text, int.Parse(txtPort.Text));
                    DataCacheFactoryConfiguration factoryConfig = new DataCacheFactoryConfiguration();
                    factoryConfig.Servers = servers;


                    if (!(checkBoxSecurity.Checked))
                    {
                        DataCacheSecurity security = new DataCacheSecurity(DataCacheSecurityMode.None, DataCacheProtectionLevel.None);
                        factoryConfig.SecurityProperties = security;
                    }

                    //You must set the security authentication account type to DomainAccount on the client side 
                    //when the caching service identity is a domain account. The default type is SystemAccount.
                    if (checkBoxDomainAcc.Checked)
                    {
                        factoryConfig.DataCacheServiceAccountType = DataCacheServiceAccountType.DomainAccount;
                    }

                    if (checkBoxLocalCache.Checked)
                    {
                        //TimeSpan localTimeout = new TimeSpan(0, 1, 0);
                        TimeSpan localTimeout = TimeSpan.FromSeconds(Convert.ToDouble(txtTimeout.Text));
                        DataCacheLocalCacheProperties localCacheConfig = new DataCacheLocalCacheProperties(10000,
           localTimeout, DataCacheLocalCacheInvalidationPolicy.TimeoutBased);
                        factoryConfig.LocalCacheProperties = localCacheConfig;
                    }


                    myCacheFactory = new DataCacheFactory(factoryConfig);
                    myCache = myCacheFactory.GetCache(txtCacheName.Text);

                    //this.Text = "AppFabric Test Client has connected to Cache Cluster...";
                    UpdateStatus("You have connected to the Cache Cluster.");
                    lblConnectionStatus.Text = "CONNECTED";


                }
                catch (Exception ex)
                {
                    HandleException(ex);
                }
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (myCacheFactory != null)
                {
                    myCacheFactory.Dispose();
                    myCache = null;
                    myCacheFactory = null;
                }

                UpdateStatus("You have disconnected from the Cache Cluster.");
                lblConnectionStatus.Text = "NOT CONNECTED";
            }
            catch(Exception ex)
            {
                HandleException(ex);
            }

            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (myCache == null)
            {
                UpdateStatus("First click Connect To Cache");
                return;
            }

            try
            {
                Guid key = Guid.NewGuid();
                myCache.Add(key.ToString(), txtObjectToCache.Text);
                lstboxGuidCache.Items.Add(key.ToString());
                txtMonitorCacheItem.Text = key.ToString();

                UpdateStatus("Added Item to Cache");
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (lstboxGuidCache.SelectedItem != null)
            {
                try
                {
                    PullObjectFromCache(lstboxGuidCache.SelectedItem.ToString());
                }
                catch (Exception ex)
                {
                    HandleException(ex);
                }
            }
            else
            {
                UpdateStatus("You must select an item to retrive.");
            }
        }

        void PullObjectFromCache(string objectID)
        {
            object pullFromCache = new object();

            if (myCache == null)
            {
                UpdateStatus("First click Connect To Cache");
                return;
            }

            try
            {
                if (objectID != null)
                {
                    pullFromCache = myCache.Get(objectID);
                    if (pullFromCache != null)
                    {
                        UpdateStatus("Retrived item from cache");
                        txtMonitorCacheItem.Text = objectID;
                        txtMonitorCacheItemValue.Text = pullFromCache.ToString();
                        txtGetCacheItem.Text = objectID;
                        txtMonitorItem.Text = objectID;
                        
                    }
                    else
                    {
                        UpdateStatus("Retrived NULL response from cache");
                        txtMonitorCacheItem.Text = objectID;
                        txtMonitorCacheItemValue.Text = "Retrived NULL from cache";                     
                    }

                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (myCache == null)
            {
                UpdateStatus("First click Connect To Cache");
                return;
            }

            if (lstboxGuidCache.SelectedItem != null)
            {
                try
                {
                    //myCache.ResetObjectTimeout()
                    myCache.Put(lstboxGuidCache.SelectedItem.ToString(), txtObjectToCache.Text);
                    UpdateStatus("Updated item in cache");
                }
                catch (Exception ex)
                {
                    HandleException(ex);
                }
            }
            else
            {
                UpdateStatus("You must select an item to update.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool isRemoved = false;

            if (myCache == null)
            {
                UpdateStatus("First click Connect To Cache");
                return;
            }

            if (lstboxGuidCache.SelectedItem != null)
            {
                try
                {

                    isRemoved = myCache.Remove(lstboxGuidCache.SelectedItem.ToString());

                    if (isRemoved)
                    {
                        if (lstboxGuidCache.SelectedItem != null)
                        {
                            lstboxGuidCache.Items.Remove(lstboxGuidCache.SelectedItem.ToString());
                        }

                        UpdateStatus("Removed item from cache");
                    }
                    else
                    {
                        UpdateStatus("Failed to remove item from cache");
                    }
                }
                catch (Exception ex)
                {
                    HandleException(ex);
                }
            }
            else
            {
                UpdateStatus("You must select an item to remove.");
            }
        }

        private void btnAddDataCacheItem_Click(object sender, EventArgs e)
        {
            if (myCache == null)
            {
                UpdateStatus("First click Connect To Cache");
                return;
            }

            try
            {
                Guid key = Guid.NewGuid();
                myCache.Add(key.ToString(), txtObjectToCache.Text, TimeSpan.FromDays(5));
                lstboxGuidCache.Items.Add(key.ToString());
                txtMonitorCacheItem.Text = key.ToString();

                UpdateStatus("Added Item to Cache");
                txtMonitorCacheItem.Text = key.ToString();
                txtMonitorCacheItemValue.Text = txtObjectToCache.Text;
                
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void btnGetCacheItem_Click(object sender, EventArgs e)
        {
            rtbGetCacheItem.Clear();

            if (txtGetCacheItem.Text != null)
            {
                try
                {
                    GetCacheItem(txtGetCacheItem.Text);
                }
                catch (Exception ex)
                {
                    HandleException(ex);
                }
            }
            else
            {
                UpdateStatus("You must select an item to retrive.");
            }
        }

        private void GetCacheItem(string objectID)
        {
            rtbGetCacheItem.Clear();

            DataCacheItem dcItem = new DataCacheItem();

            if (myCache == null)
            {
                UpdateStatus("First click Connect To Cache");
                return;
            }

            try
            {
                if (objectID != null)
                {

                    txtGetCacheItem.Text = objectID;
                    txtMonitorItem.Text = objectID;

                    txtMonitorCacheItem.Text = objectID;
                    

                    dcItem = myCache.GetCacheItem(objectID);

                    if (dcItem != null)
                    {
                        UpdateStatus("Retrived item from cache");

                        txtMonitorCacheItemValue.Text = dcItem.Value.ToString();

                        rtbGetCacheItem.AppendText("\r\n" + "Last Updated at " + DateTime.Now.ToLongTimeString());
                        rtbGetCacheItem.AppendText("\r" + "CacheName: " + dcItem.CacheName);
                        rtbGetCacheItem.AppendText("\r" + "Key:" + dcItem.Key);
                        rtbGetCacheItem.AppendText("\r" + "RegionName: " + dcItem.RegionName);
                        rtbGetCacheItem.AppendText("\r" + "Size: " + dcItem.Size);
                        //lstGetCacheItem.Items.Add(dcItem.Tags);
                        rtbGetCacheItem.AppendText("\r" + "Timeout: " + dcItem.Timeout);
                        rtbGetCacheItem.AppendText("\r" + "Value: " + dcItem.Value);
                        rtbGetCacheItem.AppendText("\r" + "Version: " + dcItem.Version);
                    }
                    else
                    {
                        UpdateStatus("Retrived NULL from cache");
                        txtMonitorCacheItemValue.Text = "Retrived NULL from cache";
                    }

                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                //MessageBox.Show(ex.StackTrace);
                HandleException(ex);
            }
        }

        private void lstboxGuidCache_DoubleClick(object sender, EventArgs e)
        {
            
            if (lstboxGuidCache.SelectedItem != null)
            {
                try
                {
                    GetCacheItem(lstboxGuidCache.SelectedItem.ToString());
                }
                catch (Exception ex)
                {
                    HandleException(ex);
                }
            }
            else
            {
                MessageBox.Show("You must select an item to retrive.");
            }
        }

        private void btnListRegionsInCache_Click(object sender, EventArgs e)
        {
            if (myCache == null)
            {
                UpdateStatus("First click Connect To Cache");
                return;
            }

            lstRegions.DataSource = null;
            lstRegions.Items.Clear();
            lstObjectInRegion.DataSource = null;
            lstObjectInRegion.Items.Clear();
            lstAllObjectAllRegions.DataSource = null;
            lstAllObjectAllRegions.Items.Clear();
            lstRegions.DataSource = myCache.GetSystemRegions();
            BuildAllObjectsFromAllRegionList();
        }

        void BuildAllObjectsFromAllRegionList()
        {
            try
            {
                lstObjectInRegion.DataSource = null;
                lstObjectInRegion.Items.Clear();
                lstAllObjectAllRegions.DataSource = null;
                lstAllObjectAllRegions.Items.Clear();

                List<string> ObjectUpdateList = new List<string>();
                foreach (string region in myCache.GetSystemRegions())
                {
                    foreach (var keys in myCache.GetObjectsInRegion(region))
                    {
                        //ObjectUpdateList.Add(string.Format("Region: {0}, Key: {1}, Value {2}", region, keys.Key.ToString(), keys.Value.ToString()));
                        ObjectUpdateList.Add(keys.Key);
                        //ObjectUpdateList.Add(string.Format("Region: {0}, Key: {1}, Value {2}", region, keys.Key.ToString(), keys.Value.ToString()));
                    }
                }

                lstAllObjectAllRegions.DataSource = ObjectUpdateList;
            }
            catch(Exception ex)
            {
                HandleException(ex);
            }
        }

        private void lstAllObjectAllRegions_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (lstAllObjectAllRegions.SelectedItem != null)
                {
                    try
                    {
                        GetCacheItem(lstAllObjectAllRegions.SelectedItem.ToString());
                    }
                    catch (Exception ex)
                    {
                        HandleException(ex);
                    }
                }
                else
                {
                    UpdateStatus("You must select an item to retrive.");
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void lstObjectInRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstboxGuidCache.Items.Count > 0)
                PullObjectFromCache(lstObjectInRegion.SelectedItem.ToString());
        }

        private void lstRegions_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                lstObjectInRegion.DataSource = null;
                List<string> ObjectUpdateList = new List<string>();
                string region = lstRegions.SelectedItem.ToString();

                foreach (var results in myCache.GetObjectsInRegion(region))
                {
                    ObjectUpdateList.Add(results.Key);
                }

                lstObjectInRegion.DataSource = ObjectUpdateList;
            }
            catch(Exception ex)
            {
                HandleException(ex);
            }
        }

        private void lstRegions_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{

            //    lstObjectInRegion.DataSource = null;
            //    List<string> ObjectUpdateList = new List<string>();
            //    string region = lstRegions.SelectedItem.ToString();

            //    foreach (var results in myCache.GetObjectsInRegion(region))
            //    {
            //        ObjectUpdateList.Add(results.Key);
            //    }

            //    lstObjectInRegion.DataSource = ObjectUpdateList;
            //}
            //catch (Exception ex)
            //{
            //    HandleException(ex);
            //}
        }

        private void lstObjectInRegion_DoubleClick(object sender, EventArgs e)
        {
            if (lstboxGuidCache.Items.Count > 0)
                PullObjectFromCache(lstObjectInRegion.SelectedItem.ToString());
        }

        private void btnClearnAllObjectFromRegion_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> ObjectUpdateList = new List<string>();
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear objects from all regions?", "Dangerous Operation", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    if (lstRegions.SelectedItem.ToString() != null)
                    {
                        myCache.ClearRegion(lstRegions.SelectedItem.ToString());
                    }

                    lstboxGuidCache.Items.Clear();
                    BuildAllObjectsFromAllRegionList();
                }
            }
            catch(Exception ex)
            {
                HandleException(ex);
            }
        }

        private void btnMonitorCacheItem_Click(object sender, EventArgs e)
        {
            string key = txtMonitorItem.Text.Trim();

            if (myCache == null)
            {
                UpdateStatus("First click Connect To Cache");
                return;
            }

            if (key.Length < 1)
            {
                MessageBox.Show("You must enter at least 1 valid key to montior.");
                return;
            }


            try
            {
                DataCacheNotificationDescriptor dcnd = myCache.AddItemLevelCallback(key,
                DataCacheOperations.AddItem | DataCacheOperations.RemoveItem | DataCacheOperations.ReplaceItem,
                DataCacheItemCallBackHandler);

                callbacks.Add(dcnd);

                //lstboxMontiorItemHistory.Items.Add("Time: " + DateTime.Now.ToLongTimeString() + " Key: " + key + " has been added to monitor list");
                rtbMontiorCache.AppendText("\r"+ "Time: " + DateTime.Now.ToLongTimeString() + " Key: " + key + " has been added to monitor list");

                UpdateStatus("Setup ItemLevelCallBack for Item.");
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        public void DataCacheItemCallBackHandler(string cacheName, string regionName, string key,
            DataCacheItemVersion version, DataCacheOperations cacheOperation, DataCacheNotificationDescriptor nd)
        {
            try
            {
                string result = string.Format("Time: {0} CacheName: {1}  Region {2} Key: {3} DataCacheOperation: {4}", DateTime.Now.ToLongTimeString(), 
                    cacheName, regionName, key, cacheOperation.ToString());
                rtbMontiorCache.Invoke((MethodInvoker)delegate { rtbMontiorCache.AppendText("\r\n" + result); });
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }

        }

        private void btnClearMonitorItemHistory_Click(object sender, EventArgs e)
        {
            rtbMontiorCache.Clear();
        }

        private void rtbStatus_TextChanged(object sender, EventArgs e)
        {
            rtbStatus.ScrollToCaret();
        }

        private void rtbGetCacheItem_TextChanged(object sender, EventArgs e)
        {
            rtbGetCacheItem.ScrollToCaret();
        }

        private void rtbMontiorCache_TextChanged(object sender, EventArgs e)
        {
            rtbMontiorCache.ScrollToCaret();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
