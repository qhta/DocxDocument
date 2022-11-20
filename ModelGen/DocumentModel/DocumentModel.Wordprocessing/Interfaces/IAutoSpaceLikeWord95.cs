namespace DocumentModel.Wordprocessing;

/// <summary>
/// Emulate Word 95 Full-Width Character Spacing.
/// </summary>
public interface IAutoSpaceLikeWord95 // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
