namespace DocumentModel.InkML;

/// <summary>
/// Defines the Annotation Class.
/// </summary>
public interface IAnnotation // : DocumentModel.ITypedOpenXmlLeafTextElement
{
  /// <summary>
  /// type
  /// </summary>
  public String? Type { get ; set; }
  
  /// <summary>
  /// encoding
  /// </summary>
  public String? Encoding { get ; set; }
  
}
