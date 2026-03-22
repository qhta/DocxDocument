namespace DocumentModel.CustomUI;
/// <summary>
/// <para>Defines the BackstageEditBox Class.</para>
/// <para>This class is available in Office 2010 and above.</para>
/// <para>When the object is serialized out as xml, it's qualified name is mso14:editBox.</para>
/// </summary>
[OpenXmlType(typeof(DXO10CUI.BackstageEditBox))]
public class BackstageEditBox: ModelElement<DXO10CUI.BackstageEditBox>
{
  /// <summary>
  /// Specifies the unique identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageEditBox.Id))]
  public String? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }
  private String? _Id;
  /// <summary>
  /// Specifies the qualified identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageEditBox.QualifiedId))]
  public String? QualifiedId { get => _QualifiedId; set => UpdateField(ref _QualifiedId, value, nameof(QualifiedId)); }
  private String? _QualifiedId;
  /// <summary>
  /// Specifies an application-defined tag for the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageEditBox.Tag))]
  public String? Tag { get => _Tag; set => UpdateField(ref _Tag, value, nameof(Tag)); }
  private String? _Tag;
  /// <summary>
  /// Specifies the alignment of the control label.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageEditBox.AlignLabel))]
  public Expand? AlignLabel { get => _AlignLabel; set => UpdateField(ref _AlignLabel, value, nameof(AlignLabel)); }
  private Expand? _AlignLabel;
  /// <summary>
  /// Specifies the expansion position in the Backstage layout.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageEditBox.Expand))]
  public Expand? Expand { get => _Expand; set => UpdateField(ref _Expand, value, nameof(Expand)); }
  private Expand? _Expand;
  /// <summary>
  /// Specifies whether the control is enabled.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageEditBox.Enabled))]
  public Boolean? Enabled { get => _Enabled; set => UpdateField(ref _Enabled, value, nameof(Enabled)); }
  private Boolean? _Enabled;
  /// <summary>
  /// Specifies the callback that returns whether the control is enabled.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageEditBox.GetEnabled))]
  public String? GetEnabled { get => _GetEnabled; set => UpdateField(ref _GetEnabled, value, nameof(GetEnabled)); }
  private String? _GetEnabled;
  /// <summary>
  /// Specifies the display label of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageEditBox.Label))]
  public String? Label { get => _Label; set => UpdateField(ref _Label, value, nameof(Label)); }
  private String? _Label;
  /// <summary>
  /// Specifies the callback that returns the control label.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageEditBox.GetLabel))]
  public String? GetLabel { get => _GetLabel; set => UpdateField(ref _GetLabel, value, nameof(GetLabel)); }
  private String? _GetLabel;
  /// <summary>
  /// Specifies whether the control is visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageEditBox.Visible))]
  public Boolean? Visible { get => _Visible; set => UpdateField(ref _Visible, value, nameof(Visible)); }
  private Boolean? _Visible;
  /// <summary>
  /// Specifies the callback that returns whether the control is visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageEditBox.GetVisible))]
  public String? GetVisible { get => _GetVisible; set => UpdateField(ref _GetVisible, value, nameof(GetVisible)); }
  private String? _GetVisible;
  /// <summary>
  /// Specifies the keyboard tip shown for quick access.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageEditBox.Keytip))]
  public String? Keytip { get => _Keytip; set => UpdateField(ref _Keytip, value, nameof(Keytip)); }
  private String? _Keytip;
  /// <summary>
  /// Specifies the callback that returns the keyboard tip.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageEditBox.GetKeytip))]
  public String? GetKeytip { get => _GetKeytip; set => UpdateField(ref _GetKeytip, value, nameof(GetKeytip)); }
  private String? _GetKeytip;
  /// <summary>
  /// Specifies the callback that returns the current text value.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageEditBox.GetText))]
  public String? GetText { get => _GetText; set => UpdateField(ref _GetText, value, nameof(GetText)); }
  private String? _GetText;
  /// <summary>
  /// Specifies the callback invoked when the text value changes.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageEditBox.OnChange))]
  public String? OnChange { get => _OnChange; set => UpdateField(ref _OnChange, value, nameof(OnChange)); }
  private String? _OnChange;
  /// <summary>
  /// Specifies the maximum number of characters allowed in the text value.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageEditBox.MaxLength))]
  public int? MaxLength { get => _MaxLength; set => UpdateField(ref _MaxLength, value, nameof(MaxLength)); }
  private int? _MaxLength;
  /// <summary>
  /// Specifies sample text used to size the edit box.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageEditBox.SizeString))]
  public String? SizeString { get => _SizeString; set => UpdateField(ref _SizeString, value, nameof(SizeString)); }
  private String? _SizeString;
}