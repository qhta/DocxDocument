namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Color Transform Category.
/// </summary>
public class ColorTransformCategory: ModelElement
{
  /// <summary>
  ///   Category Type
  /// </summary>
  public string? Type { get; set; }
  /// <summary>
  ///   Priority
  /// </summary>
  public UInt32? Priority { get; set; }
}