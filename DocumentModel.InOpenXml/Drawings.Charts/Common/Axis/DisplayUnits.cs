namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Defines the DisplayUnits Class.
/// </summary>
[OpenXmlType(typeof(DXDC.DisplayUnits))]
[DataContract]
[XmlRoot("DisplayUnits", Namespace = "DocumentModel.Drawings.Charts")]
public partial class DisplayUnits : ModelElement<DXDC.DisplayUnits>
{
 /// <summary>
 /// Specifies a custom display unit value for the axis.
 /// </summary>
 public Double? CustomDisplayUnit { get => _CustomDisplayUnit; set => UpdateField(ref _CustomDisplayUnit, value, nameof(CustomDisplayUnit)); }
 private Double? _CustomDisplayUnit;

 /// <summary>
 /// Specifies a built-in display unit for the axis.
 /// </summary>
 public BuiltInUnit? BuiltInUnit { get => _BuiltInUnit; set => UpdateField(ref _BuiltInUnit, value, nameof(BuiltInUnit)); }
 private BuiltInUnit? _BuiltInUnit;

 /// <summary>
 /// Specifies the display units label configuration.
 /// </summary>
 public DisplayUnitsLabel? DisplayUnitsLabel { get => _DisplayUnitsLabel; set => UpdateField(ref _DisplayUnitsLabel, value, nameof(DisplayUnitsLabel)); }
 private DisplayUnitsLabel? _DisplayUnitsLabel;

 /// <summary>
 /// Specifies the extension list for additional display unit settings.
 /// </summary>
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private ExtensionList? _ExtensionList;
}