namespace DocumentModel.CustomUI;

/// <summary>
/// <para>Defines the Group Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:group.</para>
/// </summary>
/// <remark>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.Box"/> <c>&lt;mso14:box&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.Button"/> <c>&lt;mso14:button&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup"/> <c>&lt;mso14:buttonGroup&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox"/> <c>&lt;mso14:checkBox&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.ComboBox"/> <c>&lt;mso14:comboBox&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.ControlClone"/> <c>&lt;mso14:control&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.DialogBoxLauncher"/> <c>&lt;mso14:dialogBoxLauncher&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular"/> <c>&lt;mso14:dropDown&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenu"/> <c>&lt;mso14:dynamicMenu&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.EditBox"/> <c>&lt;mso14:editBox&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.Gallery"/> <c>&lt;mso14:gallery&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.LabelControl"/> <c>&lt;mso14:labelControl&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.Menu"/> <c>&lt;mso14:menu&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.Separator"/> <c>&lt;mso14:separator&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.SplitButton"/> <c>&lt;mso14:splitButton&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButton"/> <c>&lt;mso14:toggleButton&gt;</c></description></item>
/// </list>
/// </remark>
[OpenXmlType(typeof(DXO10CUI.Group))]
[DataContract]
[XmlRoot("Group", Namespace = "DocumentModel.CustomUI")]
public partial class Group: ModelElement<DXO10CUI.Group>
{
  /// <summary>
  /// Specifies the unique identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Group.Id))]
  public String? Id
  {
    get => _Id ??= GetProperty<String?>(GetUpdatableElement()?.Id);
    set => UpdateField(ref _Id, value, nameof(Id));
  }
  private String? _Id;

  /// <summary>
  /// Specifies the qualified identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Group.QualifiedId))]
  public String? QualifiedId
  {
    get => _QualifiedId ??= GetProperty<String?>(GetUpdatableElement()?.QualifiedId);
    set => UpdateField(ref _QualifiedId, value, nameof(QualifiedId));
  }
  private String? _QualifiedId;

  /// <summary>
  /// Specifies an application-defined tag for the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Group.Tag))]
  public String? Tag
  {
    get => _Tag ??= GetProperty<String?>(GetUpdatableElement()?.Tag);
    set => UpdateField(ref _Tag, value, nameof(Tag));
  }
  private String? _Tag;

  /// <summary>
  /// Specifies the identifier of a built-in Office control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Group.IdMso))]
  public String? IdMso
  {
    get => _IdMso ??= GetProperty<String?>(GetUpdatableElement()?.IdMso);
    set => UpdateField(ref _IdMso, value, nameof(IdMso));
  }
  private String? _IdMso;

  /// <summary>
  /// Specifies the display label of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Group.Label))]
  public String? Label
  {
    get => _Label ??= GetProperty<String?>(GetUpdatableElement()?.Label);
    set => UpdateField(ref _Label, value, nameof(Label));
  }
  private String? _Label;

  /// <summary>
  /// Specifies the callback that returns label.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Group.GetLabel))]
  public String? GetLabel
  {
    get => _GetLabel ??= GetProperty<String?>(GetUpdatableElement()?.GetLabel);
    set => UpdateField(ref _GetLabel, value, nameof(GetLabel));
  }
  private String? _GetLabel;

  /// <summary>
  /// Specifies a custom image resource identifier.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Group.Image))]
  public String? Image
  {
    get => _Image ??= GetProperty<String?>(GetUpdatableElement()?.Image);
    set => UpdateField(ref _Image, value, nameof(Image));
  }
  private String? _Image;

  /// <summary>
  /// Specifies the built-in Office image identifier.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Group.ImageMso))]
  public String? ImageMso
  {
    get => _ImageMso ??= GetProperty<String?>(GetUpdatableElement()?.ImageMso);
    set => UpdateField(ref _ImageMso, value, nameof(ImageMso));
  }
  private String? _ImageMso;

  /// <summary>
  /// Specifies the callback that returns image.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Group.GetImage))]
  public String? GetImage
  {
    get => _GetImage ??= GetProperty<String?>(GetUpdatableElement()?.GetImage);
    set => UpdateField(ref _GetImage, value, nameof(GetImage));
  }
  private String? _GetImage;

  /// <summary>
  /// Specifies a built-in control after which this control is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Group.InsertAfterMso))]
  public String? InsertAfterMso
  {
    get => _InsertAfterMso ??= GetProperty<String?>(GetUpdatableElement()?.InsertAfterMso);
    set => UpdateField(ref _InsertAfterMso, value, nameof(InsertAfterMso));
  }
  private String? _InsertAfterMso;

