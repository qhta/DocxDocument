namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Two Cell Anchor Shape Size.
/// </summary>
public interface ITwoCellAnchor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Positioning and Resizing Behaviors
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.EditAsKind? EditAs { get ; set; }
  
  /// <summary>
  /// Starting Anchor Point.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.IMarkerType? FromMarker { get ; set; }
  
  /// <summary>
  /// Ending Anchor Point.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.IMarkerType? ToMarker { get ; set; }
  
}
