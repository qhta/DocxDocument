namespace DocumentModel.CustomUI;

/// <summary>
/// <para>Defines the ToggleButtonRegular Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:toggleButton.</para>
/// </summary>
[OpenXmlType(typeof(DXO10CUI.ToggleButtonRegular))]
public class ToggleButtonRegular: ModelElement<DXO10CUI.ToggleButtonRegular>
{
  /// <summary>
  /// Specifies the callback that returns pressed.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.GetPressed))]
  public String? GetPressed { get => _GetPressed; set => UpdateField(ref _GetPressed, value, nameof(GetPressed)); }

  private String? _GetPressed;

  /// <summary>
  /// Specifies the callback invoked when action occurs.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.OnAction))]
  public String? OnAction { get => _OnAction; set => UpdateField(ref _OnAction, value, nameof(OnAction)); }

  private String? _OnAction;

  /// <summary>
  /// Specifies whether the control is enabled.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.Enabled))]
  public Boolean? Enabled { get => _Enabled; set => UpdateField(ref _Enabled, value, nameof(Enabled)); }

  private Boolean? _Enabled;

  /// <summary>
  /// Specifies the callback that returns enabled.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.GetEnabled))]
  public String? GetEnabled { get => _GetEnabled; set => UpdateField(ref _GetEnabled, value, nameof(GetEnabled)); }

  private String? _GetEnabled;

  /// <summary>
  /// Specifies descriptive text associated with the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.Description))]
  public String? Description { get => _Description; set => UpdateField(ref _Description, value, nameof(Description)); }

  private String? _Description;

  /// <summary>
  /// Specifies the callback that returns description.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.GetDescription))]
  public String? GetDescription
  {
    get => _GetDescription;
    set => UpdateField(ref _GetDescription, value, nameof(GetDescription));
  }

  private String? _GetDescription;

  /// <summary>
  /// Specifies a custom image resource identifier.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.Image))]
  public String? Image { get => _Image; set => UpdateField(ref _Image, value, nameof(Image)); }

  private String? _Image;

  /// <summary>
  /// Specifies the built-in Office image identifier.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.ImageMso))]
  public String? ImageMso { get => _ImageMso; set => UpdateField(ref _ImageMso, value, nameof(ImageMso)); }

  private String? _ImageMso;

  /// <summary>
  /// Specifies the callback that returns image.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.GetImage))]
  public String? GetImage { get => _GetImage; set => UpdateField(ref _GetImage, value, nameof(GetImage)); }

  private String? _GetImage;

  /// <summary>
  /// Specifies the unique identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.Id))]
  public String? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

  private String? _Id;

  /// <summary>
  /// Specifies the qualified identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.QualifiedId))]
  public String? QualifiedId { get => _QualifiedId; set => UpdateField(ref _QualifiedId, value, nameof(QualifiedId)); }

  private String? _QualifiedId;

  /// <summary>
  /// Specifies an application-defined tag for the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.Tag))]
  public String? Tag { get => _Tag; set => UpdateField(ref _Tag, value, nameof(Tag)); }

  private String? _Tag;

  /// <summary>
  /// Specifies the identifier of a built-in Office control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.IdMso))]
  public String? IdMso { get => _IdMso; set => UpdateField(ref _IdMso, value, nameof(IdMso)); }

  private String? _IdMso;

  /// <summary>
  /// Specifies the short screen tip text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.Screentip))]
  public String? Screentip { get => _Screentip; set => UpdateField(ref _Screentip, value, nameof(Screentip)); }

  private String? _Screentip;

  /// <summary>
  /// Specifies the callback that returns screentip.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.GetScreentip))]
  public String? GetScreentip
  {
    get => _GetScreentip;
    set => UpdateField(ref _GetScreentip, value, nameof(GetScreentip));
  }

  private String? _GetScreentip;

  /// <summary>
  /// Specifies the extended super tip text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.Supertip))]
  public String? Supertip { get => _Supertip; set => UpdateField(ref _Supertip, value, nameof(Supertip)); }

  private String? _Supertip;

