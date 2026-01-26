namespace DocumentModel.Math;
/// <summary>
///   This element specifies properties such as ctrlPr that can be stored on the Pre-Sub-Superscript objects Pre. 
/// </summary>
[OpenXmlType(typeof(DXM.PreSubSuper))]
public partial class PreSubSuper : ModelElement<DXM.PreSubSuper>, ICommonMathContent
{
 /// <summary>
 ///   Pre-Sub-Superscript Properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.PreSubSuper.PreSubSuperProperties))]
 /// <summary>
 ///   Pre-Sub-Superscript Properties.
 /// </summary>
 [OpenXmlElement(typeof(DXM.PreSubSuper))]
 public PreSubSuperProperties? PreSubSuperProperties { get => _PreSubSuperProperties; set => UpdateField(ref _PreSubSuperProperties, value, nameof(PreSubSuperProperties)); }

 private PreSubSuperProperties? _PreSubSuperProperties;
 /// <summary>
 ///   Subscript (Pre-Sub-Superscript).
 /// </summary>
 [OpenXmlProperty(nameof(DXM.PreSubSuper.SubArgument))]
 /// <summary>
 ///   Subscript (Pre-Sub-Superscript).
 /// </summary>
 [OpenXmlElement(typeof(DXM.PreSubSuper))]
 public SubArgument? SubArgument { get => _SubArgument; set => UpdateField(ref _SubArgument, value, nameof(SubArgument)); }

 private SubArgument? _SubArgument;
 /// <summary>
 ///   Superscript(Pre-Sub-Superscript function).
 /// </summary>
 [OpenXmlProperty(nameof(DXM.PreSubSuper.SuperArgument))]
 /// <summary>
 ///   Superscript(Pre-Sub-Superscript function).
 /// </summary>
 [OpenXmlElement(typeof(DXM.PreSubSuper))]
 public SuperArgument? SuperArgument { get => _SuperArgument; set => UpdateField(ref _SuperArgument, value, nameof(SuperArgument)); }

 private SuperArgument? _SuperArgument;
 /// <summary>
 ///   Base argument.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.PreSubSuper.Base))]
 /// <summary>
 ///   Base argument.
 /// </summary>
 [OpenXmlElement(typeof(DXM.PreSubSuper))]
 public Argument? Base { get => _Base; set => UpdateField(ref _Base, value, nameof(Base)); }

 private Argument? _Base;
}