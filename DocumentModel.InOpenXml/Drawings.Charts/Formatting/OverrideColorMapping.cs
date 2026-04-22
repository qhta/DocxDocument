namespace DocumentModel.Drawings;
/// <summary>
///   This element provides an override for the color mapping in a document. When defined, this color mapping is used in place of the already defined color mapping, or master color mapping.
///   This color mapping is defined in the same manner as the other mappings within this document.
/// </summary>
[OpenXmlType(typeof(DXD.OverrideColorMapping))]
[XmlRoot("OverrideColorMapping", Namespace = "DocumentModel.Drawings")]
public partial class OverrideColorMapping : ModelElement<DXD.OverrideColorMapping> //: ExtendableElement
{
 /// <summary>
 ///   Specifies the color to use for the background.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.OverrideColorMapping.Background1))]
 public SchemeColor? Background1 { get => _Background1; set => UpdateField(ref _Background1, value, nameof(Background1)); }
 private SchemeColor? _Background1;

 /// <summary>
 ///   Specifies the color to use for the text.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.OverrideColorMapping.Text1))]
 public SchemeColor? Text1 { get => _Text1; set => UpdateField(ref _Text1, value, nameof(Text1)); }
 private SchemeColor? _Text1;

 /// <summary>
 ///   Specifies the color to use for the background (secondary).
 /// </summary>
 [OpenXmlProperty(nameof(DXD.OverrideColorMapping.Background2))]
 public SchemeColor? Background2 { get => _Background2; set => UpdateField(ref _Background2, value, nameof(Background2)); }
 private SchemeColor? _Background2;

 /// <summary>
 ///   Specifies the color to use for the text (secondary).
 /// </summary>
 [OpenXmlProperty(nameof(DXD.OverrideColorMapping.Text2))]
 public SchemeColor? Text2 { get => _Text2; set => UpdateField(ref _Text2, value, nameof(Text2)); }
 private SchemeColor? _Text2;

 /// <summary>
 ///   Specifies the color to use for the accent 1.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.OverrideColorMapping.Accent1))]
 public SchemeColor? Accent1 { get => _Accent1; set => UpdateField(ref _Accent1, value, nameof(Accent1)); }
 private SchemeColor? _Accent1;

 /// <summary>
 ///   Specifies the color to use for the accent 2.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.OverrideColorMapping.Accent2))]
 public SchemeColor? Accent2 { get => _Accent2; set => UpdateField(ref _Accent2, value, nameof(Accent2)); }
 private SchemeColor? _Accent2;

 /// <summary>
 ///   Specifies the color to use for the accent 3.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.OverrideColorMapping.Accent3))]
 public SchemeColor? Accent3 { get => _Accent3; set => UpdateField(ref _Accent3, value, nameof(Accent3)); }
 private SchemeColor? _Accent3;

 /// <summary>
 ///   Specifies the color to use for the accent 4.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.OverrideColorMapping.Accent4))]
 public SchemeColor? Accent4 { get => _Accent4; set => UpdateField(ref _Accent4, value, nameof(Accent4)); }
 private SchemeColor? _Accent4;

 /// <summary>
 ///   Specifies the color to use for the accent 5.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.OverrideColorMapping.Accent5))]
 public SchemeColor? Accent5 { get => _Accent5; set => UpdateField(ref _Accent5, value, nameof(Accent5)); }
 private SchemeColor? _Accent5;

 /// <summary>
 ///   Specifies the color to use for the accent 6.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.OverrideColorMapping.Accent6))]
 public SchemeColor? Accent6 { get => _Accent6; set => UpdateField(ref _Accent6, value, nameof(Accent6)); }
 private SchemeColor? _Accent6;

 /// <summary>
 ///   Specifies the color to use for hyperlinks.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.OverrideColorMapping.Hyperlink))]
 public SchemeColor? Hyperlink { get => _Hyperlink; set => UpdateField(ref _Hyperlink, value, nameof(Hyperlink)); }
 private SchemeColor? _Hyperlink;

 /// <summary>
 ///   Specifies the color to use for followed hyperlinks.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.OverrideColorMapping.FollowedHyperlink))]
 public SchemeColor? FollowedHyperlink { get => _FollowedHyperlink; set => UpdateField(ref _FollowedHyperlink, value, nameof(FollowedHyperlink)); }
 private SchemeColor? _FollowedHyperlink;
}