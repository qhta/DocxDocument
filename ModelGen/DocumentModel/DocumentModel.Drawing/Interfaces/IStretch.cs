namespace DocumentModel.Drawing;

/// <summary>
/// Stretch.
/// </summary>
public interface IStretch // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Fill Rectangle.
  /// </summary>
  public DocumentModel.Drawing.IRelativeRectangleType? FillRectangle { get ; set; }
  
}
