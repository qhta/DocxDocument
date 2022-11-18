namespace DocumentModel.Wordprocessing;

/// <summary>
/// Emulate Word 5.x for the Macintosh Small Caps Formatting.
/// </summary>
public interface IMacWordSmallCaps // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
