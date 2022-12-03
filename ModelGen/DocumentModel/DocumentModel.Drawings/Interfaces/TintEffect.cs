namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TintEffect Class.
/// </summary>
public interface TintEffect // : System.Boolean
{
  /// <summary>
  /// Hue
  /// </summary>
  public Int32? Hue { get ; set; }
  
  /// <summary>
  /// Amount
  /// </summary>
  public Int32? Amount { get ; set; }
  
}
