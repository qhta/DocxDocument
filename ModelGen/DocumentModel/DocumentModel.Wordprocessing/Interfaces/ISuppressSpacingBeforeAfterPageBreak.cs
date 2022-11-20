namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Use Space Before On First Line After a Page Break.
/// </summary>
public interface ISuppressSpacingBeforeAfterPageBreak // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
