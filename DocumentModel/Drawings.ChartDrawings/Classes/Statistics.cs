namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the Statistics Class.
/// </summary>
public record Statistics
{
  /// <summary>
  ///   quartileMethod, this property is only available in Office 2016 and later.
  /// </summary>
  public QuartileMethod? QuartileMethod { get; set; }
}