namespace DocumentModel.Drawings;

/// <summary>
/// Shape Path.
/// </summary>
public interface Path
{
  /// <summary>
  /// Path Fill
  /// </summary>
  public PathFillMode? Fill { get ; set; }
  
}
