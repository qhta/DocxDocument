namespace DocumentModel.Math;
/// <summary>
///   Lower Limit Properties.
/// </summary>
[OpenXmlType(typeof(DXM.LimitLowerProperties))]
public partial class LimitLowerProperties : ModelElement<DXM.LimitLowerProperties>
{
 /// <summary>
 ///   ControlProperties.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.LimitLowerProperties.ControlProperties))]
 /// <summary>
 ///   ControlProperties.
 /// </summary>
 [OpenXmlElement(typeof(DXM.LimitLowerProperties))]
 public ControlProperties? ControlProperties { get => _ControlProperties; set => UpdateField(ref _ControlProperties, value, nameof(ControlProperties)); }

 private ControlProperties? _ControlProperties;
}