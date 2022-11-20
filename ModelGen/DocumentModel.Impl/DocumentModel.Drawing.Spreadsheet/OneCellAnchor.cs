namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// One Cell Anchor Shape Size.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IExtent))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IClientData))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IConnectionShape))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IGraphicFrame))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IGroupShape))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IFromMarker))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IPicture))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IShape))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IContentPart))]
public class OneCellAnchor: IOneCellAnchor
{
  /// <summary>
  /// FromMarker.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.IFromMarker? FromMarker
  {
    get;
    set;
  }
  
  /// <summary>
  /// Extent.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.IExtent? Extent
  {
    get;
    set;
  }
  
}
