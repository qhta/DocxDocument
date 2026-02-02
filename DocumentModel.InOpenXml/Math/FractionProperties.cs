namespace DocumentModel.Math;
/// <summary>
///   Fraction Properties.
/// </summary>
[OpenXmlType(typeof(DXM.FractionProperties))]
public partial class FractionProperties : ModelElement<DXM.FractionProperties>
{
 /// <summary>
 ///   Fraction type.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.FractionProperties.FractionType))]
 public FractionType? FractionType { get => _FractionType; set => UpdateField(ref _FractionType, value, nameof(FractionType)); }

 private FractionType? _FractionType;
 /// <summary>
 ///   ControlProperties.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.FractionProperties.ControlProperties))]
 public ControlProperties? ControlProperties { get => _ControlProperties; set => UpdateField(ref _ControlProperties, value, nameof(ControlProperties)); }

 private ControlProperties? _ControlProperties;
}