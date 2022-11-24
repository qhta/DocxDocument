namespace DocumentModel.Vml.Office;

/// <summary>
/// Shape Reference.
/// </summary>
public interface IProxy // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Start Point Connection Flag
  /// </summary>
  public ITrueFalseBlankValue? Start { get ; set; }
  
  /// <summary>
  /// End Point Connection Flag
  /// </summary>
  public ITrueFalseBlankValue? End { get ; set; }
  
  /// <summary>
  /// Proxy Shape Reference
  /// </summary>
  public String? ShapeReference { get ; set; }
  
  /// <summary>
  /// Connection Location
  /// </summary>
  public Int32? ConnectionLocation { get ; set; }
  
}
