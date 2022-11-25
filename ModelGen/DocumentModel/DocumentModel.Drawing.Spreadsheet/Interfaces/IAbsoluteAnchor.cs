namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Absolute Anchor Shape Size.
/// </summary>
public interface IAbsoluteAnchor // : DocumentModel.ITypedOpenXmlCompositeElement
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
