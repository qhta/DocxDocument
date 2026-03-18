namespace DocumentModel.CustomUI;

/// <summary>
/// <para>Defines the TaskFormGroup Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:taskFormGroup.</para>
/// </summary>
/// <remark>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroupCategory"/> <c>&lt;mso14:category&gt;</c></description></item>
/// </list>
/// </remark>
[OpenXmlType(typeof(DXO10CUI.TaskFormGroup))]
public class TaskFormGroup: ModelElement<DXO10CUI.TaskFormGroup>
{
  /// <summary>
  /// Specifies the unique identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.TaskFormGroup.Id))]
  public String? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

  private String? _Id;

  /// <summary>
  /// Specifies the qualified identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.TaskFormGroup.QualifiedId))]
  public String? QualifiedId { get => _QualifiedId; set => UpdateField(ref _QualifiedId, value, nameof(QualifiedId)); }

  private String? _QualifiedId;

  /// <summary>
  /// Specifies an application-defined tag for the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.TaskFormGroup.Tag))]
  public String? Tag { get => _Tag; set => UpdateField(ref _Tag, value, nameof(Tag)); }

  private String? _Tag;

  /// <summary>
  /// Specifies the identifier of a built-in Office control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.TaskFormGroup.IdMso))]
  public String? IdMso { get => _IdMso; set => UpdateField(ref _IdMso, value, nameof(IdMso)); }

  private String? _IdMso;

  /// <summary>
  /// Specifies the display label of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.TaskFormGroup.Label))]
  public String? Label { get => _Label; set => UpdateField(ref _Label, value, nameof(Label)); }

  private String? _Label;

  /// <summary>
  /// Specifies the callback that returns label.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.TaskFormGroup.GetLabel))]
  public String? GetLabel { get => _GetLabel; set => UpdateField(ref _GetLabel, value, nameof(GetLabel)); }

  private String? _GetLabel;

  /// <summary>
  /// Specifies whether the control is visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.TaskFormGroup.Visible))]
  public Boolean? Visible { get => _Visible; set => UpdateField(ref _Visible, value, nameof(Visible)); }

  private Boolean? _Visible;

  /// <summary>
  /// Specifies the callback that returns visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.TaskFormGroup.GetVisible))]
  public String? GetVisible { get => _GetVisible; set => UpdateField(ref _GetVisible, value, nameof(GetVisible)); }

  private String? _GetVisible;

  /// <summary>
  /// Specifies the helper text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.TaskFormGroup.HelperText))]
  public String? HelperText { get => _HelperText; set => UpdateField(ref _HelperText, value, nameof(HelperText)); }

  private String? _HelperText;

  /// <summary>
  /// Specifies the callback that returns helper text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.TaskFormGroup.GetHelperText))]
  public String? GetHelperText
  {
    get => _GetHelperText;
    set => UpdateField(ref _GetHelperText, value, nameof(GetHelperText));
  }

  private String? _GetHelperText;

  /// <summary>
  /// Specifies whether the label is shown.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.TaskFormGroup.ShowLabel))]
  public Boolean? ShowLabel { get => _ShowLabel; set => UpdateField(ref _ShowLabel, value, nameof(ShowLabel)); }

  private Boolean? _ShowLabel;

  /// <summary>
  /// Specifies the callback that returns show label.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.TaskFormGroup.GetShowLabel))]
  public String? GetShowLabel
  {
    get => _GetShowLabel;
    set => UpdateField(ref _GetShowLabel, value, nameof(GetShowLabel));
  }

  private String? _GetShowLabel;

  /// <summary>
  /// Specifies the allowed task sizes.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.TaskFormGroup.AllowedTaskSizes))]
  public TaskSizesType? AllowedTaskSizes
  {
    get => _AllowedTaskSizes;
    set => UpdateField(ref _AllowedTaskSizes, value, nameof(AllowedTaskSizes));
  }

  private TaskSizesType? _AllowedTaskSizes;
}