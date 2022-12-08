namespace DocumentModel.Math;

/// <summary>
/// Break.
/// </summary>
public interface Break
{
  /// <summary>
  /// Index of Operator to Align To
  /// </summary>
  public Int32? AlignAt { get ; set; }
  
  /// <summary>
  /// Index of Operator to Align To
  /// </summary>
  public Int32? Val { get ; set; }
  
}
