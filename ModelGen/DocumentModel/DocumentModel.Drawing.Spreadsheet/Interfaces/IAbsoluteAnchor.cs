namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Absolute Anchor Shape Size.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IPosition))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IExtent))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IClientData))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IConnectionShape))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IGraphicFrame))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IGroupShape))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IPicture))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IShape))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IContentPart))]
public interface IAbsoluteAnchor // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Position.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.IPosition? Position { get ; set; }
  
  /// <summary>
  /// Shape Extent.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.IExtent? Extent { get ; set; }
  
}
