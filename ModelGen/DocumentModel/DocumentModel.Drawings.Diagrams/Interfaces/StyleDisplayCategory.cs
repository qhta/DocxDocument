namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Category.
/// </summary>
public partial interface StyleDisplayCategory
{
  /// <summary>
  /// Category Type
  /// </summary>
  public String? Type { get; set; }
  
  /// <summary>
  /// Priority
  /// </summary>
  public UInt32? Priority { get; set; }
  
}
