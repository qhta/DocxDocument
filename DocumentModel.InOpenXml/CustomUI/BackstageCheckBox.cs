namespace DocumentModel.CustomUI;

/// <summary>
/// <para>Defines the BackstageCheckBox Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:checkBox.</para>
/// </summary>
[OpenXmlType(typeof(DXO10CUI.BackstageCheckBox))]
public class BackstageCheckBox: ModelElement<DXO10CUI.BackstageCheckBox>
{
  /// <summary>
  /// Specifies the layout expansion position for the checkbox control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageCheckBox.Expand))]
  public Expand? Expand { get => _Expand; set => UpdateField(ref _Expand, value, nameof(Expand)); }

  private Expand? _Expand;

  /// <summary>
  /// Specifies the descriptive text associated with the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageCheckBox.Description))]
  public String? Description { get => _Description; set => UpdateField(ref _Description, value, nameof(Description)); }

  private String? _Description;

  /// <summary>
  /// Specifies the callback that returns the control description at runtime.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageCheckBox.GetDescription))]
  public String? GetDescription
  {
    get => _GetDescription;
    set => UpdateField(ref _GetDescription, value, nameof(GetDescription));
  }

  private String? _GetDescription;

  /// <summary>
  /// Specifies the short screen tip text for the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageCheckBox.Screentip))]
  public String? Screentip { get => _Screentip; set => UpdateField(ref _Screentip, value, nameof(Screentip)); }

  private String? _Screentip;

  /// <summary>
  /// Specifies the callback that returns the screen tip text at runtime.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageCheckBox.GetScreentip))]
  public String? GetScreentip
  {
    get => _GetScreentip;
    set => UpdateField(ref _GetScreentip, value, nameof(GetScreentip));
  }

  private String? _GetScreentip;

  /// <summary>
  /// Specifies the extended super tip text for the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageCheckBox.Supertip))]
  public String? Supertip { get => _Supertip; set => UpdateField(ref _Supertip, value, nameof(Supertip)); }

  private String? _Supertip;

  /// <summary>
  /// Specifies the callback that returns the super tip text at runtime.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageCheckBox.GetSupertip))]
  public String? GetSupertip { get => _GetSupertip; set => UpdateField(ref _GetSupertip, value, nameof(GetSupertip)); }

  private String? _GetSupertip;

  /// <summary>
  /// Specifies the unique identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageCheckBox.Id))]
  public String? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

  private String? _Id;

  /// <summary>
  /// Specifies the qualified identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageCheckBox.QualifiedId))]
  public String? QualifiedId { get => _QualifiedId; set => UpdateField(ref _QualifiedId, value, nameof(QualifiedId)); }

  private String? _QualifiedId;

  /// <summary>
  /// Specifies an application-defined tag for the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageCheckBox.Tag))]
  public String? Tag { get => _Tag; set => UpdateField(ref _Tag, value, nameof(Tag)); }

  private String? _Tag;

  /// <summary>
  /// Specifies the callback invoked when the control action occurs.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageCheckBox.OnAction))]
  public String? OnAction { get => _OnAction; set => UpdateField(ref _OnAction, value, nameof(OnAction)); }

  private String? _OnAction;

  /// <summary>
  /// Specifies the callback that returns the pressed state at runtime.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageCheckBox.GetPressed))]
  public String? GetPressed { get => _GetPressed; set => UpdateField(ref _GetPressed, value, nameof(GetPressed)); }

  private String? _GetPressed;

  /// <summary>
  /// Specifies whether the control is enabled.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageCheckBox.Enabled))]
  public Boolean? Enabled { get => _Enabled; set => UpdateField(ref _Enabled, value, nameof(Enabled)); }

  private Boolean? _Enabled;

  /// <summary>
  /// Specifies the callback that returns whether the control is enabled.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageCheckBox.GetEnabled))]
  public String? GetEnabled { get => _GetEnabled; set => UpdateField(ref _GetEnabled, value, nameof(GetEnabled)); }

  private String? _GetEnabled;

  /// <summary>
  /// Specifies the display label of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageCheckBox.Label))]
  public String? Label { get => _Label; set => UpdateField(ref _Label, value, nameof(Label)); }

  private String? _Label;

  /// <summary>
  /// Specifies the callback that returns the control label at runtime.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageCheckBox.GetLabel))]
  public String? GetLabel { get => _GetLabel; set => UpdateField(ref _GetLabel, value, nameof(GetLabel)); }

  private String? _GetLabel;

  /// <summary>
  /// Specifies whether the control is visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageCheckBox.Visible))]
  public Boolean? Visible { get => _Visible; set => UpdateField(ref _Visible, value, nameof(Visible)); }

  private Boolean? _Visible;

  /// <summary>
  /// Specifies the callback that returns whether the control is visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageCheckBox.GetVisible))]
  public String? GetVisible { get => _GetVisible; set => UpdateField(ref _GetVisible, value, nameof(GetVisible)); }

  private String? _GetVisible;

  /// <summary>
  /// Specifies the keyboard tip shown for quick access.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageCheckBox.Keytip))]
  public String? Keytip { get => _Keytip; set => UpdateField(ref _Keytip, value, nameof(Keytip)); }

  private String? _Keytip;

  /// <summary>
  /// Specifies the callback that returns the keyboard tip at runtime.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageCheckBox.GetKeytip))]
  public String? GetKeytip { get => _GetKeytip; set => UpdateField(ref _GetKeytip, value, nameof(GetKeytip)); }

  private String? _GetKeytip;
}