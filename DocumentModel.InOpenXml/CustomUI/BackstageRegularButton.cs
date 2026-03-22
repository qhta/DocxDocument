namespace DocumentModel.CustomUI;
/// <summary>
/// <para>Defines the BackstageRegularButton Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:button.</para>
/// </summary>
[OpenXmlType(typeof(DXO10CUI.BackstageRegularButton))]
public class BackstageRegularButton : ModelElement<DXO10CUI.BackstageRegularButton>
{
 /// <summary>
 /// Specifies the short screen tip text.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageRegularButton.Screentip))]
 public String? Screentip { get => _Screentip; set => UpdateField(ref _Screentip, value, nameof(Screentip)); }
 private String? _Screentip;
 /// <summary>
 /// Specifies the callback that returns screen tip text.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageRegularButton.GetScreentip))]
 public String? GetScreentip { get => _GetScreentip; set => UpdateField(ref _GetScreentip, value, nameof(GetScreentip)); }
 private String? _GetScreentip;
 /// <summary>
 /// Specifies the extended super tip text.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageRegularButton.Supertip))]
 public String? Supertip { get => _Supertip; set => UpdateField(ref _Supertip, value, nameof(Supertip)); }
 private String? _Supertip;
 /// <summary>
 /// Specifies the callback that returns super tip text.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageRegularButton.GetSupertip))]
 public String? GetSupertip { get => _GetSupertip; set => UpdateField(ref _GetSupertip, value, nameof(GetSupertip)); }
 private String? _GetSupertip;
 /// <summary>
 /// Specifies the unique identifier of the control.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageRegularButton.Id))]
 public String? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }
 private String? _Id;
 /// <summary>
 /// Specifies the qualified identifier of the control.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageRegularButton.QualifiedId))]
 public String? QualifiedId { get => _QualifiedId; set => UpdateField(ref _QualifiedId, value, nameof(QualifiedId)); }
 private String? _QualifiedId;
 /// <summary>
 /// Specifies an application-defined tag for the control.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageRegularButton.Tag))]
 public String? Tag { get => _Tag; set => UpdateField(ref _Tag, value, nameof(Tag)); }
 private String? _Tag;
 /// <summary>
 /// Specifies the callback invoked when the control action occurs.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageRegularButton.OnAction))]
 public String? OnAction { get => _OnAction; set => UpdateField(ref _OnAction, value, nameof(OnAction)); }
 private String? _OnAction;
 /// <summary>
 /// Specifies whether the action is marked as definitive.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageRegularButton.IsDefinitive))]
 public Boolean? IsDefinitive { get => _IsDefinitive; set => UpdateField(ref _IsDefinitive, value, nameof(IsDefinitive)); }
 private Boolean? _IsDefinitive;
 /// <summary>
 /// Specifies whether the control is enabled.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageRegularButton.Enabled))]
 public Boolean? Enabled { get => _Enabled; set => UpdateField(ref _Enabled, value, nameof(Enabled)); }
 private Boolean? _Enabled;
 /// <summary>
 /// Specifies the callback that returns whether the control is enabled.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageRegularButton.GetEnabled))]
 public String? GetEnabled { get => _GetEnabled; set => UpdateField(ref _GetEnabled, value, nameof(GetEnabled)); }
 private String? _GetEnabled;
 /// <summary>
 /// Specifies the display label of the control.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageRegularButton.Label))]
 public String? Label { get => _Label; set => UpdateField(ref _Label, value, nameof(Label)); }
 private String? _Label;
 /// <summary>
 /// Specifies the callback that returns the control label.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageRegularButton.GetLabel))]
 public String? GetLabel { get => _GetLabel; set => UpdateField(ref _GetLabel, value, nameof(GetLabel)); }
 private String? _GetLabel;
 /// <summary>
 /// Specifies whether the control is visible.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageRegularButton.Visible))]
 public Boolean? Visible { get => _Visible; set => UpdateField(ref _Visible, value, nameof(Visible)); }
 private Boolean? _Visible;
 /// <summary>
 /// Specifies the callback that returns whether the control is visible.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageRegularButton.GetVisible))]
 public String? GetVisible { get => _GetVisible; set => UpdateField(ref _GetVisible, value, nameof(GetVisible)); }
 private String? _GetVisible;
 /// <summary>
 /// Specifies the keyboard tip shown for quick access.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageRegularButton.Keytip))]
 public String? Keytip { get => _Keytip; set => UpdateField(ref _Keytip, value, nameof(Keytip)); }
 private String? _Keytip;
 /// <summary>
 /// Specifies the callback that returns the keyboard tip.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageRegularButton.GetKeytip))]
 public String? GetKeytip { get => _GetKeytip; set => UpdateField(ref _GetKeytip, value, nameof(GetKeytip)); }
 private String? _GetKeytip;
 /// <summary>
 /// Specifies a custom image resource identifier.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageRegularButton.Image))]
 public String? Image { get => _Image; set => UpdateField(ref _Image, value, nameof(Image)); }
 private String? _Image;
 /// <summary>
 /// Specifies the built-in Office image identifier.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageRegularButton.ImageMso))]
 public String? ImageMso { get => _ImageMso; set => UpdateField(ref _ImageMso, value, nameof(ImageMso)); }
 private String? _ImageMso;
 /// <summary>
 /// Specifies the callback that returns the control image.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10CUI.BackstageRegularButton.GetImage))]
 public String? GetImage { get => _GetImage; set => UpdateField(ref _GetImage, value, nameof(GetImage)); }
 private String? _GetImage;
}