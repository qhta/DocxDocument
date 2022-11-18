namespace DocumentModel.Wordprocessing;

/// <summary>
/// Keep Source Formatting on Import.
/// </summary>
public interface IMatchSource // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
