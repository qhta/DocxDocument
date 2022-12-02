namespace DocumentModel.Drawing;

/// <summary>
/// Defines the InvertSolidFillFormat Class.
/// </summary>
public interface IInvertSolidFillFormat // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public IShapeProperties? ShapeProperties { get ; set; }
  
}
