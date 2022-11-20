namespace DocumentModel.Wordprocessing;

/// <summary>
/// Use Fixed Paragraph Spacing for HTML Auto Setting.
/// </summary>
public class DoNotUseHTMLParagraphAutoSpacing: IDoNotUseHTMLParagraphAutoSpacing
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val
  {
    get;
    set;
  }
  
}
