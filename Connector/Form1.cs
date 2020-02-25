using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Connector
{
  public partial class Form1 : Form
  {
    private string _serverName;
    private string _serverIP;

    public Form1( )
    {
      InitializeComponent( );

      if ( Properties.Settings.Default != null )
      {
        _serverName = Properties.Settings.Default.ServerName;
        _serverIP = Properties.Settings.Default.ServerIP;
      }
      else
      {
        _serverName = "1";
        _serverIP = "127.0.0.1";
      }

      if ( !string.IsNullOrEmpty( _serverName ) )
        textBox1.Text = _serverName = "1";

      if ( !string.IsNullOrEmpty( _serverIP ) || _serverIP == "0.0.0.0" || _serverIP == "255.255.255.255" )
        ipTextbox1.Text = _serverIP = "127.0.0.1";
    }

    private void btnConnect_Click( object sender, EventArgs e )
    {
      var path = Application.StartupPath;
      if ( System.IO.File.Exists( path + "\\ody.exe" ) )
      {
        if ( !string.IsNullOrEmpty( textBox1.Text ) && !string.IsNullOrEmpty( ipTextbox1.Text ) )
        {
          _serverName = Properties.Settings.Default.ServerName = _serverName;
          _serverIP = Properties.Settings.Default.ServerIP = _serverIP;
          Properties.Settings.Default.Save( );

          var p = new Process
          {
            StartInfo =
            {
              FileName        = path + "\\ody.exe",
              Arguments       = _serverName + "%20" + _serverIP + "",
              UseShellExecute = false
            }
          };
          p.Start( );

          Application.Exit( );
        }
      }
      else
        MessageBox.Show( Properties.Resources.ODY_EXE_ERR, Properties.Resources.ODY_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error );
    }

    private void btnExit_Click( object sender, EventArgs e )
    {
      Application.Exit( );
    }
  }
}