namespace DocumentModel.Math;
/// <summary>
///   This element specifies properties of the Phantom object, 
///   including whether the phantom is hidden or visible 
///   and the amount of space that is considered when laying out text and objects around phantoms.
/// </summary>
[OpenXmlType(typeof(DXM.PhantomProperties))]
[XmlRoot("PhantomProperties", Namespace = "DocumentModel.Math")]
public partial class PhantomProperties : ModelElement<DXM.PhantomProperties>
{
 /// <summary>
 ///   Specifies the show property of the phantom phant. When 0 or false, the phant base e is hidden. 
 ///   If this element is omitted, the base e is shown. 
 ///   Whether the element is absent or present without the val attribute, 
 ///   the default of the val attribute is 1 meaning that this property is applied.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.PhantomProperties.ShowPhantom))]
 public bool? ShowPhantom { get => _ShowPhantom; set => UpdateField(ref _ShowPhantom, value, nameof(ShowPhantom)); }

 private bool? _ShowPhantom;
 /// <summary>
 ///   This element specifies that the phantom has zero width. 
 ///   The width of the contents of the phantom is not considered during layout. 
 ///   When this property is omitted, the phantom does have width (zero width is not applied).
 ///   When the element is absent, the default value of the property is 0 meaning that this property is not applied.
 ///   When the element is present and the val attribute is absent, 
 ///   the default of the val attribute is 1 meaning that this property is applied.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.PhantomProperties.ZeroWidth))]
 public bool? ZeroWidth { get => _ZeroWidth; set => UpdateField(ref _ZeroWidth, value, nameof(ZeroWidth)); }

 private bool? _ZeroWidth;
 /// <summary>
 ///   This element specifies that the phantom has zero ascent. 
 ///   The ascent of the contents of the phantom is not considered during layout. 
 ///   When this property is omitted, the phantom does have ascent (zero ascent is not applied).
 ///   When the element is absent, the default value of the property is 0 meaning that this property is not applied.
 ///   When the element is present and the val attribute is absent, 
 ///   the default of the val attribute is 1 meaning that this property is applied.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.PhantomProperties.ZeroAscent))]
 public bool? ZeroAscent { get => _ZeroAscent; set => UpdateField(ref _ZeroAscent, value, nameof(ZeroAscent)); }

 private bool? _ZeroAscent;
 /// <summary>
 ///   This element specifies that the phantom has zero descent. 
 ///   The descent of the contents of the phantom is not considered during layout. 
 ///   When this property is omitted, the phantom does have descent (zero descent is not applied).
 ///   When the element is absent, the default value of the property is 0 meaning that this property is not applied.
 ///   When the element is present and the val attribute is absent, 
 ///   the default of the val attribute is 1 meaning that this property is applied.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.PhantomProperties.ZeroDescent))]
 public bool? ZeroDescent { get => _ZeroDescent; set => UpdateField(ref _ZeroDescent, value, nameof(ZeroDescent)); }

 private bool? _ZeroDescent;
 /// <summary>
 ///   This element specifies that the phantom is transparent for spacing. 
 ///   This means that if the contents of the phantom are belonging to a special spacing interface 
 ///   (such as binary operators, relational operators, differentials, etc.), 
 ///   the contents of that phantom are taken into consideration when laying out text. 
 ///   If transparency is turned off, then the contents of the phantom are ignored during layout. 
 ///   When this element is omitted, transparency is 0 or false. In other words, when the element is absent, 
 ///   the default value of the property is 0 meaning that this property is not applied.
 ///   When the element is present and the val attribute is absent, 
 ///   the default of the val attribute is 1 meaning that this property is applied.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.PhantomProperties.Transparent))]
 public bool? Transparent { get => _Transparent; set => UpdateField(ref _Transparent, value, nameof(Transparent)); }

 private bool? _Transparent;
 /// <summary>
 ///   Specifies formatting of phantom object argument.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.PhantomProperties.ControlProperties))]
 public ControlProperties? ControlProperties { get => _ControlProperties; set => UpdateField(ref _ControlProperties, value, nameof(ControlProperties)); }

 private ControlProperties? _ControlProperties;
}