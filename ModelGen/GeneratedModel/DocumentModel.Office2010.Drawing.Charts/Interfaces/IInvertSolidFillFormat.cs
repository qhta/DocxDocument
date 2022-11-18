namespace DocumentModel.Office2010.Drawing.Charts;

/// <summary>
/// Defines the InvertSolidFillFormat Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.Charts.IShapeProperties))]
public interface IInvertSolidFillFormat // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Office2010.Drawing.Charts.IShapeProperties? ShapeProperties { get ; set; }
  
}
