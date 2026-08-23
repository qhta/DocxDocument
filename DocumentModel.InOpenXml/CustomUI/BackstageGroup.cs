namespace DocumentModel.CustomUI;

/// <summary>
/// <para>Defines the BackstageGroup Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:group.</para>
/// </summary>
/// <remark>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls"/> <c>&lt;mso14:topItems&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.BottomItemsGroupControls"/> <c>&lt;mso14:bottomItems&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.PrimaryItem"/> <c>&lt;mso14:primaryItem&gt;</c></description></item>
/// </list>
/// </remark>
[OpenXmlType(typeof(DXO10CUI.BackstageGroup))]
[DataContract]
[XmlRoot("BackstageGroup", Namespace = "DocumentModel.CustomUI")]
public partial class BackstageGroup : ModelElement<DXO10CUI.BackstageGroup>
{
  /// <summary>
  /// Specifies the unique identifier of the group.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageGroup.Id))]
  public String? Id
  {
    get => _Id ??= GetProperty<String?>(GetUpdatableElement()?.Id);
    set => UpdateField(ref _Id, value, nameof(Id));
  }
  private String? _Id;

  /// <summary>
  /// Specifies the qualified identifier of the group.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageGroup.QualifiedId))]
  public String? QualifiedId
  {
    get => _QualifiedId ??= GetProperty<String?>(GetUpdatableElement()?.QualifiedId);
    set => UpdateField(ref _QualifiedId, value, nameof(QualifiedId));
  }
  private String? _QualifiedId;

  /// <summary>
  /// Specifies an application-defined tag for the group.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageGroup.Tag))]
  public String? Tag
  {
    get => _Tag ??= GetProperty<String?>(GetUpdatableElement()?.Tag);
    set => UpdateField(ref _Tag, value, nameof(Tag));
  }
  private String? _Tag;

  /// <summary>
  /// Specifies the identifier of a built-in Office control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageGroup.IdMso))]
  public String? IdMso
  {
    get => _IdMso ??= GetProperty<String?>(GetUpdatableElement()?.IdMso);
    set => UpdateField(ref _IdMso, value, nameof(IdMso));
  }
  private String? _IdMso;

  /// <summary>
  /// Specifies a built-in control after which this group is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageGroup.InsertAfterMso))]
  public String? InsertAfterMso
  {
    get => _InsertAfterMso ??= GetProperty<String?>(GetUpdatableElement()?.InsertAfterMso);
    set => UpdateField(ref _InsertAfterMso, value, nameof(InsertAfterMso));
  }
  private String? _InsertAfterMso;

  /// <summary>
  /// Specifies a built-in control before which this group is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageGroup.InsertBeforeMso))]
  public String? InsertBeforeMso
  {
    get => _InsertBeforeMso ??= GetProperty<String?>(GetUpdatableElement()?.InsertBeforeMso);
    set => UpdateField(ref _InsertBeforeMso, value, nameof(InsertBeforeMso));
  }
  private String? _InsertBeforeMso;

  /// <summary>
  /// Specifies a qualified control identifier after which this group is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageGroup.InsertAfterQulifiedId))]
  public String? InsertAfterQualifiedId
  {
    get => _InsertAfterQualifiedId ??= GetProperty<String?>(GetUpdatableElement()?.InsertAfterQulifiedId);
    set => UpdateField(ref _InsertAfterQualifiedId, value, nameof(InsertAfterQualifiedId));
  }
  private String? _InsertAfterQualifiedId;

  /// <summary>
  /// Specifies a qualified control identifier before which this group is inserted.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageGroup.InsertBeforeQulifiedId))]
  public String? InsertBeforeQualifiedId
  {
    get => _InsertBeforeQualifiedId ??= GetProperty<String?>(GetUpdatableElement()?.InsertBeforeQulifiedId);
    set => UpdateField(ref _InsertBeforeQualifiedId, value, nameof(InsertBeforeQualifiedId));
  }
  private String? _InsertBeforeQualifiedId;

  /// <summary>
  /// Specifies the display label of the group.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageGroup.Label))]
  public String? Label
  {
    get => _Label ??= GetProperty<String?>(GetUpdatableElement()?.Label);
    set => UpdateField(ref _Label, value, nameof(Label));
  }
  private String? _Label;

  /// <summary>
  /// Specifies the callback that returns the group label.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageGroup.GetLabel))]
  public String? GetLabel
  {
    get => _GetLabel ??= GetProperty<String?>(GetUpdatableElement()?.GetLabel);
    set => UpdateField(ref _GetLabel, value, nameof(GetLabel));
  }
  private String? _GetLabel;

  /// <summary>
  /// Specifies whether the group is visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageGroup.Visible))]
  public Boolean? Visible
  {
    get => _Visible ??= GetProperty<Boolean?>(GetUpdatableElement()?.Visible);
    set => UpdateField(ref _Visible, value, nameof(Visible));
  }
  private Boolean? _Visible;

  /// <summary>
  /// Specifies the callback that returns whether the group is visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageGroup.GetVisible))]
  public String? GetVisible
  {
    get => _GetVisible ??= GetProperty<String?>(GetUpdatableElement()?.GetVisible);
    set => UpdateField(ref _GetVisible, value, nameof(GetVisible));
  }
  private String? _GetVisible;

  /// <summary>
  /// Specifies the visual style applied to the group.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageGroup.Style))]
  public Style? Style
  {
    get => _Style ??= GetProperty<Style?>(GetUpdatableElement()?.Style);
    set => UpdateField(ref _Style, value, nameof(Style));
  }
  private Style? _Style;

  /// <summary>
  /// Specifies the callback that returns the group style.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageGroup.GetStyle))]
  public String? GetStyle
  {
    get => _GetStyle ??= GetProperty<String?>(GetUpdatableElement()?.GetStyle);
    set => UpdateField(ref _GetStyle, value, nameof(GetStyle));
  }
  private String? _GetStyle;

  /// <summary>
  /// Specifies helper text associated with the group.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageGroup.HelperText))]
  public String? HelperText
  {
    get => _HelperText ??= GetProperty<String?>(GetUpdatableElement()?.HelperText);
    set => UpdateField(ref _HelperText, value, nameof(HelperText));
  }
  private String? _HelperText;

  /// <summary>
  /// Specifies the callback that returns helper text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageGroup.GetHelperText))]
  public String? GetHelperText
  {
    get => _GetHelperText ??= GetProperty<String?>(GetUpdatableElement()?.GetHelperText);
    set => UpdateField(ref _GetHelperText, value, nameof(GetHelperText));
  }
  private String? _GetHelperText;

  /// <summary>
  /// Specifies whether the group label is shown.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageGroup.ShowLabel))]
  public Boolean? ShowLabel
  {
    get => _ShowLabel ??= GetProperty<Boolean?>(GetUpdatableElement()?.ShowLabel);
    set => UpdateField(ref _ShowLabel, value, nameof(ShowLabel));
  }
  private Boolean? _ShowLabel;

  /// <summary>
  /// Specifies the callback that returns whether the label is shown.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageGroup.GetShowLabel))]
  public String? GetShowLabel
  {
    get => _GetShowLabel ??= GetProperty<String?>(GetUpdatableElement()?.GetShowLabel);
    set => UpdateField(ref _GetShowLabel, value, nameof(GetShowLabel));
  }
  private String? _GetShowLabel;
}