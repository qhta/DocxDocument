namespace DocumentModel.CustomUI;
/// <summary>
///   Defines the BackstageDropDown Class.
/// </summary>
[OpenXmlType(typeof(DXO10CUI.BackstageDropDown))]
[XmlRoot("BackstageDropDown", Namespace = "DocumentModel.CustomUI")]
public partial class BackstageDropDown : ModelElement<DXO10CUI.BackstageDropDown>
{
  /// <summary>
  /// Specifies the unique identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageDropDown.Id))]
  public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }
  private string? _Id;

  /// <summary>
  /// Specifies the qualified identifier of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageDropDown.QualifiedId))]
  public string? QualifiedId { get => _QualifiedId; set => UpdateField(ref _QualifiedId, value, nameof(QualifiedId)); }
  private string? _QualifiedId;

  /// <summary>
  /// Specifies an application-defined tag for the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageDropDown.Tag))]
  public string? Tag { get => _Tag; set => UpdateField(ref _Tag, value, nameof(Tag)); }
  private string? _Tag;

  /// <summary>
  /// Specifies the alignment of the control label.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageDropDown.AlignLabel))]
  public Expand? AlignLabel { get => _AlignLabel; set => UpdateField(ref _AlignLabel, value, nameof(AlignLabel)); }
  private Expand? _AlignLabel;

  /// <summary>
  /// Specifies the expansion position in the Backstage layout.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageDropDown.Expand))]
  public Expand? Expand { get => _Expand; set => UpdateField(ref _Expand, value, nameof(Expand)); }
  private Expand? _Expand;

  /// <summary>
  /// Specifies whether the control is enabled.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageDropDown.Enabled))]
  public bool? Enabled { get => _Enabled; set => UpdateField(ref _Enabled, value, nameof(Enabled)); }
  private bool? _Enabled;

  /// <summary>
  /// Specifies the callback that returns whether the control is enabled.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageDropDown.GetEnabled))]
  public string? GetEnabled { get => _GetEnabled; set => UpdateField(ref _GetEnabled, value, nameof(GetEnabled)); }
  private string? _GetEnabled;

  /// <summary>
  /// Specifies the display label of the control.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageDropDown.Label))]
  public string? Label { get => _Label; set => UpdateField(ref _Label, value, nameof(Label)); }
  private string? _Label;

  /// <summary>
  /// Specifies the callback that returns the control label.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageDropDown.GetLabel))]
  public string? GetLabel { get => _GetLabel; set => UpdateField(ref _GetLabel, value, nameof(GetLabel)); }
  private string? _GetLabel;

  /// <summary>
  /// Specifies whether the control is visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageDropDown.Visible))]
  public bool? Visible { get => _Visible; set => UpdateField(ref _Visible, value, nameof(Visible)); }
  private bool? _Visible;

  /// <summary>
  /// Specifies the callback that returns whether the control is visible.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageDropDown.GetVisible))]
  public string? GetVisible { get => _GetVisible; set => UpdateField(ref _GetVisible, value, nameof(GetVisible)); }
  private string? _GetVisible;

  /// <summary>
  /// Specifies the callback invoked when the control action occurs.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageDropDown.OnAction))]
  public string? OnAction { get => _OnAction; set => UpdateField(ref _OnAction, value, nameof(OnAction)); }
  private string? _OnAction;

  /// <summary>
  /// Specifies the short screen tip text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageDropDown.Screentip))]
  public string? Screentip { get => _Screentip; set => UpdateField(ref _Screentip, value, nameof(Screentip)); }
  private string? _Screentip;

  /// <summary>
  /// Specifies the callback that returns screen tip text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageDropDown.GetScreentip))]
  public string? GetScreentip { get => _GetScreentip; set => UpdateField(ref _GetScreentip, value, nameof(GetScreentip)); }
  private string? _GetScreentip;

  /// <summary>
  /// Specifies the extended super tip text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageDropDown.Supertip))]
  public string? Supertip { get => _Supertip; set => UpdateField(ref _Supertip, value, nameof(Supertip)); }
  private string? _Supertip;

  /// <summary>
  /// Specifies the callback that returns super tip text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageDropDown.GetSupertip))]
  public string? GetSupertip { get => _GetSupertip; set => UpdateField(ref _GetSupertip, value, nameof(GetSupertip)); }
  private string? _GetSupertip;

  /// <summary>
  /// Specifies the keyboard tip shown for quick access.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageDropDown.Keytip))]
  public string? Keytip { get => _Keytip; set => UpdateField(ref _Keytip, value, nameof(Keytip)); }
  private string? _Keytip;

  /// <summary>
  /// Specifies the callback that returns the keyboard tip.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageDropDown.GetKeytip))]
  public string? GetKeytip { get => _GetKeytip; set => UpdateField(ref _GetKeytip, value, nameof(GetKeytip)); }
  private string? _GetKeytip;

  /// <summary>
  /// Specifies the callback that returns the selected item index.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageDropDown.GetSelectedItemIndex))]
  public string? GetSelectedItemIndex { get => _GetSelectedItemIndex; set => UpdateField(ref _GetSelectedItemIndex, value, nameof(GetSelectedItemIndex)); }
  private string? _GetSelectedItemIndex;

  /// <summary>
  /// Specifies sample text used to size the dropdown.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageDropDown.SizeString))]
  public string? SizeString { get => _SizeString; set => UpdateField(ref _SizeString, value, nameof(SizeString)); }
  private string? _SizeString;

  /// <summary>
  /// Specifies the callback that returns the number of items.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageDropDown.GetItemCount))]
  public string? GetItemCount { get => _GetItemCount; set => UpdateField(ref _GetItemCount, value, nameof(GetItemCount)); }
  private string? _GetItemCount;

  /// <summary>
  /// Specifies the callback that returns an item label by index.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageDropDown.GetItemLabel))]
  public string? GetItemLabel { get => _GetItemLabel; set => UpdateField(ref _GetItemLabel, value, nameof(GetItemLabel)); }
  private string? _GetItemLabel;

  /// <summary>
  /// Specifies the callback that returns an item identifier by index.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10CUI.BackstageDropDown.GetItemID))]
  public string? GetItemID { get => _GetItemID; set => UpdateField(ref _GetItemID, value, nameof(GetItemID)); }
  private string? _GetItemID;

  /// <summary>
  /// Specifies the collection of static dropdown items.
  /// </summary>
  public Collection<BackstageItemType>? ItemBackstageItems { get => _ItemBackstageItems; set => UpdateField(ref _ItemBackstageItems, value, nameof(ItemBackstageItems)); }
  private Collection<BackstageItemType>? _ItemBackstageItems;
}