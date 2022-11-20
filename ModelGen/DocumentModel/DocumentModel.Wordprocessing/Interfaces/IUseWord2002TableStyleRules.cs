namespace DocumentModel.Wordprocessing;

/// <summary>
/// Emulate Word 2002 Table Style Rules.
/// </summary>
public interface IUseWord2002TableStyleRules // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
