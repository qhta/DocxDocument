namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Absolute Anchor Shape Size.
/// </summary>
public interface IAbsoluteAnchor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Position.
  /// </summary>
  public IPosition? Position { get ; set; }
  
  /// <summary>
  /// Shape Extent.
  /// </summary>
  public IExtent? Extent { get ; set; }
  
}
