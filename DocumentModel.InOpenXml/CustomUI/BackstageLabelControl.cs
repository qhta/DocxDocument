namespace DocumentModel.CustomUI;
/// <summary>
/// <para>Defines the BackstageLabelControl Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:labelControl.</para>
/// </summary>
[OpenXmlType(typeof(DXO10CUI.BackstageLabelControl))]
[DataContract]
[XmlRoot("BackstageLabelControl", Namespace = "DocumentModel.CustomUI")]
public partial class BackstageLabelControl : ModelElement<DXO10CUI.BackstageLabelControl>
{
  /// <summary>
  /// Specifies the unique identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageLabelControl.Id))]
  public String? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }
  private String? _Id;

  /// <summary>
  /// Specifies the qualified identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageLabelControl.QualifiedId))]
  public String? QualifiedId { get => _QualifiedId; set => UpdateField(ref _QualifiedId, value, nameof(QualifiedId)); }
  private String? _QualifiedId;

  /// <summary>
  /// Specifies an application-defined tag for the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageLabelControl.Tag))]
  public String? Tag { get => _Tag; set => UpdateField(ref _Tag, value, nameof(Tag)); }
  private String? _Tag;

  /// <summary>
  /// Specifies the alignment of the control label.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageLabelControl.AlignLabel))]
  public Expand? AlignLabel { get => _AlignLabel; set => UpdateField(ref _AlignLabel, value, nameof(AlignLabel)); }
  private Expand? _AlignLabel;

  /// <summary>
  /// Specifies the expansion position in the Backstage layout.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageLabelControl.Expand))]
  public Expand? Expand { get => _Expand; set => UpdateField(ref _Expand, value, nameof(Expand)); }
  private Expand? _Expand;

  /// <summary>
  /// Specifies whether the control is enabled.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageLabelControl.Enabled))]
  public Boolean? Enabled { get => _Enabled; set => UpdateField(ref _Enabled, value, nameof(Enabled)); }
  private Boolean? _Enabled;

  /// <summary>
  /// Specifies the callback that returns whether the control is enabled.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageLabelControl.GetEnabled))]
  public String? GetEnabled { get => _GetEnabled; set => UpdateField(ref _GetEnabled, value, nameof(GetEnabled)); }
  private String? _GetEnabled;

  /// <summary>
  /// Specifies the display label of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageLabelControl.Label))]
  public String? Label { get => _Label; set => UpdateField(ref _Label, value, nameof(Label)); }
  private String? _Label;

  /// <summary>
  /// Specifies the callback that returns the control label.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageLabelControl.GetLabel))]
  public String? GetLabel { get => _GetLabel; set => UpdateField(ref _GetLabel, value, nameof(GetLabel)); }
  private String? _GetLabel;

  /// <summary>
  /// Specifies whether the control is visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageLabelControl.Visible))]
  public Boolean? Visible { get => _Visible; set => UpdateField(ref _Visible, value, nameof(Visible)); }
  private Boolean? _Visible;

  /// <summary>
  /// Specifies the callback that returns whether the control is visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageLabelControl.GetVisible))]
  public String? GetVisible { get => _GetVisible; set => UpdateField(ref _GetVisible, value, nameof(GetVisible)); }
  private String? _GetVisible;

  /// <summary>
  /// Specifies whether the control label can wrap.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageLabelControl.NoWrap))]
  public Boolean? NoWrap { get => _NoWrap; set => UpdateField(ref _NoWrap, value, nameof(NoWrap)); }
  private Boolean? _NoWrap;
}