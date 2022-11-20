namespace DocumentModel.Wordprocessing;

/// <summary>
/// Use Fixed Paragraph Spacing for HTML Auto Setting.
/// </summary>
public interface IDoNotUseHTMLParagraphAutoSpacing // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
