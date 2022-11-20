namespace DocumentModel.Wordprocessing;

/// <summary>
/// Emulate Word 97 Text Wrapping Around Floating Objects.
/// </summary>
public interface IShapeLayoutLikeWord8 // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
