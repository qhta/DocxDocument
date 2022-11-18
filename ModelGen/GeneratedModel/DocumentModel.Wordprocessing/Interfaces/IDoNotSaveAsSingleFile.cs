namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DoNotSaveAsSingleFile Class.
/// </summary>
public interface IDoNotSaveAsSingleFile // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
