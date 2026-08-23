namespace DocumentModel.CustomUI;

/// <summary>
/// <para>Defines the Hyperlink Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:hyperlink.</para>
/// </summary>
[OpenXmlType(typeof(DXO10CUI.Hyperlink))]
[DataContract]
[XmlRoot("Hyperlink", Namespace = "DocumentModel.CustomUI")]
public partial class Hyperlink: ModelElement<DXO10CUI.Hyperlink>
{
  /// <summary>
  /// Specifies the unique identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Hyperlink.Id))]
  public String? Id
  {
    get => _Id ??= GetProperty<String?>(GetUpdatableElement()?.Id);
    set => UpdateField(ref _Id, value, nameof(Id));
  }
  private String? _Id;

  /// <summary>
  /// Specifies the qualified identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Hyperlink.QualifiedId))]
  public String? QualifiedId
  {
    get => _QualifiedId ??= GetProperty<String?>(GetUpdatableElement()?.QualifiedId);
    set => UpdateField(ref _QualifiedId, value, nameof(QualifiedId));
  }
  private String? _QualifiedId;

  /// <summary>
  /// Specifies an application-defined tag for the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Hyperlink.Tag))]
  public String? Tag
  {
    get => _Tag ??= GetProperty<String?>(GetUpdatableElement()?.Tag);
    set => UpdateField(ref _Tag, value, nameof(Tag));
  }
  private String? _Tag;

  /// <summary>
  /// Specifies the alignment setting for the control label.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Hyperlink.AlignLabel))]
  public Expand? AlignLabel
  {
    get => _AlignLabel ??= GetProperty<Expand?>(GetUpdatableElement()?.AlignLabel);
    set => UpdateField(ref _AlignLabel, value, nameof(AlignLabel));
  }
  private Expand? _AlignLabel;

  /// <summary>
  /// Specifies the expansion position in the layout.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Hyperlink.Expand))]
  public Expand? Expand
  {
    get => _Expand ??= GetProperty<Expand?>(GetUpdatableElement()?.Expand);
    set => UpdateField(ref _Expand, value, nameof(Expand));
  }
  private Expand? _Expand;

  /// <summary>
  /// Specifies whether the control is enabled.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Hyperlink.Enabled))]
  public Boolean? Enabled
  {
    get => _Enabled ??= GetProperty<Boolean?>(GetUpdatableElement()?.Enabled);
    set => UpdateField(ref _Enabled, value, nameof(Enabled));
  }
  private Boolean? _Enabled;

  /// <summary>
  /// Specifies the callback that returns enabled.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Hyperlink.GetEnabled))]
  public String? GetEnabled
  {
    get => _GetEnabled ??= GetProperty<String?>(GetUpdatableElement()?.GetEnabled);
    set => UpdateField(ref _GetEnabled, value, nameof(GetEnabled));
  }
  private String? _GetEnabled;

  /// <summary>
  /// Specifies whether the control is visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Hyperlink.Visible))]
  public Boolean? Visible
  {
    get => _Visible ??= GetProperty<Boolean?>(GetUpdatableElement()?.Visible);
    set => UpdateField(ref _Visible, value, nameof(Visible));
  }
  private Boolean? _Visible;

  /// <summary>
  /// Specifies the callback that returns visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Hyperlink.GetVisible))]
  public String? GetVisible
  {
    get => _GetVisible ??= GetProperty<String?>(GetUpdatableElement()?.GetVisible);
    set => UpdateField(ref _GetVisible, value, nameof(GetVisible));
  }
  private String? _GetVisible;

  /// <summary>
  /// Specifies the keyboard tip shown for quick access.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Hyperlink.Keytip))]
  public String? Keytip
  {
    get => _Keytip ??= GetProperty<String?>(GetUpdatableElement()?.Keytip);
    set => UpdateField(ref _Keytip, value, nameof(Keytip));
  }
  private String? _Keytip;

  /// <summary>
  /// Specifies the callback that returns keytip.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Hyperlink.GetKeytip))]
  public String? GetKeytip
  {
    get => _GetKeytip ??= GetProperty<String?>(GetUpdatableElement()?.GetKeytip);
    set => UpdateField(ref _GetKeytip, value, nameof(GetKeytip));
  }
  private String? _GetKeytip;

