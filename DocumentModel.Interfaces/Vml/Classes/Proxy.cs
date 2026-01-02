namespace DocumentModel.Vml;

/// <summary>
///   Shape Reference.
/// </summary>
public class Proxy: ModelElement
{
  /// <summary>
  ///   Start Point Connection Flag
  /// </summary>
  public bool? Start { get; set; }
  /// <summary>
  ///   End Point Connection Flag
  /// </summary>
  public bool? End { get; set; }
  /// <summary>
  ///   Proxy Shape Reference
  /// </summary>
  public string? ShapeReference { get; set; }
  /// <summary>
  ///   Connection Location
  /// </summary>
  public Int32? ConnectionLocation { get; set; }
}