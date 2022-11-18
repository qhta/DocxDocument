namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FormProtection Class.
/// </summary>
public interface IFormProtection // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
