namespace Connector
{
  partial class Form1
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent( )
    {
      this.label1 = new System.Windows.Forms.Label( );
      this.label2 = new System.Windows.Forms.Label( );
      this.btnConnect = new System.Windows.Forms.Button( );
      this.btnExit = new System.Windows.Forms.Button( );
      this.textBox1 = new System.Windows.Forms.TextBox( );
      this.ipTextbox1 = new Connector.IPTextbox( );
      this.SuspendLayout( );
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point( 35, 9 );
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size( 72, 13 );
      this.label1.TabIndex = 0;
      this.label1.Text = "Server Name:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point( 12, 29 );
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size( 95, 13 );
      this.label2.TabIndex = 1;
      this.label2.Text = "Server IP Address:";
      // 
      // btnConnect
      // 
      this.btnConnect.Location = new System.Drawing.Point( 149, 52 );
      this.btnConnect.Name = "btnConnect";
      this.btnConnect.Size = new System.Drawing.Size( 92, 28 );
      this.btnConnect.TabIndex = 2;
      this.btnConnect.Text = "Connect";
      this.btnConnect.UseVisualStyleBackColor = true;
      this.btnConnect.Click += new System.EventHandler( this.btnConnect_Click );
      // 
      // btnExit
      // 
      this.btnExit.Location = new System.Drawing.Point( 12, 52 );
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size( 92, 28 );
      this.btnExit.TabIndex = 3;
      this.btnExit.Text = "Exit";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler( this.btnExit_Click );
      // 
      // textBox1
      // 
      this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox1.Location = new System.Drawing.Point( 112, 6 );
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size( 129, 20 );
      this.textBox1.TabIndex = 4;
      // 
      // ipTextbox1
      // 
      this.ipTextbox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.ipTextbox1.Location = new System.Drawing.Point( 112, 28 );
      this.ipTextbox1.Name = "ipTextbox1";
      this.ipTextbox1.Size = new System.Drawing.Size( 129, 18 );
      this.ipTextbox1.TabIndex = 5;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size( 247, 88 );
      this.Controls.Add( this.ipTextbox1 );
      this.Controls.Add( this.textBox1 );
      this.Controls.Add( this.btnExit );
      this.Controls.Add( this.btnConnect );
      this.Controls.Add( this.label2 );
      this.Controls.Add( this.label1 );
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "Odyssey Connector";
      this.ResumeLayout( false );
      this.PerformLayout( );

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnConnect;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.TextBox textBox1;
    private IPTextbox ipTextbox1;
  }
}

