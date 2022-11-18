namespace DocumentModel.Wordprocessing;

/// <summary>
/// Emulate WordPerfect 6.x Font Height Calculation.
/// </summary>
public interface ITruncateFontHeightsLikeWordPerfect // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
