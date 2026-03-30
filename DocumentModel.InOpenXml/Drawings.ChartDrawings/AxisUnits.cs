using DocumentModel.Drawings.Charts;

namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents the unit display information for a chart axis.
/// </summary>
/// <remarks>
///   This class defines the unit specification and labeling
///   for a chart axis, providing context for the scale and magnitude of values displayed. Axis units help
///   users interpret large or small numbers by indicating multipliers (such as "Millions", "Thousands",
///   "Billions") or measurement units (such as "Ä‚â€žÄąÄ…Ă„Ä…Ă„ËťÄ‚â€ąÄąÄ„C", "%", "USD"). The unit information includes both
///   the unit type/value and an optional label that can be customized for display. This aids in chart
///   readability by keeping axis labels concise while still conveying the actual magnitude or measurement
///   type of the data.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.AxisUnits))]
public class AxisUnits: ModelElement<DXO16DCD.AxisUnits>
{
  /// <summary>
  /// Specifies the unit.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.AxisUnits.Unit))]
  public AxisUnit? Unit { get => _Unit; set => UpdateField(ref _Unit, value, nameof(Unit)); }
  private AxisUnit? _Unit;
  /// <summary>
  /// Specifies the axis units label.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.AxisUnits.AxisUnitsLabel))]
  public AxisUnitsLabel? AxisUnitsLabel
  {
    get => _AxisUnitsLabel;
    set => UpdateField(ref _AxisUnitsLabel, value, nameof(AxisUnitsLabel));
  }
  private AxisUnitsLabel? _AxisUnitsLabel;
  /// <summary>
  /// Specifies the extension list.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.AxisUnits.ExtensionList))]
  public ExtensionList? ExtensionList
  {
    get => _ExtensionList;
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }
  private ExtensionList? _ExtensionList;
}