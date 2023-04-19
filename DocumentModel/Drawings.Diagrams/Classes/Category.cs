namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Category.
/// </summary>
public class Category: ModelElement
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