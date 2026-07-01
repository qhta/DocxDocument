namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Defines the ColorsType Class.
/// </summary>
[OpenXmlType(typeof(DXDD.ColorsType))]
[XmlRoot("Color", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class ColorType : Drawings.ColorType
{
 /// <summary>
 ///   Color Application Method Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorsType.Method))]
 public ColorApplicationMethod? Method { get => _Method; set => UpdateField(ref _Method, value, nameof(Method)); }
 private ColorApplicationMethod? _Method;

 /// <summary>
 ///   Hue Direction
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorsType.HueDirection))]
 public HueDirection? HueDirection { get => _HueDirection; set => UpdateField(ref _HueDirection, value, nameof(HueDirection)); }
 private HueDirection? _HueDirection;
}
