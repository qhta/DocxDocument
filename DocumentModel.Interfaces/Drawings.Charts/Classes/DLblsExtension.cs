namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the DLblsExtension Class.
/// </summary>
public class DLblsExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public ChartText3? ChartText { get; set; }
  public DataLabelFieldTable? DataLabelFieldTable { get; set; }
  public bool? ShowDataLabelsRange { get; set; }
  public ShapeProperties3? ShapeProperties { get; set; }
  public Layout3? Layout { get; set; }
  public bool? ShowLeaderLines { get; set; }
  public LeaderLines3? LeaderLines { get; set; }
}