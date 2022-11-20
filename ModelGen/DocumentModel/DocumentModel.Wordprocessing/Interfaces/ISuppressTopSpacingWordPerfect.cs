namespace DocumentModel.Wordprocessing;

/// <summary>
/// Emulate WordPerfect 5.x Line Spacing.
/// </summary>
public interface ISuppressTopSpacingWordPerfect // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
