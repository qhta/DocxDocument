namespace DocumentModel.Wordprocessing;

/// <summary>
/// Footnote Placement.
/// </summary>
public interface IFootnotePosition // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Footnote Position Type
  /// </summary>
  public FootnotePosition? Val { get ; set; }
  
}