  /// <summary>
  /// Specifies the callback that returns supertip.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.GetSupertip))]
  public String? GetSupertip { get => _GetSupertip; set => UpdateField(ref _GetSupertip, value, nameof(GetSupertip)); }

  private String? _GetSupertip;

  /// <summary>
  /// Specifies the display label of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.Label))]
  public String? Label { get => _Label; set => UpdateField(ref _Label, value, nameof(Label)); }

  private String? _Label;

  /// <summary>
  /// Specifies the callback that returns label.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.GetLabel))]
  public String? GetLabel { get => _GetLabel; set => UpdateField(ref _GetLabel, value, nameof(GetLabel)); }

  private String? _GetLabel;

  /// <summary>
  /// Specifies a built-in control after which this control is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.InsertAfterMso))]
  public String? InsertAfterMso
  {
    get => _InsertAfterMso;
    set => UpdateField(ref _InsertAfterMso, value, nameof(InsertAfterMso));
  }

  private String? _InsertAfterMso;

  /// <summary>
  /// Specifies a built-in control before which this control is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.InsertBeforeMso))]
  public String? InsertBeforeMso
  {
    get => _InsertBeforeMso;
    set => UpdateField(ref _InsertBeforeMso, value, nameof(InsertBeforeMso));
  }

  private String? _InsertBeforeMso;

  /// <summary>
  /// Specifies a qualified control identifier after which this control is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.InsertAfterQulifiedId))]
  public String? InsertAfterQualifiedId
  {
    get => _InsertAfterQualifiedId;
    set => UpdateField(ref _InsertAfterQualifiedId, value, nameof(InsertAfterQualifiedId));
  }

  private String? _InsertAfterQualifiedId;

  /// <summary>
  /// Specifies a qualified control identifier before which this control is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.InsertBeforeQulifiedId))]
  public String? InsertBeforeQualifiedId
  {
    get => _InsertBeforeQualifiedId;
    set => UpdateField(ref _InsertBeforeQualifiedId, value, nameof(InsertBeforeQualifiedId));
  }

  private String? _InsertBeforeQualifiedId;

  /// <summary>
  /// Specifies whether the control is visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.Visible))]
  public Boolean? Visible { get => _Visible; set => UpdateField(ref _Visible, value, nameof(Visible)); }

  private Boolean? _Visible;

  /// <summary>
  /// Specifies the callback that returns visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.GetVisible))]
  public String? GetVisible { get => _GetVisible; set => UpdateField(ref _GetVisible, value, nameof(GetVisible)); }

  private String? _GetVisible;

  /// <summary>
  /// Specifies the keyboard tip shown for quick access.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.Keytip))]
  public String? Keytip { get => _Keytip; set => UpdateField(ref _Keytip, value, nameof(Keytip)); }

  private String? _Keytip;

  /// <summary>
  /// Specifies the callback that returns keytip.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.GetKeytip))]
  public String? GetKeytip { get => _GetKeytip; set => UpdateField(ref _GetKeytip, value, nameof(GetKeytip)); }

  private String? _GetKeytip;

  /// <summary>
  /// Specifies whether the label is shown.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.ShowLabel))]
  public Boolean? ShowLabel { get => _ShowLabel; set => UpdateField(ref _ShowLabel, value, nameof(ShowLabel)); }

  private Boolean? _ShowLabel;

  /// <summary>
  /// Specifies the callback that returns show label.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.GetShowLabel))]
  public String? GetShowLabel
  {
    get => _GetShowLabel;
    set => UpdateField(ref _GetShowLabel, value, nameof(GetShowLabel));
  }

  private String? _GetShowLabel;

  /// <summary>
  /// Specifies whether the image is shown.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.ShowImage))]
  public Boolean? ShowImage { get => _ShowImage; set => UpdateField(ref _ShowImage, value, nameof(ShowImage)); }

  private Boolean? _ShowImage;

  /// <summary>
  /// Specifies the callback that returns show image.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButtonRegular.GetShowImage))]
  public String? GetShowImage
  {
    get => _GetShowImage;
    set => UpdateField(ref _GetShowImage, value, nameof(GetShowImage));
  }

  private String? _GetShowImage;
}