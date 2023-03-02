namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Category.
/// </summary>
public record Category
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