namespace DocumentModel.Wordprocessing;

/// <summary>
/// Convert Backslash To Yen Sign When Entered.
/// </summary>
public interface IDoNotLeaveBackslashAlone // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
