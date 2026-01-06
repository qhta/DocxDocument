namespace DocumentModel.Drawings;

/// <summary>
///   Shape Guide.
/// </summary>
public interface ShapeGuide
{
  /// <summary>
  ///   Shape Guide Name
  /// </summary>
  public string? Name { get; set; }
  /// <summary>
  ///   Shape Guide Formula
  /// </summary>
  public string? Formula { get; set; }
}