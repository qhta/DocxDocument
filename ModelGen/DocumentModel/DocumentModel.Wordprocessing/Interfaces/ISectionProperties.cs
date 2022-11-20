namespace DocumentModel.Wordprocessing;

/// <summary>
/// Section Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IColumns))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Word.IFootnoteColumns))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDocGrid))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IEndnoteProperties))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFootnoteProperties))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IHeaderReference))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFooterReference))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ILineNumberType))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFormProtection))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.INoEndnote))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITitlePage))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBiDi))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IGutterOnRight))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPageBorders))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPageMargin))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPageNumberType))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPageSize))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPaperSource))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPrinterSettingsReference))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISectionPropertiesChange))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISectionType))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITextDirection))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IVerticalTextAlignmentOnPage))]
public interface ISectionProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Physical Section Mark Character Revision ID
  /// </summary>
  public IHexBinaryValue? RsidRPr { get ; set; }
  
  /// <summary>
  /// Section Deletion Revision ID
  /// </summary>
  public IHexBinaryValue? RsidDel { get ; set; }
  
  /// <summary>
  /// Section Addition Revision ID
  /// </summary>
  public IHexBinaryValue? RsidR { get ; set; }
  
  /// <summary>
  /// Section Properties Revision ID
  /// </summary>
  public IHexBinaryValue? RsidSect { get ; set; }
  
}
