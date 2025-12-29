namespace DocxEd.Helpers;
public class TextBoxWriter : TextWriter
{
  TextBox textBox = null!;

  public TextBoxWriter(TextBox output)
  {
    textBox = output;
  }

  public override void Write(char value)
  {
    base.Write(value);
    textBox.Dispatcher.BeginInvoke(new Action(() =>
    {
      textBox.AppendText(value.ToString());
    }));
  }

  public override Encoding Encoding
  {
   [DebuggerStepThrough] get { return System.Text.Encoding.UTF8; }
  }
}
