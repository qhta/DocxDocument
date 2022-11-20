namespace DocumentModel.InkML;

/// <summary>
/// Defines the AnnotationXml Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.EMMA.IEmma))]
public interface IAnnotationXml // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// type
  /// </summary>
  public string? Type { get ; set; }
  
  /// <summary>
  /// encoding
  /// </summary>
  public string? Encoding { get ; set; }
  
  /// <summary>
  /// href
  /// </summary>
  public string? Href { get ; set; }
  
  /// <summary>
  /// Emma.
  /// </summary>
  public IEmma? Emma { get ; set; }
  
}
