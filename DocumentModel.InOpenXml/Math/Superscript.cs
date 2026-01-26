namespace DocumentModel.Math;
/// <summary>
///   Superscript Function.
/// </summary>
[OpenXmlType(typeof(DXM.Superscript))]
public partial class Superscript : ModelElement<DXM.Superscript>, ICommonMathContent
{
 /// <summary>
 ///   Superscript Properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.Superscript.SuperscriptProperties))]
 /// <summary>
 ///   Superscript Properties.
 /// </summary>
 [OpenXmlElement(typeof(DXM.Superscript))]
 public SuperscriptProperties? SuperscriptProperties { get => _SuperscriptProperties; set => UpdateField(ref _SuperscriptProperties, value, nameof(SuperscriptProperties)); }

 private SuperscriptProperties? _SuperscriptProperties;
 /// <summary>
 ///   Superscript base argument
 /// </summary>
 [OpenXmlElement(typeof(DXM.Superscript))]
 public Argument? Argument { get => _Argument; set => UpdateField(ref _Argument, value, nameof(Argument)); }

 private Argument? _Argument;
 /// <summary>
 ///   Superscript (Superscript function).
 /// </summary>
 [OpenXmlProperty(nameof(DXM.Superscript.SuperArgument))]
 /// <summary>
 ///   Superscript (Superscript function).
 /// </summary>
 [OpenXmlElement(typeof(DXM.Superscript))]
 public SuperArgument? SuperArgument { get => _SuperArgument; set => UpdateField(ref _SuperArgument, value, nameof(SuperArgument)); }

 private SuperArgument? _SuperArgument;
}