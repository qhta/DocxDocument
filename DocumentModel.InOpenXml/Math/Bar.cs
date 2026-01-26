namespace DocumentModel.Math;
/// <summary>
///   This element specifies the bar function, consisting of a base argument and an overbar or underbar, as in ¯a and _𝑎.
/// </summary>
[OpenXmlType(typeof(DXM.Bar))]
public partial class Bar : ModelElement<DXM.Bar>, ICommonMathContent
{
 /// <summary>
 ///   Specifies formatting properties of bar function.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.Bar.BarProperties))]
 [OpenXmlElement(typeof(DXM.Bar))]
 public BarProperties? BarProperties { get => _BarProperties; set => UpdateField(ref _BarProperties, value, nameof(BarProperties)); }

 private BarProperties? _BarProperties;
 /// <summary>
 ///   Specifies argument of bar function.
 /// </summary>
 [OpenXmlElement(typeof(DXM.Bar))]
 public Argument? Argument { get => _Argument; set => UpdateField(ref _Argument, value, nameof(Argument)); }

 private Argument? _Argument;
}