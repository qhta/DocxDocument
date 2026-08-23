namespace DocumentModel.CustomUI;

/// <summary>
/// <para>Defines the ToggleButton Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:toggleButton.</para>
/// </summary>
[OpenXmlType(typeof(DXO10CUI.ToggleButton))]
[DataContract]
[XmlRoot("ToggleButton", Namespace = "DocumentModel.CustomUI")]
public partial class ToggleButton: ModelElement<DXO10CUI.ToggleButton>
{
  /// <summary>
  /// Specifies the size mode of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.Size))]
  public Size? Size
  {
    get => _Size ??= GetProperty<Size?>(GetUpdatableElement()?.Size);
    set => UpdateField(ref _Size, value, nameof(Size));
  }
  private Size? _Size;

  /// <summary>
  /// Specifies the callback that returns size.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.GetSize))]
  public string? GetSize
  {
    get => _GetSize ??= GetProperty<string?>(GetUpdatableElement()?.GetSize);
    set => UpdateField(ref _GetSize, value, nameof(GetSize));
  }
  private string? _GetSize;

  /// <summary>
  /// Specifies the callback that returns pressed.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.GetPressed))]
  public string? GetPressed
  {
    get => _GetPressed ??= GetProperty<string?>(GetUpdatableElement()?.GetPressed);
    set => UpdateField(ref _GetPressed, value, nameof(GetPressed));
  }
  private string? _GetPressed;

  /// <summary>
  /// Specifies the callback invoked when action occurs.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.OnAction))]
  public string? OnAction
  {
    get => _OnAction ??= GetProperty<string?>(GetUpdatableElement()?.OnAction);
    set => UpdateField(ref _OnAction, value, nameof(OnAction));
  }
  private string? _OnAction;

  /// <summary>
  /// Specifies whether the control is enabled.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.Enabled))]
  public bool? Enabled
  {
    get => _Enabled ??= GetProperty<bool?>(GetUpdatableElement()?.Enabled);
    set => UpdateField(ref _Enabled, value, nameof(Enabled));
  }
  private bool? _Enabled;

  /// <summary>
  /// Specifies the callback that returns enabled.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.GetEnabled))]
  public string? GetEnabled
  {
    get => _GetEnabled ??= GetProperty<string?>(GetUpdatableElement()?.GetEnabled);
    set => UpdateField(ref _GetEnabled, value, nameof(GetEnabled));
  }
  private string? _GetEnabled;

  /// <summary>
  /// Specifies descriptive text associated with the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.Description))]
  public string? Description
  {
    get => _Description ??= GetProperty<string?>(GetUpdatableElement()?.Description);
    set => UpdateField(ref _Description, value, nameof(Description));
  }
  private string? _Description;

  /// <summary>
  /// Specifies the callback that returns description.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.GetDescription))]
  public string? GetDescription
  {
    get => _GetDescription ??= GetProperty<string?>(GetUpdatableElement()?.GetDescription);
    set => UpdateField(ref _GetDescription, value, nameof(GetDescription));
  }
  private string? _GetDescription;

  /// <summary>
  /// Specifies a custom image resource identifier.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.Image))]
  public string? Image
  {
    get => _Image ??= GetProperty<string?>(GetUpdatableElement()?.Image);
    set => UpdateField(ref _Image, value, nameof(Image));
  }
  private string? _Image;

  /// <summary>
  /// Specifies the built-in Office image identifier.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.ImageMso))]
  public string? ImageMso
  {
    get => _ImageMso ??= GetProperty<string?>(GetUpdatableElement()?.ImageMso);
    set => UpdateField(ref _ImageMso, value, nameof(ImageMso));
  }
  private string? _ImageMso;

  /// <summary>
  /// Specifies the callback that returns image.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.GetImage))]
  public string? GetImage
  {
    get => _GetImage ??= GetProperty<string?>(GetUpdatableElement()?.GetImage);
    set => UpdateField(ref _GetImage, value, nameof(GetImage));
  }
  private string? _GetImage;

