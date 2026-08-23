namespace DocumentModel.CustomUI;

/// <summary>
/// <para>Defines the EditBox Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:editBox.</para>
/// </summary>
[OpenXmlType(typeof(DXO10CUI.EditBox))]
[DataContract]
[XmlRoot("EditBox", Namespace = "DocumentModel.CustomUI")]
public partial class EditBox: ModelElement<DXO10CUI.EditBox>
{
  /// <summary>
  /// Specifies whether the control is enabled.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.Enabled))]
  public Boolean? Enabled
  {
    get => _Enabled ??= GetProperty<Boolean?>(GetUpdatableElement()?.Enabled);
    set => UpdateField(ref _Enabled, value, nameof(Enabled));
  }
  private Boolean? _Enabled;

  /// <summary>
  /// Specifies the callback that returns enabled.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.GetEnabled))]
  public String? GetEnabled
  {
    get => _GetEnabled ??= GetProperty<String?>(GetUpdatableElement()?.GetEnabled);
    set => UpdateField(ref _GetEnabled, value, nameof(GetEnabled));
  }
  private String? _GetEnabled;

  /// <summary>
  /// Specifies a custom image resource identifier.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.Image))]
  public String? Image
  {
    get => _Image ??= GetProperty<String?>(GetUpdatableElement()?.Image);
    set => UpdateField(ref _Image, value, nameof(Image));
  }
  private String? _Image;

  /// <summary>
  /// Specifies the built-in Office image identifier.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.ImageMso))]
  public String? ImageMso
  {
    get => _ImageMso ??= GetProperty<String?>(GetUpdatableElement()?.ImageMso);
    set => UpdateField(ref _ImageMso, value, nameof(ImageMso));
  }
  private String? _ImageMso;

  /// <summary>
  /// Specifies the callback that returns image.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.GetImage))]
  public String? GetImage
  {
    get => _GetImage ??= GetProperty<String?>(GetUpdatableElement()?.GetImage);
    set => UpdateField(ref _GetImage, value, nameof(GetImage));
  }
  private String? _GetImage;

  /// <summary>
  /// Specifies the maximum number of allowed characters.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.MaxLength))]
  public int? MaxLength
  {
    get => _MaxLength ??= GetProperty<int?>(GetUpdatableElement()?.MaxLength);
    set => UpdateField(ref _MaxLength, value, nameof(MaxLength));
  }
  private int? _MaxLength;

  /// <summary>
  /// Specifies the callback that returns text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.GetText))]
  public String? GetText
  {
    get => _GetText ??= GetProperty<String?>(GetUpdatableElement()?.GetText);
    set => UpdateField(ref _GetText, value, nameof(GetText));
  }
  private String? _GetText;

  /// <summary>
  /// Specifies the callback invoked when change occurs.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.OnChange))]
  public String? OnChange
  {
    get => _OnChange ??= GetProperty<String?>(GetUpdatableElement()?.OnChange);
    set => UpdateField(ref _OnChange, value, nameof(OnChange));
  }
  private String? _OnChange;

  /// <summary>
  /// Specifies sample text used to size the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.SizeString))]
  public String? SizeString
  {
    get => _SizeString ??= GetProperty<String?>(GetUpdatableElement()?.SizeString);
    set => UpdateField(ref _SizeString, value, nameof(SizeString));
  }
  private String? _SizeString;

  /// <summary>
  /// Specifies the unique identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.Id))]
  public String? Id
  {
    get => _Id ??= GetProperty<String?>(GetUpdatableElement()?.Id);
    set => UpdateField(ref _Id, value, nameof(Id));
  }
  private String? _Id;

  /// <summary>
  /// Specifies the qualified identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.QualifiedId))]
  public String? QualifiedId
  {
    get => _QualifiedId ??= GetProperty<String?>(GetUpdatableElement()?.QualifiedId);
    set => UpdateField(ref _QualifiedId, value, nameof(QualifiedId));
  }
  private String? _QualifiedId;

  /// <summary>
  /// Specifies an application-defined tag for the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.Tag))]
  public String? Tag
  {
    get => _Tag ??= GetProperty<String?>(GetUpdatableElement()?.Tag);
    set => UpdateField(ref _Tag, value, nameof(Tag));
  }
  private String? _Tag;

  /// <summary>
  /// Specifies the identifier of a built-in Office control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.IdMso))]
  public String? IdMso
  {
    get => _IdMso ??= GetProperty<String?>(GetUpdatableElement()?.IdMso);
    set => UpdateField(ref _IdMso, value, nameof(IdMso));
  }
  private String? _IdMso;

  /// <summary>
  /// Specifies the short screen tip text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.Screentip))]
  public String? Screentip
  {
    get => _Screentip ??= GetProperty<String?>(GetUpdatableElement()?.Screentip);
    set => UpdateField(ref _Screentip, value, nameof(Screentip));
  }
  private String? _Screentip;

  /// <summary>
  /// Specifies the callback that returns screentip.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.GetScreentip))]
  public String? GetScreentip
  {
    get => _GetScreentip ??= GetProperty<String?>(GetUpdatableElement()?.GetScreentip);
    set => UpdateField(ref _GetScreentip, value, nameof(GetScreentip));
  }
  private String? _GetScreentip;

  /// <summary>
  /// Specifies the extended super tip text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.Supertip))]
  public String? Supertip
  {
    get => _Supertip ??= GetProperty<String?>(GetUpdatableElement()?.Supertip);
    set => UpdateField(ref _Supertip, value, nameof(Supertip));
  }
  private String? _Supertip;

