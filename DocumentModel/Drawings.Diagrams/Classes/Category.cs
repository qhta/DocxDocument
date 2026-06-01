namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   ICategory.
/// </summary>
public class ICategory: ModelElement
{
  /// <summary>
  ///   ICategory Type
  /// </summary>
  public string? Type { get; set; }

  /// <summary>
  ///   Priority
  /// </summary>
  public UInt32? Priority { get; set; }
}
