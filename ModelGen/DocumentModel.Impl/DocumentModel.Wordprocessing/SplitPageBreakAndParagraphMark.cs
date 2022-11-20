namespace DocumentModel.Wordprocessing;

/// <summary>
/// Always Move Paragraph Mark to Page after a Page Break.
/// </summary>
public class SplitPageBreakAndParagraphMark: ISplitPageBreakAndParagraphMark
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
