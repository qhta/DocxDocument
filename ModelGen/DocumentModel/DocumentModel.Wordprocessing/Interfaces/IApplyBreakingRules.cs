namespace DocumentModel.Wordprocessing;

/// <summary>
/// Use Legacy Ethiopic and Amharic Line Breaking Rules.
/// </summary>
public interface IApplyBreakingRules // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
