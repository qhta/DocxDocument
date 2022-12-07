namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ValueColors Class.
/// </summary>
public interface ValueColors
{
  /// <summary>
  /// MinColorSolidColorFillProperties.
  /// </summary>
  public MinColorSolidColorFillProperties? MinColorSolidColorFillProperties { get ; set; }
  
  /// <summary>
  /// MidColorSolidColorFillProperties.
  /// </summary>
  public MidColorSolidColorFillProperties? MidColorSolidColorFillProperties { get ; set; }
  
  /// <summary>
  /// MaxColorSolidColorFillProperties.
  /// </summary>
  public MaxColorSolidColorFillProperties? MaxColorSolidColorFillProperties { get ; set; }
  
}
