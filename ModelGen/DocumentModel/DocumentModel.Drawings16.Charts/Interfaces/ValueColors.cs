namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the ValueColors Class.
/// </summary>
public interface ValueColors
{
  /// <summary>
  /// MinColorSolidColorFillProperties.
  /// </summary>
  public DocumentModel.Drawings16.Charts.MinColorSolidColorFillProperties? MinColorSolidColorFillProperties { get ; set; }
  
  /// <summary>
  /// MidColorSolidColorFillProperties.
  /// </summary>
  public DocumentModel.Drawings16.Charts.MidColorSolidColorFillProperties? MidColorSolidColorFillProperties { get ; set; }
  
  /// <summary>
  /// MaxColorSolidColorFillProperties.
  /// </summary>
  public DocumentModel.Drawings16.Charts.MaxColorSolidColorFillProperties? MaxColorSolidColorFillProperties { get ; set; }
  
}
