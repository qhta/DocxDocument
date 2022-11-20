namespace DocumentModel.Vml.Office;

/// <summary>
/// Shape Reference.
/// </summary>
public interface IProxy // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
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
  public string? ShapeReference { get ; set; }
  
  /// <summary>
  /// Connection Location
  /// </summary>
  public int? ConnectionLocation { get ; set; }
  
}
