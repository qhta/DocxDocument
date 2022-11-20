namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TextBoxTightWrap Class.
/// </summary>
public class TextBoxTightWrap: ITextBoxTightWrap
{
  /// <summary>
  /// Lines to Tight Wrap to Paragraph Extents
  /// </summary>
  public TextBoxTightWrapValues? Val
  {
    get;
    set;
  }
  
}
