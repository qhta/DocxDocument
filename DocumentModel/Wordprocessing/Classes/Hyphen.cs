namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Represents a hyphen in a text run.
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
        if (value.Length==1)
          Value = (HyphenKind)value[0];
        else
          Value = null;
      }
    }
  }
  private string _Text = "-";
}