namespace DocumentModel.Drawing;

/// <summary>
/// Defines the InvertSolidFillFormat Class.
/// </summary>
public interface IInvertSolidFillFormat // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.IShapeProperties? ShapeProperties { get ; set; }
  
}
