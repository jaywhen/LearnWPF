using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListDb
{
	public class Tags
	{
		public Tags() { }
		public Tags(string name, List<string> data)
		{
			this.name = name;
			this.data = data;
		}
		public string name { get; set; }
		public List<string> data { get; set; }
	}
	/// <summary>
	/// MainWindow.xaml 的交互逻辑
	/// </summary>
	public partial class MainWindow : Window
	{
		public List<Tags> tags;

		public MainWindow()
		{
			InitializeComponent();
			createGroups();
			// var d = createData();
			ListViewTest.ItemsSource = tags;
			
		}

		public List<string> createData()
		{
			List<string> datas = new List<string>();
			datas.Add("春暖花开");
			datas.Add("上善若水");
			datas.Add("心如止水");
			datas.Add("幸福一家人");
			datas.Add("春暖花开");
			datas.Add("上善若水");
			datas.Add("心如止水");
			datas.Add("幸福一家人");
			datas.Add("酒醉的蝴蝶");

			return datas;
		}
		
		public void createGroups()
		{
			List<string> d = createData();
			Tags it1 = new Tags("csv files", d);
			Tags it2 = new Tags("friends", d);
			Tags it3 = new Tags("family", d);
			Tags it4 = new Tags("classmates", d);
			List<Tags> ts = new List<Tags>();
			ts.Add(it1);
            ts.Add(it2);
            ts.Add(it3);
            ts.Add(it4);

            this.tags = ts;
		}

        private void ListView_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
			if (!e.Handled)
			{
				// ListView拦截鼠标滚轮事件
				e.Handled = true;

				// 激发一个鼠标滚轮事件，冒泡给外层ListView接收到
				var eventArg = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta);
				eventArg.RoutedEvent = UIElement.MouseWheelEvent;
				eventArg.Source = sender;
				var parent = ((Control)sender).Parent as UIElement;
				parent.RaiseEvent(eventArg);
			}
		}

    }
}
