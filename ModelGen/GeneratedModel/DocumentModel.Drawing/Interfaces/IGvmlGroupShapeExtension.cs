namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GvmlGroupShapeExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IIsCanvas))]
public interface IGvmlGroupShapeExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri { get ; set; }
  
}
