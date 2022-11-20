namespace DocumentModel.Drawing;

/// <summary>
/// Miter Line Join.
/// </summary>
public class Miter: IMiter
{
  /// <summary>
  /// Miter Join Limit
  /// </summary>
  public int? Limit
  {
    get;
    set;
  }
  
}
