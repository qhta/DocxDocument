namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TintEffect Class.
/// </summary>
public partial interface TintEffect
{
  /// <summary>
  /// Hue
  /// </summary>
  public Int32? Hue { get; set; }
  
  /// <summary>
  /// Amount
  /// </summary>
  public Int32? Amount { get; set; }
  
}
