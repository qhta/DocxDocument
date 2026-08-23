namespace DocumentModel.CustomUI;

/// <summary>
/// <para>Defines the RadioGroup Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:radioGroup.</para>
/// </summary>
/// <remark>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.RadioButtonBackstageItem"/> <c>&lt;mso14:radioButton&gt;</c></description></item>
/// </list>
/// </remark>
[OpenXmlType(typeof(DXO10CUI.RadioGroup))]
[DataContract]
[XmlRoot("RadioGroup", Namespace = "DocumentModel.CustomUI")]
public partial class RadioGroup : ModelElement<DXO10CUI.RadioGroup>
{
  /// <summary>
  /// Specifies the unique identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.RadioGroup.Id))]
  public String? Id
  {
    get => _Id ??= GetProperty<String?>(GetUpdatableElement()?.Id);
    set => UpdateField(ref _Id, value, nameof(Id));
  }
  private String? _Id;

  /// <summary>
  /// Specifies the qualified identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.RadioGroup.QualifiedId))]
  public String? QualifiedId
  {
    get => _QualifiedId ??= GetProperty<String?>(GetUpdatableElement()?.QualifiedId);
    set => UpdateField(ref _QualifiedId, value, nameof(QualifiedId));
  }
  private String? _QualifiedId;

  /// <summary>
  /// Specifies an application-defined tag for the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.RadioGroup.Tag))]
  public String? Tag
  {
    get => _Tag ??= GetProperty<String?>(GetUpdatableElement()?.Tag);
    set => UpdateField(ref _Tag, value, nameof(Tag));
  }
  private String? _Tag;

  /// <summary>
  /// Specifies the alignment setting for the control label.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.RadioGroup.AlignLabel))]
  public Expand? AlignLabel
  {
    get => _AlignLabel ??= GetProperty<Expand?>(GetUpdatableElement()?.AlignLabel);
    set => UpdateField(ref _AlignLabel, value, nameof(AlignLabel));
  }
  private Expand? _AlignLabel;

  /// <summary>
  /// Specifies the expansion position in the layout.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.RadioGroup.Expand))]
  public Expand? Expand
  {
    get => _Expand ??= GetProperty<Expand?>(GetUpdatableElement()?.Expand);
    set => UpdateField(ref _Expand, value, nameof(Expand));
  }
  private Expand? _Expand;

  /// <summary>
  /// Specifies whether the control is enabled.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.RadioGroup.Enabled))]
  public Boolean? Enabled
  {
    get => _Enabled ??= GetProperty<Boolean?>(GetUpdatableElement()?.Enabled);
    set => UpdateField(ref _Enabled, value, nameof(Enabled));
  }
  private Boolean? _Enabled;

  /// <summary>
  /// Specifies the callback that returns enabled.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.RadioGroup.GetEnabled))]
  public String? GetEnabled
  {
    get => _GetEnabled ??= GetProperty<String?>(GetUpdatableElement()?.GetEnabled);
    set => UpdateField(ref _GetEnabled, value, nameof(GetEnabled));
  }
  private String? _GetEnabled;

  /// <summary>
  /// Specifies the display label of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.RadioGroup.Label))]
  public String? Label
  {
    get => _Label ??= GetProperty<String?>(GetUpdatableElement()?.Label);
    set => UpdateField(ref _Label, value, nameof(Label));
  }
  private String? _Label;

  /// <summary>
  /// Specifies the callback that returns label.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.RadioGroup.GetLabel))]
  public String? GetLabel
  {
    get => _GetLabel ??= GetProperty<String?>(GetUpdatableElement()?.GetLabel);
    set => UpdateField(ref _GetLabel, value, nameof(GetLabel));
  }
  private String? _GetLabel;

  /// <summary>
  /// Specifies whether the control is visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.RadioGroup.Visible))]
  public Boolean? Visible
  {
    get => _Visible ??= GetProperty<Boolean?>(GetUpdatableElement()?.Visible);
    set => UpdateField(ref _Visible, value, nameof(Visible));
  }
  private Boolean? _Visible;

  /// <summary>
  /// Specifies the callback that returns visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.RadioGroup.GetVisible))]
  public String? GetVisible
  {
    get => _GetVisible ??= GetProperty<String?>(GetUpdatableElement()?.GetVisible);
    set => UpdateField(ref _GetVisible, value, nameof(GetVisible));
  }
  private String? _GetVisible;

  /// <summary>
  /// Specifies the callback invoked when action occurs.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.RadioGroup.OnAction))]
  public String? OnAction
  {
    get => _OnAction ??= GetProperty<String?>(GetUpdatableElement()?.OnAction);
    set => UpdateField(ref _OnAction, value, nameof(OnAction));
  }
  private String? _OnAction;

  /// <summary>
  /// Specifies the keyboard tip shown for quick access.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.RadioGroup.Keytip))]
  public String? Keytip
  {
    get => _Keytip ??= GetProperty<String?>(GetUpdatableElement()?.Keytip);
    set => UpdateField(ref _Keytip, value, nameof(Keytip));
  }
  private String? _Keytip;

  /// <summary>
  /// Specifies the callback that returns keytip.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.RadioGroup.GetKeytip))]
  public String? GetKeytip
  {
    get => _GetKeytip ??= GetProperty<String?>(GetUpdatableElement()?.GetKeytip);
    set => UpdateField(ref _GetKeytip, value, nameof(GetKeytip));
  }
  private String? _GetKeytip;

  /// <summary>
  /// Specifies the callback that returns selected item index.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.RadioGroup.GetSelectedItemIndex))]
  public String? GetSelectedItemIndex
  {
    get => _GetSelectedItemIndex ??= GetProperty<String?>(GetUpdatableElement()?.GetSelectedItemIndex);
    set => UpdateField(ref _GetSelectedItemIndex, value, nameof(GetSelectedItemIndex));
  }
  private String? _GetSelectedItemIndex;

  /// <summary>
  /// Specifies the callback that returns item count.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.RadioGroup.GetItemCount))]
  public String? GetItemCount
  {
    get => _GetItemCount ??= GetProperty<String?>(GetUpdatableElement()?.GetItemCount);
    set => UpdateField(ref _GetItemCount, value, nameof(GetItemCount));
  }
  private String? _GetItemCount;

  /// <summary>
  /// Specifies the callback that returns item label.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.RadioGroup.GetItemLabel))]
  public String? GetItemLabel
  {
    get => _GetItemLabel ??= GetProperty<String?>(GetUpdatableElement()?.GetItemLabel);
    set => UpdateField(ref _GetItemLabel, value, nameof(GetItemLabel));
  }
  private String? _GetItemLabel;

  /// <summary>
  /// Specifies the callback that returns item id.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.RadioGroup.GetItemID))]
  public String? GetItemID
  {
    get => _GetItemID ??= GetProperty<String?>(GetUpdatableElement()?.GetItemID);
    set => UpdateField(ref _GetItemID, value, nameof(GetItemID));
  }
  private String? _GetItemID;
}