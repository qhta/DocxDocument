namespace DocumentModel.Wordprocessing;

/// <summary>
/// Don't Break Table Rows Around Floating Tables.
/// </summary>
public interface IDoNotBreakConstrainedForcedTable // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