  /// <summary>
  /// Specifies a built-in control before which this control is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Group.InsertBeforeMso))]
  public String? InsertBeforeMso
  {
    get => _InsertBeforeMso ??= GetProperty<String?>(GetUpdatableElement()?.InsertBeforeMso);
    set => UpdateField(ref _InsertBeforeMso, value, nameof(InsertBeforeMso));
  }
  private String? _InsertBeforeMso;

  /// <summary>
  /// Specifies a qualified control identifier after which this control is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Group.InsertAfterQulifiedId))]
  public String? InsertAfterQualifiedId
  {
    get => _InsertAfterQualifiedId ??= GetProperty<String?>(GetUpdatableElement()?.InsertAfterQulifiedId);
    set => UpdateField(ref _InsertAfterQualifiedId, value, nameof(InsertAfterQualifiedId));
  }
  private String? _InsertAfterQualifiedId;

  /// <summary>
  /// Specifies a qualified control identifier before which this control is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Group.InsertBeforeQulifiedId))]
  public String? InsertBeforeQualifiedId
  {
    get => _InsertBeforeQualifiedId ??= GetProperty<String?>(GetUpdatableElement()?.InsertBeforeQulifiedId);
    set => UpdateField(ref _InsertBeforeQualifiedId, value, nameof(InsertBeforeQualifiedId));
  }
  private String? _InsertBeforeQualifiedId;

  /// <summary>
  /// Specifies the short screen tip text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Group.Screentip))]
  public String? Screentip
  {
    get => _Screentip ??= GetProperty<String?>(GetUpdatableElement()?.Screentip);
    set => UpdateField(ref _Screentip, value, nameof(Screentip));
  }
  private String? _Screentip;

  /// <summary>
  /// Specifies the callback that returns screentip.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Group.GetScreentip))]
  public String? GetScreentip
  {
    get => _GetScreentip ??= GetProperty<String?>(GetUpdatableElement()?.GetScreentip);
    set => UpdateField(ref _GetScreentip, value, nameof(GetScreentip));
  }
  private String? _GetScreentip;

  /// <summary>
  /// Specifies the extended super tip text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Group.Supertip))]
  public String? Supertip
  {
    get => _Supertip ??= GetProperty<String?>(GetUpdatableElement()?.Supertip);
    set => UpdateField(ref _Supertip, value, nameof(Supertip));
  }
  private String? _Supertip;

  /// <summary>
  /// Specifies the callback that returns supertip.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Group.GetSupertip))]
  public String? GetSupertip
  {
    get => _GetSupertip ??= GetProperty<String?>(GetUpdatableElement()?.GetSupertip);
    set => UpdateField(ref _GetSupertip, value, nameof(GetSupertip));
  }
  private String? _GetSupertip;

  /// <summary>
  /// Specifies whether the control is visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Group.Visible))]
  public Boolean? Visible
  {
    get => _Visible ??= GetProperty<Boolean?>(GetUpdatableElement()?.Visible);
    set => UpdateField(ref _Visible, value, nameof(Visible));
  }
  private Boolean? _Visible;

  /// <summary>
  /// Specifies the callback that returns visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Group.GetVisible))]
  public String? GetVisible
  {
    get => _GetVisible ??= GetProperty<String?>(GetUpdatableElement()?.GetVisible);
    set => UpdateField(ref _GetVisible, value, nameof(GetVisible));
  }
  private String? _GetVisible;

  /// <summary>
  /// Specifies the keyboard tip shown for quick access.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Group.Keytip))]
  public String? Keytip
  {
    get => _Keytip ??= GetProperty<String?>(GetUpdatableElement()?.Keytip);
    set => UpdateField(ref _Keytip, value, nameof(Keytip));
  }
  private String? _Keytip;

  /// <summary>
  /// Specifies the callback that returns keytip.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Group.GetKeytip))]
  public String? GetKeytip
  {
    get => _GetKeytip ??= GetProperty<String?>(GetUpdatableElement()?.GetKeytip);
    set => UpdateField(ref _GetKeytip, value, nameof(GetKeytip));
  }
  private String? _GetKeytip;

  /// <summary>
  /// Specifies whether the control layout scales automatically.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Group.AutoScale))]
  public Boolean? AutoScale
  {
    get => _AutoScale ??= GetProperty<Boolean?>(GetUpdatableElement()?.AutoScale);
    set => UpdateField(ref _AutoScale, value, nameof(AutoScale));
  }
  private Boolean? _AutoScale;

  /// <summary>
  /// Specifies whether content is centered vertically.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.Group.CenterVertically))]
  public Boolean? CenterVertically
  {
    get => _CenterVertically ??= GetProperty<Boolean?>(GetUpdatableElement()?.CenterVertically);
    set => UpdateField(ref _CenterVertically, value, nameof(CenterVertically));
  }
  private Boolean? _CenterVertically;
}