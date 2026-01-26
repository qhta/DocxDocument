namespace DocumentModel.Math;
/// <summary>
///   Upper Limit Properties.
/// </summary>
[OpenXmlType(typeof(DXM.LimitUpperProperties))]
public partial class LimitUpperProperties : ModelElement<DXM.LimitUpperProperties>
{
 /// <summary>
 ///   ControlProperties.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.LimitUpperProperties.ControlProperties))]
 /// <summary>
 ///   ControlProperties.
 /// </summary>
 [OpenXmlElement(typeof(DXM.LimitUpperProperties))]
 public ControlProperties? ControlProperties { get => _ControlProperties; set => UpdateField(ref _ControlProperties, value, nameof(ControlProperties)); }

 private ControlProperties? _ControlProperties;
}