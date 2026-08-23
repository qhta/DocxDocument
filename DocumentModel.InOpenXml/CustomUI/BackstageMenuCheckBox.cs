namespace DocumentModel.CustomUI;

/// <summary>
/// <para>Defines the BackstageMenuCheckBox Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:checkBox.</para>
/// </summary>
[OpenXmlType(typeof(DXO10CUI.BackstageMenuCheckBox))]
[DataContract]
[XmlRoot("BackstageMenuCheckBox", Namespace = "DocumentModel.CustomUI")]
public partial class BackstageMenuCheckBox: ModelElement<DXO10CUI.BackstageMenuCheckBox>
{
  /// <summary>
  /// Specifies descriptive text associated with the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageMenuCheckBox.Description))]
  public String? Description
  {
    get => _Description ??= GetProperty<String?>(GetUpdatableElement()?.Description);
    set => UpdateField(ref _Description, value, nameof(Description));
  }
  private String? _Description;

  /// <summary>
  /// Specifies the callback that returns the description text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageMenuCheckBox.GetDescription))]
  public String? GetDescription
  {
    get => _GetDescription ??= GetProperty<String?>(GetUpdatableElement()?.GetDescription);
    set => UpdateField(ref _GetDescription, value, nameof(GetDescription));
  }
  private String? _GetDescription;

  /// <summary>
  /// Specifies the unique identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageMenuCheckBox.Id))]
  public String? Id
  {
    get => _Id ??= GetProperty<String?>(GetUpdatableElement()?.Id);
    set => UpdateField(ref _Id, value, nameof(Id));
  }
  private String? _Id;

  /// <summary>
  /// Specifies the qualified identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageMenuCheckBox.QualifiedId))]
  public String? QualifiedId
  {
    get => _QualifiedId ??= GetProperty<String?>(GetUpdatableElement()?.QualifiedId);
    set => UpdateField(ref _QualifiedId, value, nameof(QualifiedId));
  }
  private String? _QualifiedId;

  /// <summary>
  /// Specifies an application-defined tag for the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageMenuCheckBox.Tag))]
  public String? Tag
  {
    get => _Tag ??= GetProperty<String?>(GetUpdatableElement()?.Tag);
    set => UpdateField(ref _Tag, value, nameof(Tag));
  }
  private String? _Tag;

  /// <summary>
  /// Specifies the callback invoked when the control action occurs.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageMenuCheckBox.OnAction))]
  public String? OnAction
  {
    get => _OnAction ??= GetProperty<String?>(GetUpdatableElement()?.OnAction);
    set => UpdateField(ref _OnAction, value, nameof(OnAction));
  }
  private String? _OnAction;

  /// <summary>
  /// Specifies the callback that returns the checked state.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageMenuCheckBox.GetPressed))]
  public String? GetPressed
  {
    get => _GetPressed ??= GetProperty<String?>(GetUpdatableElement()?.GetPressed);
    set => UpdateField(ref _GetPressed, value, nameof(GetPressed));
  }
  private String? _GetPressed;

  /// <summary>
  /// Specifies whether the control is enabled.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageMenuCheckBox.Enabled))]
  public Boolean? Enabled
  {
    get => _Enabled ??= GetProperty<Boolean?>(GetUpdatableElement()?.Enabled);
    set => UpdateField(ref _Enabled, value, nameof(Enabled));
  }
  private Boolean? _Enabled;

  /// <summary>
  /// Specifies the callback that returns whether the control is enabled.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageMenuCheckBox.GetEnabled))]
  public String? GetEnabled
  {
    get => _GetEnabled ??= GetProperty<String?>(GetUpdatableElement()?.GetEnabled);
    set => UpdateField(ref _GetEnabled, value, nameof(GetEnabled));
  }
  private String? _GetEnabled;

  /// <summary>
  /// Specifies the display label of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageMenuCheckBox.Label))]
  public String? Label
  {
    get => _Label ??= GetProperty<String?>(GetUpdatableElement()?.Label);
    set => UpdateField(ref _Label, value, nameof(Label));
  }
  private String? _Label;

  /// <summary>
  /// Specifies the callback that returns the control label.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageMenuCheckBox.GetLabel))]
  public String? GetLabel
  {
    get => _GetLabel ??= GetProperty<String?>(GetUpdatableElement()?.GetLabel);
    set => UpdateField(ref _GetLabel, value, nameof(GetLabel));
  }
  private String? _GetLabel;

  /// <summary>
  /// Specifies whether the control is visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageMenuCheckBox.Visible))]
  public Boolean? Visible
  {
    get => _Visible ??= GetProperty<Boolean?>(GetUpdatableElement()?.Visible);
    set => UpdateField(ref _Visible, value, nameof(Visible));
  }
  private Boolean? _Visible;

  /// <summary>
  /// Specifies the callback that returns whether the control is visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageMenuCheckBox.GetVisible))]
  public String? GetVisible
  {
    get => _GetVisible ??= GetProperty<String?>(GetUpdatableElement()?.GetVisible);
    set => UpdateField(ref _GetVisible, value, nameof(GetVisible));
  }
  private String? _GetVisible;

  /// <summary>
  /// Specifies the keyboard tip shown for quick access.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageMenuCheckBox.Keytip))]
  public String? Keytip
  {
    get => _Keytip ??= GetProperty<String?>(GetUpdatableElement()?.Keytip);
    set => UpdateField(ref _Keytip, value, nameof(Keytip));
  }
  private String? _Keytip;

  /// <summary>
  /// Specifies the callback that returns the keyboard tip.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageMenuCheckBox.GetKeytip))]
  public String? GetKeytip
  {
    get => _GetKeytip ??= GetProperty<String?>(GetUpdatableElement()?.GetKeytip);
    set => UpdateField(ref _GetKeytip, value, nameof(GetKeytip));
  }
  private String? _GetKeytip;
}