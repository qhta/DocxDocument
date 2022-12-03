namespace DocumentModel.Drawings;

/// <summary>
/// Miter Line Join.
/// </summary>
public interface Miter // : System.Boolean
{
  /// <summary>
  /// Miter Join Limit
  /// </summary>
  public Int32? Limit { get ; set; }
  
}
