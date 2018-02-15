﻿using System;
using System.Text;
using System.Windows.Forms;

namespace osukps {
	public partial class frmPrompt : Form {

		public static string Prompt(string question, string placeholder, string okbuttontext) {
			frmPrompt f = new frmPrompt();
			f.btnOk.Text = okbuttontext;
			f.txtInput.Text = placeholder;
			f.lblQuestion.Text = question;
			return f.ShowDialog() == DialogResult.OK ? f.txtInput.Text : null;
		}

		public frmPrompt() {
			InitializeComponent();
		}

		private void OnBtnClick(object sender, EventArgs e) {
			Close();
		}

	}
}