  /// <summary>
  /// Specifies the callback that returns supertip.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.GetSupertip))]
  public String? GetSupertip
  {
    get => _GetSupertip ??= GetProperty<String?>(GetUpdatableElement()?.GetSupertip);
    set => UpdateField(ref _GetSupertip, value, nameof(GetSupertip));
  }
  private String? _GetSupertip;

  /// <summary>
  /// Specifies the display label of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.Label))]
  public String? Label
  {
    get => _Label ??= GetProperty<String?>(GetUpdatableElement()?.Label);
    set => UpdateField(ref _Label, value, nameof(Label));
  }
  private String? _Label;

  /// <summary>
  /// Specifies the callback that returns label.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.GetLabel))]
  public String? GetLabel
  {
    get => _GetLabel ??= GetProperty<String?>(GetUpdatableElement()?.GetLabel);
    set => UpdateField(ref _GetLabel, value, nameof(GetLabel));
  }
  private String? _GetLabel;

  /// <summary>
  /// Specifies a built-in control after which this control is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.InsertAfterMso))]
  public String? InsertAfterMso
  {
    get => _InsertAfterMso ??= GetProperty<String?>(GetUpdatableElement()?.InsertAfterMso);
    set => UpdateField(ref _InsertAfterMso, value, nameof(InsertAfterMso));
  }
  private String? _InsertAfterMso;

  /// <summary>
  /// Specifies a built-in control before which this control is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.InsertBeforeMso))]
  public String? InsertBeforeMso
  {
    get => _InsertBeforeMso ??= GetProperty<String?>(GetUpdatableElement()?.InsertBeforeMso);
    set => UpdateField(ref _InsertBeforeMso, value, nameof(InsertBeforeMso));
  }
  private String? _InsertBeforeMso;

  /// <summary>
  /// Specifies a qualified control identifier after which this control is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.InsertAfterQulifiedId))]
  public String? InsertAfterQualifiedId
  {
    get => _InsertAfterQualifiedId ??= GetProperty<String?>(GetUpdatableElement()?.InsertAfterQulifiedId);
    set => UpdateField(ref _InsertAfterQualifiedId, value, nameof(InsertAfterQualifiedId));
  }
  private String? _InsertAfterQualifiedId;

  /// <summary>
  /// Specifies a qualified control identifier before which this control is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.InsertBeforeQulifiedId))]
  public String? InsertBeforeQualifiedId
  {
    get => _InsertBeforeQualifiedId ??= GetProperty<String?>(GetUpdatableElement()?.InsertBeforeQulifiedId);
    set => UpdateField(ref _InsertBeforeQualifiedId, value, nameof(InsertBeforeQualifiedId));
  }
  private String? _InsertBeforeQualifiedId;

  /// <summary>
  /// Specifies whether the control is visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.Visible))]
  public Boolean? Visible
  {
    get => _Visible ??= GetProperty<Boolean?>(GetUpdatableElement()?.Visible);
    set => UpdateField(ref _Visible, value, nameof(Visible));
  }
  private Boolean? _Visible;

  /// <summary>
  /// Specifies the callback that returns visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.GetVisible))]
  public String? GetVisible
  {
    get => _GetVisible ??= GetProperty<String?>(GetUpdatableElement()?.GetVisible);
    set => UpdateField(ref _GetVisible, value, nameof(GetVisible));
  }
  private String? _GetVisible;

  /// <summary>
  /// Specifies the keyboard tip shown for quick access.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.Keytip))]
  public String? Keytip
  {
    get => _Keytip ??= GetProperty<String?>(GetUpdatableElement()?.Keytip);
    set => UpdateField(ref _Keytip, value, nameof(Keytip));
  }
  private String? _Keytip;

  /// <summary>
  /// Specifies the callback that returns keytip.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.GetKeytip))]
  public String? GetKeytip
  {
    get => _GetKeytip ??= GetProperty<String?>(GetUpdatableElement()?.GetKeytip);
    set => UpdateField(ref _GetKeytip, value, nameof(GetKeytip));
  }
  private String? _GetKeytip;

  /// <summary>
  /// Specifies whether the label is shown.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.ShowLabel))]
  public Boolean? ShowLabel
  {
    get => _ShowLabel ??= GetProperty<Boolean?>(GetUpdatableElement()?.ShowLabel);
    set => UpdateField(ref _ShowLabel, value, nameof(ShowLabel));
  }
  private Boolean? _ShowLabel;

  /// <summary>
  /// Specifies the callback that returns show label.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.GetShowLabel))]
  public String? GetShowLabel
  {
    get => _GetShowLabel ??= GetProperty<String?>(GetUpdatableElement()?.GetShowLabel);
    set => UpdateField(ref _GetShowLabel, value, nameof(GetShowLabel));
  }
  private String? _GetShowLabel;

  /// <summary>
  /// Specifies whether the image is shown.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.ShowImage))]
  public Boolean? ShowImage
  {
    get => _ShowImage ??= GetProperty<Boolean?>(GetUpdatableElement()?.ShowImage);
    set => UpdateField(ref _ShowImage, value, nameof(ShowImage));
  }
  private Boolean? _ShowImage;

  /// <summary>
  /// Specifies the callback that returns show image.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.EditBox.GetShowImage))]
  public String? GetShowImage
  {
    get => _GetShowImage ??= GetProperty<String?>(GetUpdatableElement()?.GetShowImage);
    set => UpdateField(ref _GetShowImage, value, nameof(GetShowImage));
  }
  private String? _GetShowImage;
}