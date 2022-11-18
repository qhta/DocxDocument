namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Two Cell Anchor Shape Size.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IClientData))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IConnectionShape))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IGraphicFrame))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IGroupShape))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IFromMarker))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IToMarker))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IPicture))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IShape))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IContentPart))]
public interface ITwoCellAnchor // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Positioning and Resizing Behaviors
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.EditAs? EditAs { get ; set; }
  
  /// <summary>
  /// Starting Anchor Point.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.IFromMarker? FromMarker { get ; set; }
  
  /// <summary>
  /// Ending Anchor Point.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.IToMarker? ToMarker { get ; set; }
  
}
