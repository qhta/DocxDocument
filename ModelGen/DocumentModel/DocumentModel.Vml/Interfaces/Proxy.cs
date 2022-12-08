namespace DocumentModel.Vml;

/// <summary>
/// Shape Reference.
/// </summary>
public interface Proxy
{
  /// <summary>
  /// Start Point Connection Flag
  /// </summary>
  public Boolean? Start { get ; set; }
  
  /// <summary>
  /// End Point Connection Flag
  /// </summary>
  public Boolean? End { get ; set; }
  
  /// <summary>
  /// Proxy Shape Reference
  /// </summary>
  public String? ShapeReference { get ; set; }
  
  /// <summary>
  /// Connection Location
  /// </summary>
  public Int32? ConnectionLocation { get ; set; }
  
}
