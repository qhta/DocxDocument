namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Show Visual Indicator For Form Fields.
/// </summary>
public interface IDoNotShadeFormData // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
