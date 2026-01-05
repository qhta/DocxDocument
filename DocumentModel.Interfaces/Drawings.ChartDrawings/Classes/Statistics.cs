namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the Statistics Class.
/// </summary>
public interface Statistics:
{
  /// <summary>
  ///   quartileMethod
  /// </summary>
  public QuartileMethod? QuartileMethod { get; set; }
}