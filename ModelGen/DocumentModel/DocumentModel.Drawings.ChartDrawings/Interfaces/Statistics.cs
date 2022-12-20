namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the Statistics Class.
/// </summary>
public partial interface Statistics
{
  /// <summary>
  /// quartileMethod, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.QuartileMethod? QuartileMethod { get; set; }
  
}
