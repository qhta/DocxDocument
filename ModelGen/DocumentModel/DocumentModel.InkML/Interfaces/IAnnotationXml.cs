namespace DocumentModel.InkML;

/// <summary>
/// Defines the AnnotationXml Class.
/// </summary>
public interface IAnnotationXml // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// type
  /// </summary>
  public String? Type { get ; set; }
  
  /// <summary>
  /// encoding
  /// </summary>
  public String? Encoding { get ; set; }
  
  /// <summary>
  /// href
  /// </summary>
  public String? Href { get ; set; }
  
  /// <summary>
  /// Emma.
  /// </summary>
  public IEmma? Emma { get ; set; }
  
}
