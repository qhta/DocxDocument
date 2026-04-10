namespace DocumentModel.CustomUI;
/// <summary>
/// <para>Defines the BackstageSubMenu Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:menu.</para>
/// </summary>
/// <remark>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup"/> <c>&lt;mso14:menuGroup&gt;</c></description></item>
/// </list>
/// </remark>
[OpenXmlType(typeof(DXO10CUI.BackstageSubMenu))]
[XmlRoot("BackstageSubMenu", Namespace = "DocumentModel.CustomUI")]
public class BackstageSubMenu : ModelElement<DXO10CUI.BackstageSubMenu>
{
 /// <summary>
 /// Specifies descriptive text associated with the submenu.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageSubMenu.Description))]
 public String? Description { get => _Description; set => UpdateField(ref _Description, value, nameof(Description)); }

 private String? _Description;
 /// <summary>
 /// Specifies the callback that returns the description text.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageSubMenu.GetDescription))]
 public String? GetDescription { get => _GetDescription; set => UpdateField(ref _GetDescription, value, nameof(GetDescription)); }

 private String? _GetDescription;
 /// <summary>
 /// Specifies the unique identifier of the submenu.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageSubMenu.Id))]
 public String? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

 private String? _Id;
 /// <summary>
 /// Specifies the qualified identifier of the submenu.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageSubMenu.QualifiedId))]
 public String? QualifiedId { get => _QualifiedId; set => UpdateField(ref _QualifiedId, value, nameof(QualifiedId)); }

 private String? _QualifiedId;
 /// <summary>
 /// Specifies an application-defined tag for the submenu.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageSubMenu.Tag))]
 public String? Tag { get => _Tag; set => UpdateField(ref _Tag, value, nameof(Tag)); }

 private String? _Tag;
 /// <summary>
 /// Specifies whether the submenu is enabled.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageSubMenu.Enabled))]
 public Boolean? Enabled { get => _Enabled; set => UpdateField(ref _Enabled, value, nameof(Enabled)); }

 private Boolean? _Enabled;
 /// <summary>
 /// Specifies the callback that returns whether the submenu is enabled.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageSubMenu.GetEnabled))]
 public String? GetEnabled { get => _GetEnabled; set => UpdateField(ref _GetEnabled, value, nameof(GetEnabled)); }

 private String? _GetEnabled;
 /// <summary>
 /// Specifies the display label of the submenu.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageSubMenu.Label))]
 public String? Label { get => _Label; set => UpdateField(ref _Label, value, nameof(Label)); }

 private String? _Label;
 /// <summary>
 /// Specifies the callback that returns the submenu label.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageSubMenu.GetLabel))]
 public String? GetLabel { get => _GetLabel; set => UpdateField(ref _GetLabel, value, nameof(GetLabel)); }

 private String? _GetLabel;
 /// <summary>
 /// Specifies whether the submenu is visible.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageSubMenu.Visible))]
 public Boolean? Visible { get => _Visible; set => UpdateField(ref _Visible, value, nameof(Visible)); }

 private Boolean? _Visible;
 /// <summary>
 /// Specifies the callback that returns whether the submenu is visible.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageSubMenu.GetVisible))]
 public String? GetVisible { get => _GetVisible; set => UpdateField(ref _GetVisible, value, nameof(GetVisible)); }

 private String? _GetVisible;
 /// <summary>
 /// Specifies a custom image resource identifier.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageSubMenu.Image))]
 public String? Image { get => _Image; set => UpdateField(ref _Image, value, nameof(Image)); }

 private String? _Image;
 /// <summary>
 /// Specifies the built-in Office image identifier.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageSubMenu.ImageMso))]
 public String? ImageMso { get => _ImageMso; set => UpdateField(ref _ImageMso, value, nameof(ImageMso)); }

 private String? _ImageMso;
 /// <summary>
 /// Specifies the callback that returns the submenu image.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageSubMenu.GetImage))]
 public String? GetImage { get => _GetImage; set => UpdateField(ref _GetImage, value, nameof(GetImage)); }

 private String? _GetImage;
 /// <summary>
 /// Specifies the keyboard tip shown for quick access.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageSubMenu.Keytip))]
 public String? Keytip { get => _Keytip; set => UpdateField(ref _Keytip, value, nameof(Keytip)); }

 private String? _Keytip;
 /// <summary>
 /// Specifies the callback that returns the keyboard tip.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageSubMenu.GetKeytip))]
 public String? GetKeytip { get => _GetKeytip; set => UpdateField(ref _GetKeytip, value, nameof(GetKeytip)); }

 private String? _GetKeytip;
}