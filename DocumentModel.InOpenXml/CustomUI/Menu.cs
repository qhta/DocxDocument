namespace DocumentModel.CustomUI;
/// <summary>
/// <para>Defines the Menu Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:menu.</para>
/// </summary>
/// <remark>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular"/> <c>&lt;mso14:button&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox"/> <c>&lt;mso14:checkBox&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular"/> <c>&lt;mso14:control&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular"/> <c>&lt;mso14:dynamicMenu&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular"/> <c>&lt;mso14:gallery&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular"/> <c>&lt;mso14:menu&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparator"/> <c>&lt;mso14:menuSeparator&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular"/> <c>&lt;mso14:splitButton&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular"/> <c>&lt;mso14:toggleButton&gt;</c></description></item>
/// </list>
/// </remark>
[OpenXmlType(typeof(DXO10CUI.Menu))]
[XmlRoot("Menu", Namespace = "DocumentModel.CustomUI")]
public class Menu : ModelElement<DXO10CUI.Menu>
{
 /// <summary>
 /// Specifies the size mode of the control.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.Size))]
 public Size? Size { get => _Size; set => UpdateField(ref _Size, value, nameof(Size)); }

 private Size? _Size;
 /// <summary>
 /// Specifies the callback that returns size.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.GetSize))]
 public String? GetSize { get => _GetSize; set => UpdateField(ref _GetSize, value, nameof(GetSize)); }

 private String? _GetSize;
 /// <summary>
 /// Specifies the item size mode used by the control.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.ItemSize))]
 public ItemSize? ItemSize { get => _ItemSize; set => UpdateField(ref _ItemSize, value, nameof(ItemSize)); }

 private ItemSize? _ItemSize;
 /// <summary>
 /// Specifies descriptive text associated with the control.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.Description))]
 public String? Description { get => _Description; set => UpdateField(ref _Description, value, nameof(Description)); }

 private String? _Description;
 /// <summary>
 /// Specifies the callback that returns description.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.GetDescription))]
 public String? GetDescription { get => _GetDescription; set => UpdateField(ref _GetDescription, value, nameof(GetDescription)); }

 private String? _GetDescription;
 /// <summary>
 /// Specifies the unique identifier of the control.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.Id))]
 public String? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

 private String? _Id;
 /// <summary>
 /// Specifies the qualified identifier of the control.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.QualifiedId))]
 public String? QualifiedId { get => _QualifiedId; set => UpdateField(ref _QualifiedId, value, nameof(QualifiedId)); }

 private String? _QualifiedId;
 /// <summary>
 /// Specifies an application-defined tag for the control.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.Tag))]
 public String? Tag { get => _Tag; set => UpdateField(ref _Tag, value, nameof(Tag)); }

 private String? _Tag;
 /// <summary>
 /// Specifies the identifier of a built-in Office control.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.IdMso))]
 public String? IdMso { get => _IdMso; set => UpdateField(ref _IdMso, value, nameof(IdMso)); }

 private String? _IdMso;
 /// <summary>
 /// Specifies a custom image resource identifier.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.Image))]
 public String? Image { get => _Image; set => UpdateField(ref _Image, value, nameof(Image)); }

 private String? _Image;
 /// <summary>
 /// Specifies the built-in Office image identifier.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.ImageMso))]
 public String? ImageMso { get => _ImageMso; set => UpdateField(ref _ImageMso, value, nameof(ImageMso)); }

 private String? _ImageMso;
 /// <summary>
 /// Specifies the callback that returns image.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.GetImage))]
 public String? GetImage { get => _GetImage; set => UpdateField(ref _GetImage, value, nameof(GetImage)); }

 private String? _GetImage;
 /// <summary>
 /// Specifies the short screen tip text.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.Screentip))]
 public String? Screentip { get => _Screentip; set => UpdateField(ref _Screentip, value, nameof(Screentip)); }

 private String? _Screentip;
 /// <summary>
 /// Specifies the callback that returns screentip.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.GetScreentip))]
 public String? GetScreentip { get => _GetScreentip; set => UpdateField(ref _GetScreentip, value, nameof(GetScreentip)); }

 private String? _GetScreentip;
 /// <summary>
 /// Specifies the extended super tip text.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.Supertip))]
 public String? Supertip { get => _Supertip; set => UpdateField(ref _Supertip, value, nameof(Supertip)); }

 private String? _Supertip;
 /// <summary>
 /// Specifies the callback that returns supertip.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.GetSupertip))]
 public String? GetSupertip { get => _GetSupertip; set => UpdateField(ref _GetSupertip, value, nameof(GetSupertip)); }

