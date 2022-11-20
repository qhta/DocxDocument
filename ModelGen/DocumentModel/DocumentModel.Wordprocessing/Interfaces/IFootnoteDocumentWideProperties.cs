namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document-Wide Footnote Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.INumberingStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFootnoteSpecialReference))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFootnotePosition))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.INumberingFormat))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.INumberingRestart))]
public interface IFootnoteDocumentWideProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Footnote Placement.
  /// </summary>
  public IFootnotePosition? FootnotePosition { get ; set; }
  
  /// <summary>
  /// Footnote Numbering Format.
  /// </summary>
  public DocumentModel.Wordprocessing.INumberingFormat? NumberingFormat { get ; set; }
  
  /// <summary>
  /// Footnote and Endnote Numbering Starting Value.
  /// </summary>
  public INumberingStart? NumberingStart { get ; set; }
  
  /// <summary>
  /// Footnote and Endnote Numbering Restart Location.
  /// </summary>
  public INumberingRestart? NumberingRestart { get ; set; }
  
}
