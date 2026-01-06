namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a single data point in a chart series with customizable visual formatting.
/// </summary>
/// <remarks>
///   This interface defines an individual data point within a chart series
///   that can have its own unique visual styling separate from the series' default formatting. Data points are the
///   fundamental building blocks of chart visualizations, representing individual values or observations in the data.
///   While most data points inherit formatting from their parent series, this interface enables selective customization
///   of specific points to emphasize outliers, highlight important values, or visually distinguish particular observations.
///   Each data point is identified by its zero-based index within the series, corresponding to its position in the
///   data sequence. The <see cref="ShapeProperties"/> allow override of the series' default visual styling with
///   custom fill, line, effects, and other formatting specific to this point. This is particularly valuable for
///   drawing attention to key data points such as maximum or minimum values, target thresholds, anomalies, or data
///   points that require special emphasis in presentations or reports. Common use cases include highlighting the
///   highest sales month in a different color, marking data points that exceed targets, distinguishing negative values,
///   or emphasizing trend changes. The data point customization works in conjunction with <see cref="DataLabel"/> and
///   <see cref="DataLabelHidden"/> to control both the visual appearance and labeling of individual points. Extension
///   support enables future enhancements to data point functionality without schema changes.
/// </remarks>
public interface DataPoint
{
  /// <summary>
  ///   Gets or sets the zero-based index identifying this data point's position within its series.
  /// </summary>
  /// <remarks>
   ///   The index identifies which data point in the series this formatting applies to, using zero-based positioning
  ///   where 0 represents the first data point, 1 the second, and so on. This index-based approach enables precise
  ///   targeting of specific data points for custom formatting, allowing selective emphasis or distinction of
  ///   particular values in the data sequence. The index corresponds directly to the position of the data value
  ///   in the series data array, ensuring consistent identification across different chart views and formats.
  /// </remarks>
  public UInt32? Idx { get; set; }

  /// <summary>
  ///   Gets or sets the visual styling properties for this data point.
  /// </summary>
  /// <remarks>
  ///   Shape properties control the visual appearance of this specific data point, overriding the default formatting
  ///   inherited from the parent series. This enables individual data points to be visually distinguished through
  ///   custom colors, patterns, borders, shadows, or other effects. Common formatting customizations include using
  ///   a different fill color to highlight maximum or minimum values, applying contrasting colors to emphasize outliers,
  ///   adding special effects to draw attention to significant points, or using distinct styling to indicate different
  ///   data states (such as actual vs. projected values, or positive vs. negative changes). When this property is
  ///   <c>null</c>, the data point inherits its visual styling from the series' default formatting, maintaining
  ///   consistency with other points. Setting custom shape properties breaks this inheritance for the specific point,
  ///   allowing it to stand out visually while other points maintain the series' standard appearance.
  /// </remarks>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   Gets or sets the collection of extension elements for future extensibility.
  /// </summary>
  /// <remarks>
  ///   Extension elements allow for future enhancements to data point functionality without breaking compatibility
  ///   with existing implementations. This could include additional formatting options, interactive behaviors,
  ///   data annotations, or custom properties introduced in future Office versions. The extension mechanism ensures
  ///   that documents with enhanced data point features remain functional in older applications while enabling
  ///   full feature support when opened in capable applications.
  /// </remarks>
  public ExtensionList? ExtensionList { get; set; }
}