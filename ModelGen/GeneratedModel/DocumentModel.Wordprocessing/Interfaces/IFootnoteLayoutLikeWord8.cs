namespace DocumentModel.Wordprocessing;

/// <summary>
/// Emulate Word 6.x/95/97 Footnote Placement.
/// </summary>
public interface IFootnoteLayoutLikeWord8 // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
