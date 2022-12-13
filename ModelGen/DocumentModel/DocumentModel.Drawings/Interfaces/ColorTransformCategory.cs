namespace DocumentModel.Drawings;

/// <summary>
/// Color Transform Category.
/// </summary>
public interface ColorTransformCategory
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