 private String? _GetSupertip;
 /// <summary>
 /// Specifies whether the control is enabled.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.Enabled))]
 public Boolean? Enabled { get => _Enabled; set => UpdateField(ref _Enabled, value, nameof(Enabled)); }

 private Boolean? _Enabled;
 /// <summary>
 /// Specifies the callback that returns enabled.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.GetEnabled))]
 public String? GetEnabled { get => _GetEnabled; set => UpdateField(ref _GetEnabled, value, nameof(GetEnabled)); }

 private String? _GetEnabled;
 /// <summary>
 /// Specifies the display label of the control.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.Label))]
 public String? Label { get => _Label; set => UpdateField(ref _Label, value, nameof(Label)); }

 private String? _Label;
 /// <summary>
 /// Specifies the callback that returns label.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.GetLabel))]
 public String? GetLabel { get => _GetLabel; set => UpdateField(ref _GetLabel, value, nameof(GetLabel)); }

 private String? _GetLabel;
 /// <summary>
 /// Specifies a built-in control after which this control is inserted.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.InsertAfterMso))]
 public String? InsertAfterMso { get => _InsertAfterMso; set => UpdateField(ref _InsertAfterMso, value, nameof(InsertAfterMso)); }

 private String? _InsertAfterMso;
 /// <summary>
 /// Specifies a built-in control before which this control is inserted.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.InsertBeforeMso))]
 public String? InsertBeforeMso { get => _InsertBeforeMso; set => UpdateField(ref _InsertBeforeMso, value, nameof(InsertBeforeMso)); }

 private String? _InsertBeforeMso;
 /// <summary>
 /// Specifies a qualified control identifier after which this control is inserted.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.InsertAfterQulifiedId))]
 public String? InsertAfterQualifiedId { get => _InsertAfterQualifiedId; set => UpdateField(ref _InsertAfterQualifiedId, value, nameof(InsertAfterQualifiedId)); }

 private String? _InsertAfterQualifiedId;
 /// <summary>
 /// Specifies a qualified control identifier before which this control is inserted.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.InsertBeforeQulifiedId))]
 public String? InsertBeforeQualifiedId { get => _InsertBeforeQualifiedId; set => UpdateField(ref _InsertBeforeQualifiedId, value, nameof(InsertBeforeQualifiedId)); }

 private String? _InsertBeforeQualifiedId;
 /// <summary>
 /// Specifies whether the control is visible.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.Visible))]
 public Boolean? Visible { get => _Visible; set => UpdateField(ref _Visible, value, nameof(Visible)); }

 private Boolean? _Visible;
 /// <summary>
 /// Specifies the callback that returns visible.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.GetVisible))]
 public String? GetVisible { get => _GetVisible; set => UpdateField(ref _GetVisible, value, nameof(GetVisible)); }

 private String? _GetVisible;
 /// <summary>
 /// Specifies the keyboard tip shown for quick access.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.Keytip))]
 public String? Keytip { get => _Keytip; set => UpdateField(ref _Keytip, value, nameof(Keytip)); }

 private String? _Keytip;
 /// <summary>
 /// Specifies the callback that returns keytip.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.GetKeytip))]
 public String? GetKeytip { get => _GetKeytip; set => UpdateField(ref _GetKeytip, value, nameof(GetKeytip)); }

 private String? _GetKeytip;
 /// <summary>
 /// Specifies whether the label is shown.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.ShowLabel))]
 public Boolean? ShowLabel { get => _ShowLabel; set => UpdateField(ref _ShowLabel, value, nameof(ShowLabel)); }

 private Boolean? _ShowLabel;
 /// <summary>
 /// Specifies the callback that returns show label.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.GetShowLabel))]
 public String? GetShowLabel { get => _GetShowLabel; set => UpdateField(ref _GetShowLabel, value, nameof(GetShowLabel)); }

 private String? _GetShowLabel;
 /// <summary>
 /// Specifies whether the image is shown.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.ShowImage))]
 public Boolean? ShowImage { get => _ShowImage; set => UpdateField(ref _ShowImage, value, nameof(ShowImage)); }

 private Boolean? _ShowImage;
 /// <summary>
 /// Specifies the callback that returns show image.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.Menu.GetShowImage))]
 public String? GetShowImage { get => _GetShowImage; set => UpdateField(ref _GetShowImage, value, nameof(GetShowImage)); }

 private String? _GetShowImage;
}