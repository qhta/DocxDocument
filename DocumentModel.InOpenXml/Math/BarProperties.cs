namespace DocumentModel.Math;
/// <summary>
///   This element specifies properties of the bar function. 
///   If this element is omitted, the bar assumes its default location of top (the mathematical overbar). 
/// </summary>
[OpenXmlType(typeof(DXM.BarProperties))]
[XmlRoot("BarProperties", Namespace = "DocumentModel.Math")]
public partial class BarProperties : ModelElement<DXM.BarProperties>
{
 /// <summary>
 ///   Specifies vertical position of the bar.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.BarProperties.Position))]
 public VerticalJustification? Position { get => _Position; set => UpdateField(ref _Position, value, nameof(Position)); }

 private VerticalJustification? _Position;
 /// <summary>
 ///   Specifies formatting of bar function argument.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.BarProperties.ControlProperties))]
 public ControlProperties? ControlProperties { get => _ControlProperties; set => UpdateField(ref _ControlProperties, value, nameof(ControlProperties)); }

 private ControlProperties? _ControlProperties;
}