namespace DocumentModel.Wordprocessing;

/// <summary>
/// Emulate Word 97 East Asian Line Breaking.
/// </summary>
public interface IUseWord97LineBreakRules // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
