namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the DLblsExtension Class.
/// </summary>
public class DLblsExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public ChartText3? ChartText { get; set; }

  public DataLabelFieldTable? DataLabelFieldTable { get; set; }

  public Boolean? ShowDataLabelsRange { get; set; }

  public ShapeProperties3? ShapeProperties { get; set; }

  public Layout3? Layout { get; set; }

  public Boolean? ShowLeaderLines { get; set; }

  public LeaderLines3? LeaderLines { get; set; }
}