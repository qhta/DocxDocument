namespace DocumentModel.Math;
/// <summary>
///   Subscript Function.
/// </summary>
[OpenXmlType(typeof(DXM.Subscript))]
public partial class Subscript : ModelElement<DXM.Subscript>, ICommonMathContent
{
 /// <summary>
 ///   Subscript Properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.Subscript.SubscriptProperties))]
 /// <summary>
 ///   Subscript Properties.
 /// </summary>
 [OpenXmlElement(typeof(DXM.Subscript))]
 public SubscriptProperties? SubscriptProperties { get => _SubscriptProperties; set => UpdateField(ref _SubscriptProperties, value, nameof(SubscriptProperties)); }

 private SubscriptProperties? _SubscriptProperties;
 /// <summary>
 ///   Subscript base argument.
 /// </summary>
 [OpenXmlElement(typeof(DXM.Subscript))]
 public Argument? Argument { get => _Argument; set => UpdateField(ref _Argument, value, nameof(Argument)); }

 private Argument? _Argument;
 /// <summary>
 ///   Subscript (Subscript function).
 /// </summary>
 [OpenXmlProperty(nameof(DXM.Subscript.SubArgument))]
 /// <summary>
 ///   Subscript (Subscript function).
 /// </summary>
 [OpenXmlElement(typeof(DXM.Subscript))]
 public SubArgument? SubArgument { get => _SubArgument; set => UpdateField(ref _SubArgument, value, nameof(SubArgument)); }

 private SubArgument? _SubArgument;
}