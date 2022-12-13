namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the Statistics Class.
/// </summary>
public interface Statistics
{
  /// <summary>
  /// quartileMethod, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings16.Charts.QuartileMethod? QuartileMethod { get ; set; }
  
}
