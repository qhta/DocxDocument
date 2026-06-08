namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   IShape Reference.
/// </summary>
public class Proxy: ModelElement
{
  /// <summary>
  ///   Start IPoint Connection Flag
  /// </summary>
  public bool? Start { get; set; }

  /// <summary>
  ///   End IPoint Connection Flag
  /// </summary>
  public bool? End { get; set; }

  /// <summary>
  ///   Proxy IShape Reference
  /// </summary>
  public string? ShapeReference { get; set; }

  /// <summary>
  ///   Connection Location
  /// </summary>
  public Int32? ConnectionLocation { get; set; }
}
