namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Category.
/// </summary>
public class Category: ModelElement
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