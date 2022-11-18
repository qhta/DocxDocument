namespace DocumentModel.Wordprocessing;

/// <summary>
/// Allow Automatic Formatting to Override Formatting Protection Settings.
/// </summary>
public interface IAutoFormatOverride // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