  /// <summary>
  /// Specifies the unique identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.Id))]
  public string? Id
  {
    get => _Id ??= GetProperty<string?>(GetUpdatableElement()?.Id);
    set => UpdateField(ref _Id, value, nameof(Id));
  }
  private string? _Id;

  /// <summary>
  /// Specifies the qualified identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.QualifiedId))]
  public string? QualifiedId
  {
    get => _QualifiedId ??= GetProperty<string?>(GetUpdatableElement()?.QualifiedId);
    set => UpdateField(ref _QualifiedId, value, nameof(QualifiedId));
  }
  private string? _QualifiedId;

  /// <summary>
  /// Specifies an application-defined tag for the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.Tag))]
  public string? Tag
  {
    get => _Tag ??= GetProperty<string?>(GetUpdatableElement()?.Tag);
    set => UpdateField(ref _Tag, value, nameof(Tag));
  }
  private string? _Tag;

  /// <summary>
  /// Specifies the identifier of a built-in Office control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.IdMso))]
  public string? IdMso
  {
    get => _IdMso ??= GetProperty<string?>(GetUpdatableElement()?.IdMso);
    set => UpdateField(ref _IdMso, value, nameof(IdMso));
  }
  private string? _IdMso;

  /// <summary>
  /// Specifies the short screen tip text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.Screentip))]
  public string? Screentip
  {
    get => _Screentip ??= GetProperty<string?>(GetUpdatableElement()?.Screentip);
    set => UpdateField(ref _Screentip, value, nameof(Screentip));
  }
  private string? _Screentip;

  /// <summary>
  /// Specifies the callback that returns screentip.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.GetScreentip))]
  public string? GetScreentip
  {
    get => _GetScreentip ??= GetProperty<string?>(GetUpdatableElement()?.GetScreentip);
    set => UpdateField(ref _GetScreentip, value, nameof(GetScreentip));
  }
  private string? _GetScreentip;

  /// <summary>
  /// Specifies the extended super tip text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.Supertip))]
  public string? Supertip
  {
    get => _Supertip ??= GetProperty<string?>(GetUpdatableElement()?.Supertip);
    set => UpdateField(ref _Supertip, value, nameof(Supertip));
  }
  private string? _Supertip;

  /// <summary>
  /// Specifies the callback that returns supertip.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.GetSupertip))]
  public string? GetSupertip
  {
    get => _GetSupertip ??= GetProperty<string?>(GetUpdatableElement()?.GetSupertip);
    set => UpdateField(ref _GetSupertip, value, nameof(GetSupertip));
  }
  private string? _GetSupertip;

  /// <summary>
  /// Specifies the display label of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.Label))]
  public string? Label
  {
    get => _Label ??= GetProperty<string?>(GetUpdatableElement()?.Label);
    set => UpdateField(ref _Label, value, nameof(Label));
  }
  private string? _Label;

  /// <summary>
  /// Specifies the callback that returns label.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.GetLabel))]
  public string? GetLabel
  {
    get => _GetLabel ??= GetProperty<string?>(GetUpdatableElement()?.GetLabel);
    set => UpdateField(ref _GetLabel, value, nameof(GetLabel));
  }
  private string? _GetLabel;

  /// <summary>
  /// Specifies a built-in control after which this control is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.InsertAfterMso))]
  public string? InsertAfterMso
  {
    get => _InsertAfterMso ??= GetProperty<string?>(GetUpdatableElement()?.InsertAfterMso);
    set => UpdateField(ref _InsertAfterMso, value, nameof(InsertAfterMso));
  }
  private string? _InsertAfterMso;

  /// <summary>
  /// Specifies a built-in control before which this control is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.InsertBeforeMso))]
  public string? InsertBeforeMso
  {
    get => _InsertBeforeMso ??= GetProperty<string?>(GetUpdatableElement()?.InsertBeforeMso);
    set => UpdateField(ref _InsertBeforeMso, value, nameof(InsertBeforeMso));
  }
  private string? _InsertBeforeMso;

