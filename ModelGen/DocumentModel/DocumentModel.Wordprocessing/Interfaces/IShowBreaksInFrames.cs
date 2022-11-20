namespace DocumentModel.Wordprocessing;

/// <summary>
/// Display Page/Column Breaks Present in Frames.
/// </summary>
public interface IShowBreaksInFrames // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
