namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Category.
/// </summary>
public interface StyleDisplayCategory
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