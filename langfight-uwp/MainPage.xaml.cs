using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Web.Http;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace langfight_uwp
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ListView lv = new ListView();
            lv.Items.Add("Item a");
            lv.Items.Add("Item b");
            spMain.Children.Add(lv);
            Debug.WriteLine("nothing possible");
            GetData();
        }
        public async void GetData()
        {
            var uri = new Uri("https://www.netroby.com");

            var client = new HttpClient();
            var resp = await client.GetAsync(uri);
            var result = await resp.Content.ReadAsStringAsync();
            Debug.WriteLine(result);
        }
        
    }
}
