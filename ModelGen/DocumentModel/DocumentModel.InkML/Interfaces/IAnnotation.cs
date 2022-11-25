namespace DocumentModel.InkML;

/// <summary>
/// Defines the Annotation Class.
/// </summary>
public interface IAnnotation // : DocumentModel.ITypedOpenXmlLeafTextElement
{
  /// <summary>
  /// type
  /// </summary>
  public System.String? Type { get ; set; }
  
  /// <summary>
  /// encoding
  /// </summary>
  public System.String? Encoding { get ; set; }
  
}
