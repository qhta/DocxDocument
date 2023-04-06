namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a hyphen in a text run. 
///   There are two complementary ways to specific a character code of the hyphen: with enum typed HyphenKind or with a text string.
/// </summary>
public class Hyphen : ModelElement, IRunContent
{
  /// <summary>
  /// Encoded char value of the hyphen.
  /// </summary>
  public HyphenKind? Value
  {
    get => _Value;
    set
    {
      _Value = value;
      if (value != null)
      {
        var charValue = new string((char)value, 1);
        if (Text != charValue)
          Text = charValue;
      }
    }
  }
  private HyphenKind? _Value;

  /// <summary>
  /// Visual text value.
  /// </summary>
  public string Text
  {
    get => _Text;
    set
    {
      if (value != _Text)
      {
        _Text = value;
        if (value.Length == 1)
          Value = (HyphenKind)value[0];
        else
          Value = null;
      }
    }
  }
  private string _Text = "-";
}