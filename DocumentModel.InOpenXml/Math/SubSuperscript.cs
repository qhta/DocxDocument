namespace DocumentModel.Math;
/// <summary>
///   Sub-Superscript Function.
/// </summary>
[OpenXmlType(typeof(DXM.SubSuperscript))]
public partial class SubSuperscript : ModelElement<DXM.SubSuperscript>, ICommonMathContent
{
 /// <summary>
 ///   Sub-Superscript Properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.SubSuperscript.SubSuperscriptProperties))]
 [OpenXmlElement(typeof(DXM.SubSuperscript))]
 public SubSuperscriptProperties? SubSuperscriptProperties { get => _SubSuperscriptProperties; set => UpdateField(ref _SubSuperscriptProperties, value, nameof(SubSuperscriptProperties)); }

 private SubSuperscriptProperties? _SubSuperscriptProperties;
 /// <summary>
 ///   Base argument.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.SubSuperscript.Base))]
 [OpenXmlElement(typeof(DXM.SubSuperscript))]
 public Argument? Base { get => _Base; set => UpdateField(ref _Base, value, nameof(Base)); }

 private Argument? _Base;
 /// <summary>
 ///   Subscript (Sub-Superscript).
 /// </summary>
 [OpenXmlProperty(nameof(DXM.SubSuperscript.SubArgument))]
 [OpenXmlElement(typeof(DXM.SubSuperscript))]
 public SubArgument? SubArgument { get => _SubArgument; set => UpdateField(ref _SubArgument, value, nameof(SubArgument)); }

 private SubArgument? _SubArgument;
 /// <summary>
 ///   Superscript (Sub-Superscript function).
 /// </summary>
 [OpenXmlProperty(nameof(DXM.SubSuperscript.SuperArgument))]
 [OpenXmlElement(typeof(DXM.SubSuperscript))]
 public SuperArgument? SuperArgument { get => _SuperArgument; set => UpdateField(ref _SuperArgument, value, nameof(SuperArgument)); }

 private SuperArgument? _SuperArgument;
}