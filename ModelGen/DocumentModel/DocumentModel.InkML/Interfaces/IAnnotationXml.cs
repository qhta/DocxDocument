namespace DocumentModel.InkML;

/// <summary>
/// Defines the AnnotationXml Class.
/// </summary>
public interface IAnnotationXml // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// type
  /// </summary>
  public System.String? Type { get ; set; }
  
  /// <summary>
  /// encoding
  /// </summary>
  public System.String? Encoding { get ; set; }
  
  /// <summary>
  /// href
  /// </summary>
  public System.String? Href { get ; set; }
  
  /// <summary>
  /// Emma.
  /// </summary>
  public DocumentModel.EMMA.IEmma? Emma { get ; set; }
  
}
