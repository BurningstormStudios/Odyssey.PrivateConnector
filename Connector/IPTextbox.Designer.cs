using System.Windows.Forms;

namespace Connector
{
  partial class IPTextbox
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing )
    {
      if ( disposing && ( components != null ) )
      {
        components.Dispose( );
      }
      base.Dispose( disposing );
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent( )
    {
      this.textBox1 = new System.Windows.Forms.TextBox( );
      this.textBox2 = new System.Windows.Forms.TextBox( );
      this.textBox3 = new System.Windows.Forms.TextBox( );
      this.textBox4 = new System.Windows.Forms.TextBox( );
      this.label1 = new System.Windows.Forms.Label( );
      this.label2 = new System.Windows.Forms.Label( );
      this.label3 = new System.Windows.Forms.Label( );
      this.panel = new System.Windows.Forms.Panel( );
      this.panel.SuspendLayout( );
      this.SuspendLayout( );
      // 
      // textBox1
      // 
      this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox1.Location = new System.Drawing.Point( 4, 1 );
      this.textBox1.MaxLength = 3;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size( 20, 13 );
      this.textBox1.TabIndex = 0;
      this.textBox1.Text = "0";
      this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.textBox1.Enter += new System.EventHandler( this.textBox_Enter );
      this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler( this.textBox1_KeyPress );
      this.textBox1.Leave += new System.EventHandler( this.textBox_Leave );
      // 
      // textBox2
      // 
      this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox2.Location = new System.Drawing.Point( 34, 1 );
      this.textBox2.MaxLength = 3;
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size( 20, 13 );
      this.textBox2.TabIndex = 1;
      this.textBox2.Text = "0";
      this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.textBox2.Enter += new System.EventHandler( this.textBox_Enter );
      this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler( this.textBox2_KeyPress );
      this.textBox2.Leave += new System.EventHandler( this.textBox_Leave );
      // 
      // textBox3
      // 
      this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox3.Location = new System.Drawing.Point( 66, 1 );
      this.textBox3.MaxLength = 3;
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size( 20, 13 );
      this.textBox3.TabIndex = 2;
      this.textBox3.Text = "0";
      this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.textBox3.Enter += new System.EventHandler( this.textBox_Enter );
      this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler( this.textBox3_KeyPress );
      this.textBox3.Leave += new System.EventHandler( this.textBox_Leave );
      // 
      // textBox4
      // 
      this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox4.Location = new System.Drawing.Point( 100, 1 );
      this.textBox4.MaxLength = 3;
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size( 20, 13 );
      this.textBox4.TabIndex = 3;
      this.textBox4.Text = "0";
      this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.textBox4.Enter += new System.EventHandler( this.textBox_Enter );
      this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler( this.textBox4_KeyPress );
      this.textBox4.Leave += new System.EventHandler( this.textBox_Leave );
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point( 24, 1 );
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size( 8, 13 );
      this.label1.TabIndex = 1;
      this.label1.Text = ".";
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point( 55, 1 );
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size( 8, 13 );
      this.label2.TabIndex = 5;
      this.label2.Text = ".";
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point( 88, 1 );
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size( 8, 13 );
      this.label3.TabIndex = 6;
      this.label3.Text = ".";
      // 
      // panel
      // 
      this.panel.BackColor = System.Drawing.SystemColors.Window;
      this.panel.Controls.Add( this.label3 );
      this.panel.Controls.Add( this.label2 );
      this.panel.Controls.Add( this.textBox1 );
      this.panel.Controls.Add( this.textBox2 );
      this.panel.Controls.Add( this.textBox3 );
      this.panel.Controls.Add( this.textBox4 );
      this.panel.Controls.Add( this.label1 );
      this.panel.Location = new System.Drawing.Point( 0, 1 );
      this.panel.Name = "panel";
      this.panel.Size = new System.Drawing.Size( 128, 18 );
      this.panel.TabIndex = 0;
      // 
      // IPTextbox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add( this.panel );
      this.Name = "IPTextbox";
      this.Size = new System.Drawing.Size( 128, 18 );
      this.panel.ResumeLayout( false );
      this.panel.PerformLayout( );
      this.ResumeLayout( false );

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox4;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Panel panel;
  }
}
