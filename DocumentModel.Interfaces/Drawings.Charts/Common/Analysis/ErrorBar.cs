namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the <b>ErrorBar</b> interface, representing the configuration and properties of error bars in a chart series.
///   Error bars are graphical representations of the variability of data and are used on graphs to indicate the error or uncertainty in a reported measurement.
///   This interface provides options for direction, type, value, and visual customization of error bars.
/// </summary>
public interface ErrorBar: CollectionItem
{
  /// <summary>
  ///   Direction of the error bar (e.g., X, Y, or both).
  /// </summary>
  public ErrorBarDirectionKind? ErrorDirection { get; set; }

  /// <summary>
  ///   Type of error bar, such as fixed value, percentage, or standard deviation.
  /// </summary>
  public ErrorBarKind? ErrorBarType { get; set; }

  /// <summary>
  ///   Value type for the error bar, such as custom, standard error, or standard deviation.
  /// </summary>
  public ErrorKind? ErrorBarValueType { get; set; }

  /// <summary>
  ///   Indicates whether the error bar is rendered without an end cap.
  /// </summary>
  public bool? NoEndCap { get; set; }

  /// <summary>
  ///   Positive error range for the error bar.
  /// </summary>
  public Plus? Plus { get; set; }

  /// <summary>
  ///   Negative error range for the error bar.
  /// </summary>
  public Minus? Minus { get; set; }

  /// <summary>
  ///   Fixed value for the error bar, if applicable.
  /// </summary>
  public Double? ErrorBarValue { get; set; }

  /// <summary>
  ///   Shape and visual properties for the error bar.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }

  /// <summary>
  ///   Collection of extension elements for additional error bar customization.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}