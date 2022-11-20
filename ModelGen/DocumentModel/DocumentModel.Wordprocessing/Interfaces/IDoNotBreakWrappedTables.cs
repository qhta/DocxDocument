namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Allow Floating Tables To Break Across Pages.
/// </summary>
public interface IDoNotBreakWrappedTables // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
