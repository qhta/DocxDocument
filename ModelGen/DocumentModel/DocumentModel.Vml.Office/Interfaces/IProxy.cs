namespace DocumentModel.Vml.Office;

/// <summary>
/// Shape Reference.
/// </summary>
public interface IProxy // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Start Point Connection Flag
  /// </summary>
  public System.Boolean? Start { get ; set; }
  
  /// <summary>
  /// End Point Connection Flag
  /// </summary>
  public System.Boolean? End { get ; set; }
  
  /// <summary>
  /// Proxy Shape Reference
  /// </summary>
  public System.String? ShapeReference { get ; set; }
  
  /// <summary>
  /// Connection Location
  /// </summary>
  public System.Int32? ConnectionLocation { get ; set; }
  
}
