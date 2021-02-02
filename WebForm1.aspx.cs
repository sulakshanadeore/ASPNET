using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Caching;
using System.IO;

namespace DataCachingDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        public CacheItemRemovedCallback del = new CacheItemRemovedCallback(MyMethod);
        string data = null;
        protected void Button1_Click(object sender, EventArgs e)
        {
            //Cache["j"] = 10;
            CacheDependency dependency = new CacheDependency(@"D:\Sulakshana\Mphasis183\C#Demos\DataCachingDemo\DataCachingDemo\cursorKeyPoints.txt", DateTime.Now);
            FileStream fs = new FileStream(@"D:\Sulakshana\Mphasis183\C#Demos\DataCachingDemo\DataCachingDemo\cursorKeyPoints.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            data= sr.ReadToEnd();
            sr.Close();
            sr.Dispose();
            //fs.Flush();
            fs.Close();
            fs.Dispose();
            //Cache.Insert("mydata", data, dependency, Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(1));
            
            Cache.Add("mydata", data, dependency, DateTime.Now.AddSeconds(30), Cache.NoSlidingExpiration, CacheItemPriority.High, del);
            Cache.Insert("secondcopy", data);
            
            
            
                }
        public static void MyMethod(string s, object o, CacheItemRemovedReason r)
        {
            r = CacheItemRemovedReason.Removed;
            //string actual = actual1.ToString();
            //if (actual!=mydata)
            //{
            //    CacheItemRemovedReason reason = r;
                
            //}
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Response.Write(Cache["j"].ToString());
            //Response.Write("<br/>");
            //Response.Write(Cache.Get("j").ToString());
           
            //string mydata = data;
            //object actual1 = Cache.Get("mydata");

            if (Cache["mydata"]!=Cache["secondcopy"])
            {
                del("mydata", data, CacheItemRemovedReason.DependencyChanged);
                CacheItemRemovedReason reason = CacheItemRemovedReason.DependencyChanged;
                Response.Write(reason.ToString());
                TextBox1.Text = "Data changed from cache.. No data";
            }
            else
            {

                TextBox1.Text = Cache["mydata"].ToString();
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Cache.Remove("mydata");
            Cache.Remove("secondcopy");

            del("mydata", data, CacheItemRemovedReason.Removed);
            string mydata = data;
            object actual1 = Cache.Get("mydata");
            if (actual1 == null)
            {
                CacheItemRemovedReason reason = CacheItemRemovedReason.Removed;
                Response.Write(reason.ToString());
                TextBox1.Text = "Data removed from cache.. No data";
            }
            //else if (actual1 != mydata)
            //{
            //    CacheItemRemovedReason reason = r;
            //    Response.Write(reason.ToString());
            //}
            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
