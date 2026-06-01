namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   IShape Guide.
/// </summary>
public class ShapeGuide: ModelElement
{
  /// <summary>
  ///   IShape Guide Name
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  ///   IShape Guide Formula
  /// </summary>
  public string? Formula { get; set; }
}
