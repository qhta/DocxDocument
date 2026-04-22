namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents a single format override that applies custom formatting to a specific chart element.
/// </summary>
/// <remarks>
///   This class defines an individual format override that targets
///   a specific chart element identified by its index, applying custom visual styling that takes precedence over
///   default or inherited formatting rules. Format overrides enable selective customization of chart elements such
///   as individual data points, series elements, axis components, or other chart objects without affecting the base
///   formatting definitions that apply to most elements. Each override is associated with a specific element through
///   its zero-based index (<see cref = "Idx"/>), and defines custom shape properties (<see cref = "ShapeProperties"/>)
///   that supersede the element's default styling. This mechanism is particularly valuable for emphasizing specific
///   chart elements, highlighting outliers or important values, distinguishing exceptional cases, or applying
///   conditional formatting based on data values or business rules. Common scenarios include coloring the highest
///   or lowest data point differently, marking data points that exceed thresholds, applying distinct styling to
///   negative values, or visually separating different data categories within the same series. The format override
///   is part of the <see cref = "FormatOverrides"/> collection referenced by <see cref = "ChartSpace"/>, providing
///   centralized management of exceptional formatting cases. This architecture separates base formatting (which
///   maintains consistency across most chart elements) from targeted overrides (which handle special cases),
///   promoting maintainable and flexible chart styling where most elements follow standard rules while specific
///   elements receive custom treatment. Extension support enables future enhancements to format override capabilities.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.FormatOverride))]
[XmlRoot("FormatOverride", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class FormatOverride : ModelElement<DXO16DCD.FormatOverride>
{
 /// <summary>
 /// Specifies the idx.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.FormatOverride.Idx))]
 public UInt32? Idx { get => _Idx; set => UpdateField(ref _Idx, value, nameof(Idx)); }
 private UInt32? _Idx;

 /// <summary>
 /// Specifies the shape properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.FormatOverride.ShapeProperties))]
 public ShapeProperties? ShapeProperties { get => _ShapeProperties; set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties)); }
 private ShapeProperties? _ShapeProperties;

 /// <summary>
 /// Specifies the extension list.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.FormatOverride.ExtensionList))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private ExtensionList? _ExtensionList;
}