namespace DocumentModel.Wordprocessing;

/// <summary>
/// Always Use Fixed Width for Hangul Characters.
/// </summary>
public interface IDisplayHangulFixedWidth // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
