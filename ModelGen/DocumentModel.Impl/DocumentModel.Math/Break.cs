namespace DocumentModel.Math;

/// <summary>
/// Break.
/// </summary>
public class Break: IBreak
{
  /// <summary>
  /// Index of Operator to Align To
  /// </summary>
  public int? AlignAt
  {
    get;
    set;
  }
  
  /// <summary>
  /// Index of Operator to Align To
  /// </summary>
  public int? Val
  {
    get;
    set;
  }
  
}
