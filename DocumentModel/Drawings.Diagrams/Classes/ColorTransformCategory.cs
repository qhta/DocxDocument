namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Color Transform Category.
/// </summary>
public class ColorTransformCategory: ModelElement
{
  /// <summary>
  ///   Category Type
  /// </summary>
  public String? Type { get; set; }

  /// <summary>
  ///   Priority
  /// </summary>
  public UInt32? Priority { get; set; }
}