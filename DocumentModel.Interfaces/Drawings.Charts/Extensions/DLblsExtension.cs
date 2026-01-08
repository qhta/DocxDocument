namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an extension for a collection of data labels.
///   This extension allows adding new properties or behaviors to data labels, such as advanced formatting or layout options.
/// </summary>
public interface DLblsExtension: Extension
{
  /// <summary>
  ///   Chart Text, specifying the text content for the data labels extension.
  /// </summary>
  public ChartText3? ChartText { get; set; }

  /// <summary>
  ///   Data Label Field Table, defining custom fields for the data labels.
  /// </summary>
  public DataLabelFieldTable? DataLabelFieldTable { get; set; }

  /// <summary>
  ///   Indicates whether the data labels range is shown.
  /// </summary>
  public bool? ShowDataLabelsRange { get; set; }

  /// <summary>
  ///   Shape properties for the data labels extension.
  /// </summary>
  public ShapeProperties3? ShapeProperties { get; set; }

  /// <summary>
  ///   Layout configuration for the data labels extension.
  /// </summary>
  public Layout3? Layout { get; set; }

  /// <summary>
  ///   Indicates whether leader lines are shown.
  /// </summary>
  public bool? ShowLeaderLines { get; set; }

  /// <summary>
  ///   Leader lines configuration for the data labels.
  /// </summary>
  public LeaderLines3? LeaderLines { get; set; }
}