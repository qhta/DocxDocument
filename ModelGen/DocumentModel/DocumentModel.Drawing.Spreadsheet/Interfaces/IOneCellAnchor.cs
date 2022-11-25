namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// One Cell Anchor Shape Size.
/// </summary>
public interface IOneCellAnchor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// FromMarker.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.IMarkerType? FromMarker { get ; set; }
  
  /// <summary>
  /// Extent.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.IExtent? Extent { get ; set; }
  
}
