namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an extension for a single data label.
///   This extension allows custom properties for individual data labels.
/// </summary>
public interface DLblExtension: Extension
{
  /// <summary>
  ///   Data Label Field Table, defining custom fields for the data label.
  /// </summary>
  public DataLabelFieldTable? DataLabelFieldTable { get; set; }

  /// <summary>
  ///   Indicates whether there is an exception for saving.
  /// </summary>
  public bool? ExceptionForSave { get; set; }

  /// <summary>
  ///   Indicates whether the data labels range is shown.
  /// </summary>
  public bool? ShowDataLabelsRange { get; set; }

  /// <summary>
  ///   Shape properties for the data label.
  /// </summary>
  public ShapeProperties3? ShapeProperties { get; set; }

  /// <summary>
  ///   Layout configuration for the data label.
  /// </summary>
  public Layout3? Layout { get; set; }
}