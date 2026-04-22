namespace DocumentModel.Math;
/// <summary>
///   This element specifies the bar function, consisting of a base argument and an overbar or underbar, as in ¯a and _𝑎.
/// </summary>
[OpenXmlType(typeof(DXM.Bar))]
[XmlRoot("Bar", Namespace = "DocumentModel.Math")]
public partial class Bar : ModelElement<DXM.Bar>, ICommonMathContent
{
 /// <summary>
 ///   Specifies formatting properties of bar function.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.Bar.BarProperties))]
 public BarProperties? BarProperties { get => _BarProperties; set => UpdateField(ref _BarProperties, value, nameof(BarProperties)); }
 private BarProperties? _BarProperties;

 /// <summary>
 ///   Specifies the argument of bar function.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.Bar.Base))]
 public Base? Base { get => _Base; set => UpdateField(ref _Base, value, nameof(Base)); }
 private Base? _Base;

}