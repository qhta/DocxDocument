namespace DocumentModel.Wordprocessing;

/// <summary>
/// Always Move Paragraph Mark to Page after a Page Break.
/// </summary>
public interface ISplitPageBreakAndParagraphMark // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
