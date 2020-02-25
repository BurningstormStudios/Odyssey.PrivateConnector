using System;
using System.Windows.Forms;
using Connector.Properties;

namespace Connector
{
  public partial class IPTextbox : UserControl
  {
    public override string Text
    {
      get
      {
        return string.Format( Resources.ODY_IPADDR_FORMAT, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text );
      }
      set
      {
        if ( !string.IsNullOrEmpty( value ) )
        {
          var ipaddr = value.Split( '.' );
          textBox1.Text = ipaddr[0];
          textBox2.Text = ipaddr[1];
          textBox3.Text = ipaddr[2];
          textBox4.Text = ipaddr[3];
        }
        else
          textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = string.Empty;
      }
    }

    private void textBox1_KeyPress( object sender, KeyPressEventArgs e )
    {
      if ( Char.IsDigit( e.KeyChar ) || e.KeyChar == Convert.ToChar( Keys.Back ) || e.KeyChar == '.' )
      {
        if ( e.KeyChar == '.' )
        {
          if ( !string.IsNullOrEmpty( textBox1.Text ) && textBox1.SelectionLength != textBox1.Text.Length )
            if ( IsValid( textBox1.Text ) )
              textBox2.Focus( );
            else
              textBox1.SelectAll( );
          e.Handled = true;
        }
        else if ( textBox1.SelectionLength != textBox1.Text.Length )
        {
          if ( textBox1.Text.Length == 2 )
            if ( e.KeyChar == Convert.ToChar( Keys.Back ) )
              textBox1.Text = textBox3.Text.Remove( textBox1.Text.Length - 1, 1 );
            else if ( !IsValid( textBox1.Text + e.KeyChar ) )
            {
              textBox1.SelectAll( );
              e.Handled = true;
            }
            else
              textBox2.Focus( );
        }
      }
      else
        e.Handled = true;
    }

    private void textBox2_KeyPress( object sender, KeyPressEventArgs e )
    {
      if ( Char.IsDigit( e.KeyChar ) || e.KeyChar == Convert.ToChar( Keys.Back ) || e.KeyChar == '.' )
      {
        if ( e.KeyChar == '.' )
        {
          if ( !string.IsNullOrEmpty( textBox2.Text ) && textBox2.SelectionLength != textBox2.Text.Length )
            if ( IsValid( textBox2.Text ) )
              textBox3.Focus( );
            else
              textBox2.SelectAll( );
          e.Handled = true;
        }
        else if ( textBox2.SelectionLength != textBox2.Text.Length )
        {
          if ( textBox2.Text.Length == 2 )
            if ( e.KeyChar == Convert.ToChar( Keys.Back ) )
              textBox2.Text = textBox3.Text.Remove( textBox2.Text.Length - 1, 1 );
            else if ( !IsValid( textBox2.Text + e.KeyChar ) )
            {
              textBox2.SelectAll( );
              e.Handled = true;
            }
            else
              textBox3.Focus( );
          else if ( textBox2.Text.Length == 0 && e.KeyChar == Convert.ToChar( Keys.Back ) )
          {
            textBox1.Focus( );
            textBox1.SelectionStart = textBox1.Text.Length;
          }
        }
      }
      else
        e.Handled = true;
    }

    private void textBox3_KeyPress( object sender, KeyPressEventArgs e )
    {
      if ( Char.IsDigit( e.KeyChar ) || e.KeyChar == Convert.ToChar( Keys.Back ) || e.KeyChar == '.' )
      {
        if ( e.KeyChar == '.' )
        {
          if ( !string.IsNullOrEmpty( textBox3.Text ) && textBox3.SelectionLength != textBox3.Text.Length )
            if ( IsValid( textBox3.Text ) )
              textBox4.Focus( );
            else
              textBox3.SelectAll( );
          e.Handled = true;
        }
        else if ( textBox3.SelectionLength != textBox3.Text.Length )
        {
          if ( textBox3.Text.Length == 2 )
            if ( e.KeyChar == Convert.ToChar( Keys.Back ) )
              textBox3.Text = textBox3.Text.Remove( textBox3.Text.Length - 1, 1 );
            else if ( !IsValid( textBox3.Text + e.KeyChar ) )
            {
              textBox3.SelectAll( );
              e.Handled = true;
            }
            else
              textBox4.Focus( );
          else if ( textBox3.Text.Length == 0 && e.KeyChar == Convert.ToChar( Keys.Back ) )
          {
            textBox2.Focus( );
            textBox2.SelectionStart = textBox2.Text.Length;
          }
        }
      }
      else
        e.Handled = true;
    }

    private void textBox4_KeyPress( object sender, KeyPressEventArgs e )
    {
      if ( Char.IsDigit( e.KeyChar ) || e.KeyChar == Convert.ToChar( Keys.Back ) )
      {
        if ( textBox4.SelectionLength != textBox4.Text.Length )
        {
          if ( textBox4.Text.Length == 2 )
            if ( e.KeyChar == Convert.ToChar( Keys.Back ) )
              textBox4.Text = textBox4.Text.Remove( textBox4.Text.Length - 1, 1 );
            else if ( !IsValid( textBox4.Text + e.KeyChar ) )
            {
              textBox4.SelectAll( );
              e.Handled = true;
            }
            else if ( textBox4.Text.Length == 0 && e.KeyChar == Convert.ToChar( Keys.Back ) )
            {
              textBox3.Focus( );
              textBox3.SelectionStart = textBox3.Text.Length;
            }
        }
      }
      else
        e.Handled = true;
    }

    private void textBox_Enter( object sender, EventArgs e )
    {
      ( sender as TextBox ).SelectAll( );
    }

    private void textBox_Leave( object sender, EventArgs e )
    {
      var control = sender as TextBox;
      if ( string.IsNullOrEmpty( control?.Text ) )
        control.Text = "0";
    }

    private bool IsValid( string value )
    {
      try
      {
        if ( Convert.ToInt32( value ) < 0 || Convert.ToInt32( value ) > 255 )
        {
          MessageBox.Show( Resources.ODY_IPADDR_VALID_ERROR, Resources.ODY_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
          return false;
        }
        else return true;
      }
      catch
      {
        return false;
      }
    }

    public bool IsValid( )
    {
      try
      {
        var ipAddr = this.Text.Split( '.' );
        if ( Convert.ToInt32( ipAddr[0] ) < 0 || Convert.ToInt32( ipAddr[0] ) > 255 )
          return false;
        if ( Convert.ToInt32( ipAddr[1] ) < 0 || Convert.ToInt32( ipAddr[1] ) > 255 )
          return false;
        if ( Convert.ToInt32( ipAddr[2] ) < 0 || Convert.ToInt32( ipAddr[2] ) > 255 )
          return false;
        if ( Convert.ToInt32( ipAddr[3] ) < 0 || Convert.ToInt32( ipAddr[3] ) > 255 )
          return false;

        return true;
      }
      catch
      {
        return false;
      }
    }

    public IPTextbox( )
    {
      InitializeComponent( );
    }
  }
}
