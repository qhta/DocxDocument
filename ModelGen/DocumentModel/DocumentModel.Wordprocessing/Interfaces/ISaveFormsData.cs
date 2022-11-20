namespace DocumentModel.Wordprocessing;

/// <summary>
/// Only Save Form Field Content.
/// </summary>
public interface ISaveFormsData // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
