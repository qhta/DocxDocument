namespace DocumentModel.Drawings;

/// <summary>
///   Represents a shape guide, defining a named formula used for shape geometry calculations.
/// </summary>
public class ShapeGuide: ModelElement<DXD.ShapeGuide>
{
  /// <summary>
  ///   Name of the shape guide.
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  ///   Formula used by the shape guide for geometry calculations.
  /// </summary>
  public string? Formula { get; set; }
}