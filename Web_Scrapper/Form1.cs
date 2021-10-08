using HtmlAgilityPack;
using Squirrel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Scrapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

		}
		List<string> fileName;
		private List<string> ExtractAllImages(string url)
		{
			string path = @"D:\myPic";
			Directory.CreateDirectory(path);

				// declare html document
				var document = new HtmlWeb().Load(url);



				// now using LINQ to grab/list all images from website
				var ImageURLs = document.DocumentNode.Descendants("img")
												.Select(e => e.GetAttributeValue("src", null))
												.Where(s => !String.IsNullOrEmpty(s));
			/*var websiteName = document.DocumentNode.Descendants("img").Select(e => e.GetAttributeValue("alt", null)).Where(s =>String.IsNullOrEmpty(s));

            foreach (var item in websiteName)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(websiteName);*/


				// now showing all images from web page one by one
				//Download File
				WebClient cl = new WebClient();
				fileName = new List<string>();

			if(ImageURLs.Count() >0)
            {
				//var ask = MessageBox.Show("Are you wanna get all images url with some Undownloadable url? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				/*if(ask == DialogResult.Yes)
                {
					foreach (var item in ImageURLs)
					{
						if (item != null)
						{ 
							fileName.Add(item);

							//string fl = item.Substring(0, 10);
							//string ext = ".jpg";

							//cl.DownloadFile(item, path + "\\img" + ext);

						}

					}
				}
                else
                {
					foreach (var item in ImageURLs)
					{
						if (item != null)
						{
							if (item[0] == 'h' && item[1] == 't' && item[2] == 't' && item[3] == 'p')
							{
								fileName.Add(item);

							}
							//string fl = item.Substring(0, 10);
							//string ext = ".jpg";

							//cl.DownloadFile(item, path + "\\img" + ext);

						}

					}
				}*/
				foreach (var item in ImageURLs)
				{
					if (item != null)
					{
						if (item[0] == 'h' && item[1] == 't' && item[2] == 't' && item[3] == 'p')
						{
							fileName.Add(item);

						}
						//string fl = item.Substring(0, 10);
						//string ext = ".jpg";

						//cl.DownloadFile(item, path + "\\img" + ext);

					}

				}

			}
			else
			{
				MessageBox.Show("We can't find images in this url, Make sure to copy url from an actual page", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}



			return fileName;

		}

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

			var imgURL = listBox.SelectedItem.ToString();

			imagePreview.ImageLocation = imgURL.ToString();
			previewImages(imgURL);

		}

		private async Task previewImages(string imgURL)
        {
			await Task.Run(()=> imagePreview.ImageLocation = imgURL.ToString());

		}
		private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if(imagePreview.Image != null)
            {
				SaveFileDialog fd = new SaveFileDialog();
				fd.FileName = Path.GetFileName(imagePreview.ImageLocation);
				fd.Filter = $"Image files(*.{Path.GetExtension(imagePreview.ImageLocation)};*.jpeg) |*.{Path.GetExtension(imagePreview.ImageLocation)};*.jpeg";
				//fd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";



				fd.ShowDialog();
				

				if (fd.FileName.Length > 0)
                {
					string path = fd.FileName;

					using (WebClient client =new WebClient())
                    {
						client.DownloadFile(imagePreview.ImageLocation,fd.FileName);
                    }


                }
            }
            else
            {
				MessageBox.Show("No Image selected!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) ;

			}
		}

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count > 0)
            {
				listBox.Items.Clear();
            }
        }

        private void searchBt_Click(object sender, EventArgs e)
        {
			if (searchBx.Text != "")
			{
				try
				{
					var list = ExtractAllImages(searchBx.Text);

					foreach (var i in list)
					{
						listBox.Items.Add(i);
					}
					itemCount.Text = string.Format("Items : {0}", listBox.Items.Count);
				}
				catch (Exception)
				{
					MessageBox.Show("We can't find images in this url, please check this url or enter a new one!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

			}
		}

        private void imagePreview_MouseUp(object sender, MouseEventArgs e)
        {
			if (e.Button == MouseButtons.Right)
			{
				contextMenuStrip1.Show(imagePreview, e.Location);
			}
		}

		private async Task Download_All_Images()
        {
			FolderBrowserDialog fd = new FolderBrowserDialog();
			fd.ShowDialog();

			if (fd.SelectedPath.Length > 0)
			{
				string path = fd.SelectedPath;

				foreach (string item in listBox.Items)
				{
					using (WebClient client = new WebClient())
					{
						//string removeChar = item.Replace(".", "_").Replace("-", "_").Replace(":","_").Replace("\\","_").Replace("/","");
						string removeChar = Path.GetFileName(item);

						//string removeChar = "animegif.jpg";


						string imagePath = path + "\\" + removeChar;
						Console.WriteLine(imagePath);

						try
						{
							await Task.Run(() => client.DownloadFile(item, imagePath));
							//client.DownloadFileAsync(item, imagePath);

						}
						catch (Exception)
						{
							continue;
						}
					}
				}

			}
		}
        private void downloadAll_Click(object sender, EventArgs e)
        {
			var time = System.Diagnostics.Stopwatch.StartNew();
			Download_All_Images();

			var elapedtime = time.ElapsedMilliseconds;

            Console.WriteLine(elapedtime);
		}

		// auto Update 

		private async Task CheckForUpdate()
        {
			using(var manager = new UpdateManager(@"C:\Temp\Releases"))
            {
				await manager.UpdateApp();
            }
        }
		private void AddVersionNumber()
        {
			//Get assembly information
			System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
			FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

			header.Text += $"  v.{versionInfo.FileVersion}";
        }

        private void listBox_MouseUp(object sender, MouseEventArgs e)
        {
			if(e.Button == MouseButtons.Right)
            {
				contextMenuStrip2.Show(listBox, e.Location);
            }

        }
    }

}
