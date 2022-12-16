namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Shape Adjust.
/// </summary>
public interface Adjust
{
  /// <summary>
  /// Adjust Handle Index
  /// </summary>
  public UInt32? Index { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public Double? Val { get ; set; }
  
}
