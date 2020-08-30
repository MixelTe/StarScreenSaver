using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarScreen
{
	public partial class Form2 : Form
	{
		private StarsSettings _Settings = new StarsSettings();
		public Form2()
		{
			InitializeComponent();
			
			ChangeLanguage();

			_Settings.Load();

			SizeUnD.Minimum = StarsSettings.D_dStarSize + 1;
			SpeedUnD.Minimum = StarsSettings.D_dGrowSpeed + 1;
			LifeTimeUnD.Minimum = StarsSettings.D_dLifeTime + 1;

			SetFields();
		}
		private void ChangeLanguage()
		{
			if (CultureInfo.CurrentUICulture.Name == "ru-RU")
			{
				Text = "Звёзды";

				GroupBoxStar.Text = "Звёзды";
				DensityLbl.Text = "Плотность";
				SizeLbl.Text = "Размер";
				SpeedLbl.Text = "Скорость мерцания";
				LifeTimeLbl.Text = "Время жизни";

				GroupBoxConections.Text = "Соединения";
				CreateConecionsChB.Text = "Создавать соединения";
				MaxLengthLbl.Text = "Макс. длина";

				ResetBtn.Text = "Сбросить";
				OkBtn.Text = "ОК";
			}
		}

		private void SetFields()
		{
			DensityUnD.Value = _Settings.GetDensity();
			SizeUnD.Value = _Settings.MaxStarSize;
			SpeedUnD.Value = _Settings.MaxGrowSpeed;
			LifeTimeUnD.Value = _Settings.MaxLifeTime;
			CreateConecionsChB.Checked = _Settings.CreateConections;
			MaxLengthUnD.Value = _Settings.MaxDistance;
		}
		private void ResetFields()
		{
			DensityUnD.Value = StarsSettings.D_Density;
			SizeUnD.Value = StarsSettings.D_MaxStarSize;
			SpeedUnD.Value = StarsSettings.D_MaxGrowSpeed;
			LifeTimeUnD.Value = StarsSettings.D_MaxLifeTime;
			CreateConecionsChB.Checked = StarsSettings.D_CreateConections;
			MaxLengthUnD.Value = StarsSettings.D_MaxDistance;
		}

		private void DensityUnD_ValueChanged(object sender, EventArgs e)
		{
			_Settings.Density = (int)DensityUnD.Value;
		}
		private void SizeUnD_ValueChanged(object sender, EventArgs e)
		{
			_Settings.MaxStarSize = (int)SizeUnD.Value;
		}
		private void SpeedUnD_ValueChanged(object sender, EventArgs e)
		{
			_Settings.MaxGrowSpeed = (int)SpeedUnD.Value;
		}
		private void LifeTimeUnD_ValueChanged(object sender, EventArgs e)
		{
			_Settings.MaxLifeTime = (int)LifeTimeUnD.Value;
		}
		private void CreateConecionsChB_CheckedChanged(object sender, EventArgs e)
		{
			_Settings.CreateConections = CreateConecionsChB.Checked;
		}
		private void MaxLengthUnD_ValueChanged(object sender, EventArgs e)
		{
			_Settings.MaxDistance = (int)MaxLengthUnD.Value;
		}
		private void ResetBtn_Click(object sender, EventArgs e)
		{
			ResetFields();
			_Settings = new StarsSettings();
		}


		private void OkBtn_Click(object sender, EventArgs e)
		{
			_Settings.Save();
			Close();
		}

		private void PictureBoxGitHub_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("https://github.com/MixelTe/StarScreenSaver");
			}
			catch (Exception)
			{
				MessageBox.Show("https://github.com/MixelTe/StarScreenSaver" + "\n\nCopied to clipboard", "StarScreen: Source code", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Clipboard.SetText("https://github.com/MixelTe/StarScreenSaver");
			}
		}
	}
}
