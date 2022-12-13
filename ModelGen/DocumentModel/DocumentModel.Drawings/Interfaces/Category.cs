namespace DocumentModel.Drawings;

/// <summary>
/// Category.
/// </summary>
public interface Category
{
  /// <summary>
  /// Category Type
  /// </summary>
  public String? Type { get ; set; }
  
  /// <summary>
  /// Priority
  /// </summary>
  public UInt32? Priority { get ; set; }
  
}
