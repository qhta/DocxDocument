namespace DocumentModel.Math;
/// <summary>
///   This element specifies an n-ary object, consisting of an n-ary object, a base (or operand) and optional upper and lower limits.
///   Examples of n-ary objects are: integral, sum, product.
/// </summary>
[OpenXmlType(typeof(DXM.Nary))]
[XmlRoot("Nary", Namespace = "DocumentModel.Math")]
public partial class Nary : ModelElement<DXM.Nary>, ICommonMathContent
{
 /// <summary>
 ///   n-ary Properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.Nary.NaryProperties))]
 public NaryProperties? NaryProperties { get => _NaryProperties; set => UpdateField(ref _NaryProperties, value, nameof(NaryProperties)); }
 private NaryProperties? _NaryProperties;

 /// <summary>
 ///   Lower limit (n-ary) .
 /// </summary>
 [OpenXmlProperty(nameof(DXM.Nary.SubArgument))]
 public SubArgument? SubArgument { get => _SubArgument; set => UpdateField(ref _SubArgument, value, nameof(SubArgument)); }
 private SubArgument? _SubArgument;

 /// <summary>
 ///   Upper limit (n-ary).
 /// </summary>
 [OpenXmlProperty(nameof(DXM.Nary.SuperArgument))]
 public SuperArgument? SuperArgument { get => _SuperArgument; set => UpdateField(ref _SuperArgument, value, nameof(SuperArgument)); }
 private SuperArgument? _SuperArgument;

 /// <summary>
 ///   Base argument.
 /// </summary>
 public Argument? Argument { get => _Argument; set => UpdateField(ref _Argument, value, nameof(Argument)); }
 private Argument? _Argument;
}