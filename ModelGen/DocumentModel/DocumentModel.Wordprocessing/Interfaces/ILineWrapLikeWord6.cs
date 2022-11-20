namespace DocumentModel.Wordprocessing;

/// <summary>
/// Emulate Word 6.0 Line Wrapping for East Asian Text.
/// </summary>
public interface ILineWrapLikeWord6 // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
