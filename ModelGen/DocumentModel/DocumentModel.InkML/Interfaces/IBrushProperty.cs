namespace DocumentModel.InkML;

/// <summary>
/// Defines the BrushProperty Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.InkML.IAnnotation))]
[ChildElementInfo(typeof(DocumentModel.InkML.IAnnotationXml))]
public interface IBrushProperty // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// name
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// value
  /// </summary>
  public string? Value { get ; set; }
  
  /// <summary>
  /// units
  /// </summary>
  public string? Units { get ; set; }
  
}
