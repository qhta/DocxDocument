namespace DocumentModel.Math;
/// <summary>
///   This element specifies the box object, which is used to group components of an equation or other instance of mathematical text. 
///   A boxed object can (for example) serve as an operator emulator with or without an alignment point, 
///   serve as a line break point, have associated argSz, or be grouped such as not to allow line breaks within. 
///   If boxPr is omitted, all properties will be “false” by default.
/// </summary>
[OpenXmlType(typeof(DXM.Box))]
public partial class Box : ModelElement<DXM.Box>, ICommonMathContent
{
 /// <summary>
 ///   Specifies properties of box object.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.Box.BoxProperties))]
 /// <summary>
 ///   Specifies properties of box object.
 /// </summary>
 [OpenXmlElement(typeof(DXM.Box))]
 public BoxProperties? BoxProperties { get => _BoxProperties; set => UpdateField(ref _BoxProperties, value, nameof(BoxProperties)); }

 private BoxProperties? _BoxProperties;
 /// <summary>
 ///   Specifies argument of box object.
 /// </summary>
 [OpenXmlElement(typeof(DXM.Box))]
 public Argument? Argument { get => _Argument; set => UpdateField(ref _Argument, value, nameof(Argument)); }

 private Argument? _Argument;
}