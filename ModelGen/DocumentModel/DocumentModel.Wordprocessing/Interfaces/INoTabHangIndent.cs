namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Create Custom Tab Stop for Hanging Indent.
/// </summary>
public interface INoTabHangIndent // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