  /// <summary>
  /// Specifies a qualified control identifier after which this control is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.InsertAfterQulifiedId))]
  public string? InsertAfterQualifiedId
  {
    get => _InsertAfterQualifiedId ??= GetProperty<string?>(GetUpdatableElement()?.InsertAfterQulifiedId);
    set => UpdateField(ref _InsertAfterQualifiedId, value, nameof(InsertAfterQualifiedId));
  }
  private string? _InsertAfterQualifiedId;

  /// <summary>
  /// Specifies a qualified control identifier before which this control is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.InsertBeforeQulifiedId))]
  public string? InsertBeforeQualifiedId
  {
    get => _InsertBeforeQualifiedId ??= GetProperty<string?>(GetUpdatableElement()?.InsertBeforeQulifiedId);
    set => UpdateField(ref _InsertBeforeQualifiedId, value, nameof(InsertBeforeQualifiedId));
  }
  private string? _InsertBeforeQualifiedId;

  /// <summary>
  /// Specifies whether the control is visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.Visible))]
  public bool? Visible
  {
    get => _Visible ??= GetProperty<bool?>(GetUpdatableElement()?.Visible);
    set => UpdateField(ref _Visible, value, nameof(Visible));
  }
  private bool? _Visible;

  /// <summary>
  /// Specifies the callback that returns visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.GetVisible))]
  public string? GetVisible
  {
    get => _GetVisible ??= GetProperty<string?>(GetUpdatableElement()?.GetVisible);
    set => UpdateField(ref _GetVisible, value, nameof(GetVisible));
  }
  private string? _GetVisible;

  /// <summary>
  /// Specifies the keyboard tip shown for quick access.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.Keytip))]
  public string? Keytip
  {
    get => _Keytip ??= GetProperty<string?>(GetUpdatableElement()?.Keytip);
    set => UpdateField(ref _Keytip, value, nameof(Keytip));
  }
  private string? _Keytip;

  /// <summary>
  /// Specifies the callback that returns keytip.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.GetKeytip))]
  public string? GetKeytip
  {
    get => _GetKeytip ??= GetProperty<string?>(GetUpdatableElement()?.GetKeytip);
    set => UpdateField(ref _GetKeytip, value, nameof(GetKeytip));
  }
  private string? _GetKeytip;

  /// <summary>
  /// Specifies whether the label is shown.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.ShowLabel))]
  public bool? ShowLabel
  {
    get => _ShowLabel ??= GetProperty<bool?>(GetUpdatableElement()?.ShowLabel);
    set => UpdateField(ref _ShowLabel, value, nameof(ShowLabel));
  }
  private bool? _ShowLabel;

  /// <summary>
  /// Specifies the callback that returns show label.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.GetShowLabel))]
  public string? GetShowLabel
  {
    get => _GetShowLabel ??= GetProperty<string?>(GetUpdatableElement()?.GetShowLabel);
    set => UpdateField(ref _GetShowLabel, value, nameof(GetShowLabel));
  }
  private string? _GetShowLabel;

  /// <summary>
  /// Specifies whether the image is shown.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.ShowImage))]
  public bool? ShowImage
  {
    get => _ShowImage ??= GetProperty<bool?>(GetUpdatableElement()?.ShowImage);
    set => UpdateField(ref _ShowImage, value, nameof(ShowImage));
  }
  private bool? _ShowImage;

  /// <summary>
  /// Specifies the callback that returns show image.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.ToggleButton.GetShowImage))]
  public string? GetShowImage
  {
    get => _GetShowImage ??= GetProperty<string?>(GetUpdatableElement()?.GetShowImage);
    set => UpdateField(ref _GetShowImage, value, nameof(GetShowImage));
  }
  private string? _GetShowImage;
}