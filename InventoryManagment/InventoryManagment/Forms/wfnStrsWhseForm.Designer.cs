﻿namespace StoresAndInventoryManager.Forms
{
  partial class wfnStrsWhseForm
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
      this.SuspendLayout();
      // 
      // wfnStrsWhseForm
      // 
      this.ClientSize = new System.Drawing.Size(284, 262);
      this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Name = "wfnStrsWhseForm";
      this.TabText = "Stores/Warehouses";
      this.Text = "Stores/Warehouses";
      this.Load += new System.EventHandler(this.wfnStrsWhseForm_Load);
      this.ResumeLayout(false);

    }

    #endregion
  }
}
