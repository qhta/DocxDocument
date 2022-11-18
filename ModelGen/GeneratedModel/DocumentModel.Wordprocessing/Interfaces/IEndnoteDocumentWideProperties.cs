namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document-Wide Endnote Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IEndnotePosition))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.INumberingStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IEndnoteSpecialReference))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.INumberingFormat))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.INumberingRestart))]
public interface IEndnoteDocumentWideProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Endnote Placement.
  /// </summary>
  public IEndnotePosition? EndnotePosition { get ; set; }
  
  /// <summary>
  /// Endnote Numbering Format.
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
