namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// One Cell Anchor Shape Size.
/// </summary>
public interface IOneCellAnchor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// FromMarker.
  /// </summary>
  public IFromMarker? FromMarker { get ; set; }
  
  /// <summary>
  /// Extent.
  /// </summary>
  public IExtent? Extent { get ; set; }
  
}