  /// <summary>
  /// Specifies the display label of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Hyperlink.Label))]
  public String? Label
  {
    get => _Label ??= GetProperty<String?>(GetUpdatableElement()?.Label);
    set => UpdateField(ref _Label, value, nameof(Label));
  }
  private String? _Label;

  /// <summary>
  /// Specifies the callback that returns label.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Hyperlink.GetLabel))]
  public String? GetLabel
  {
    get => _GetLabel ??= GetProperty<String?>(GetUpdatableElement()?.GetLabel);
    set => UpdateField(ref _GetLabel, value, nameof(GetLabel));
  }
  private String? _GetLabel;

  /// <summary>
  /// Specifies the callback invoked when action occurs.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Hyperlink.OnAction))]
  public String? OnAction
  {
    get => _OnAction ??= GetProperty<String?>(GetUpdatableElement()?.OnAction);
    set => UpdateField(ref _OnAction, value, nameof(OnAction));
  }
  private String? _OnAction;

  /// <summary>
  /// Specifies a custom image resource identifier.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Hyperlink.Image))]
  public String? Image
  {
    get => _Image ??= GetProperty<String?>(GetUpdatableElement()?.Image);
    set => UpdateField(ref _Image, value, nameof(Image));
  }
  private String? _Image;

  /// <summary>
  /// Specifies the built-in Office image identifier.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Hyperlink.ImageMso))]
  public String? ImageMso
  {
    get => _ImageMso ??= GetProperty<String?>(GetUpdatableElement()?.ImageMso);
    set => UpdateField(ref _ImageMso, value, nameof(ImageMso));
  }
  private String? _ImageMso;

  /// <summary>
  /// Specifies the callback that returns image.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Hyperlink.GetImage))]
  public String? GetImage
  {
    get => _GetImage ??= GetProperty<String?>(GetUpdatableElement()?.GetImage);
    set => UpdateField(ref _GetImage, value, nameof(GetImage));
  }
  private String? _GetImage;

  /// <summary>
  /// Specifies the short screen tip text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Hyperlink.Screentip))]
  public String? Screentip
  {
    get => _Screentip ??= GetProperty<String?>(GetUpdatableElement()?.Screentip);
    set => UpdateField(ref _Screentip, value, nameof(Screentip));
  }
  private String? _Screentip;

  /// <summary>
  /// Specifies the callback that returns screentip.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Hyperlink.GetScreentip))]
  public String? GetScreentip
  {
    get => _GetScreentip ??= GetProperty<String?>(GetUpdatableElement()?.GetScreentip);
    set => UpdateField(ref _GetScreentip, value, nameof(GetScreentip));
  }
  private String? _GetScreentip;

  /// <summary>
  /// Specifies the extended super tip text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Hyperlink.Supertip))]
  public String? Supertip
  {
    get => _Supertip ??= GetProperty<String?>(GetUpdatableElement()?.Supertip);
    set => UpdateField(ref _Supertip, value, nameof(Supertip));
  }
  private String? _Supertip;

  /// <summary>
  /// Specifies the callback that returns supertip.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Hyperlink.GetSupertip))]
  public String? GetSupertip
  {
    get => _GetSupertip ??= GetProperty<String?>(GetUpdatableElement()?.GetSupertip);
    set => UpdateField(ref _GetSupertip, value, nameof(GetSupertip));
  }
  private String? _GetSupertip;

  /// <summary>
  /// Specifies the target.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Hyperlink.Target))]
  public String? Target
  {
    get => _Target ??= GetProperty<String?>(GetUpdatableElement()?.Target);
    set => UpdateField(ref _Target, value, nameof(Target));
  }
  private String? _Target;

  /// <summary>
  /// Specifies the callback that returns target.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Hyperlink.GetTarget))]
  public String? GetTarget
  {
    get => _GetTarget ??= GetProperty<String?>(GetUpdatableElement()?.GetTarget);
    set => UpdateField(ref _GetTarget, value, nameof(GetTarget));
  }
  private String? _GetTarget;
}