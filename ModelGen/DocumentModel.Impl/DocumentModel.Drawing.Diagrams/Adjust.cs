namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Shape Adjust.
/// </summary>
public class Adjust: IAdjust
{
  /// <summary>
  /// Adjust Handle Index
  /// </summary>
  public uint? Index
  {
    get;
    set;
  }
  
  /// <summary>
  /// Value
  /// </summary>
  public double? Val
  {
    get;
    set;
  }
  
}
