namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents the unit display information for a chart axis.
/// </summary>
/// <remarks>
///   This interface defines the unit specification and labeling
///   for a chart axis, providing context for the scale and magnitude of values displayed. Axis units help
///   users interpret large or small numbers by indicating multipliers (such as "Millions", "Thousands",
///   "Billions") or measurement units (such as "°C", "%", "USD"). The unit information includes both
///   the unit type/value and an optional label that can be customized for display. This aids in chart
///   readability by keeping axis labels concise while still conveying the actual magnitude or measurement
///   type of the data.
/// </remarks>
public interface AxisUnits
{
  /// <summary>
  ///   Gets or sets the unit type applied to the axis values.
  /// </summary>
  /// <remarks>
   ///   The unit determines how axis values are scaled or interpreted, such as displaying values
  ///   in thousands, millions, billions, or with specific measurement units. This allows the axis
  ///   to show "1.5" with a unit of "Millions" instead of displaying "1,500,000" on the axis.
  /// </remarks>
  public AxisUnit? Unit { get; set; }

  /// <summary>
  ///   Gets or sets the custom label displayed for the axis units.
  /// </summary>
  /// <remarks>
  ///   The axis units label provides a textual representation of the units that can be customized
  ///   in terms of content, positioning, and formatting. This label typically appears near the axis
  ///   to clarify the scale or measurement type (e.g., "in millions", "°F", "percentage").
  /// </remarks>
  public AxisUnitsLabel? AxisUnitsLabel { get; set; }

  /// <summary>
  ///   Gets or sets the collection of extension elements for future extensibility.
  /// </summary>
  /// <remarks>
  ///   Extension elements allow for future enhancements and custom properties without breaking
  ///   compatibility with existing implementations.
  /// </remarks>
  public ExtensionList? ExtensionList { get; set; }
}