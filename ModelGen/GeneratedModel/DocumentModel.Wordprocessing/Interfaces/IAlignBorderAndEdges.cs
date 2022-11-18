namespace DocumentModel.Wordprocessing;

/// <summary>
/// Align Paragraph and Table Borders with Page Border.
/// </summary>
public interface IAlignBorderAndEdges // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
