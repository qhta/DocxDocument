namespace DocumentModel.Wordprocessing;

/// <summary>
/// Allow Table Rows to Wrap Inline Objects Independently.
/// </summary>
public interface ILayoutTableRowsApart // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
