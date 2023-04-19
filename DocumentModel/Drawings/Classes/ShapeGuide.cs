namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Shape Guide.
/// </summary>
public class ShapeGuide: ModelElement
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