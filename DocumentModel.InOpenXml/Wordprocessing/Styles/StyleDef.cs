namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a style definition in a Wordprocessing document.
/// This class provides properties for style type, identifiers, inheritance, UI settings, revision tracking, and formatting options, enabling advanced style management and customization for document content.
/// </summary>
[OpenXmlType(typeof(DXW.Style))]
public partial class StyleDef: ModelElement<DXW.Style>
{
  /// <summary>
  /// Style type, such as paragraph, character, table, or numbering.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Style.Type))]
  public StyleType? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

  private StyleType? _Type;

  /// <summary>
  /// Style identifier, used to uniquely identify the style in the document.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Style.StyleId))]
  public string? StyleId { get => _StyleId; set => UpdateField(ref _StyleId, value, nameof(StyleId)); }

  private string? _StyleId;

  /// <summary>
  /// Style name as displayed in the UI.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Style.StyleName))]
  public string? StyleName { get => _StyleName; set => UpdateField(ref _StyleName, value, nameof(StyleName)); }

  private string? _StyleName;

  /// <summary>
  /// Indicates whether the style is the default for its type.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Style.Default))]
  public bool? IsDefault { get => _IsDefault; set => UpdateField(ref _IsDefault, value, nameof(IsDefault)); }

  private bool? _IsDefault;

  /// <summary>
  /// Indicates whether the style is user-defined.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Style.CustomStyle))]
  public bool? IsCustom { get => _IsCustom; set => UpdateField(ref _IsCustom, value, nameof(IsCustom)); }

  private bool? _IsCustom;

  /// <summary>
  /// Parent style identifier, specifying the style on which this style is based.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Style.BasedOn))]
  public string? BasedOn { get => _BasedOn; set => UpdateField(ref _BasedOn, value, nameof(BasedOn)); }

  private string? _BasedOn;

  /// <summary>
  /// Style for the next paragraph, used for automatic style transitions.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Style.NextParagraphStyle))]
  public string? NextParagraphStyle
  {
    get => _NextParagraphStyle;
    set => UpdateField(ref _NextParagraphStyle, value, nameof(NextParagraphStyle));
  }

  private string? _NextParagraphStyle;

  /// <summary>
  /// Linked style reference, specifying a related style for linking purposes.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Style.LinkedStyle))]
  public string? LinkedStyle { get => _LinkedStyle; set => UpdateField(ref _LinkedStyle, value, nameof(LinkedStyle)); }

  private string? _LinkedStyle;

  /// <summary>
  /// Indicates whether user formatting is automatically merged into the style definition.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Style.AutoRedefine))]
  public Boolean IsAutoRedefined
  {
    get => _IsAutoRedefined;
    set => UpdateField(ref _IsAutoRedefined, value, nameof(IsAutoRedefined));
  }

  private Boolean _IsAutoRedefined;

  ///// <summary>
  ///// Indicates whether the style is hidden from the user class.
  ///// </summary>
  //[OpenXmlProperty(nameof(DXW.Style.))]
  //public Boolean IsHidden { get => _IsHidden; set => UpdateField(ref _IsHidden, value, nameof(IsHidden)); }

  //private Boolean _IsHidden;

  /// <summary>
  /// Indicates whether the style is hidden from the main user class.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Style.SemiHidden))]
  public Boolean IsSemiHidden
  {
    get => _IsSemiHidden;
    set => UpdateField(ref _IsSemiHidden, value, nameof(IsSemiHidden));
  }

  private Boolean _IsSemiHidden;

  /// <summary>
  /// Indicates whether the semi-hidden property is removed when the style is used.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Style.UnhideWhenUsed))]
  public Boolean IsUnhiddenWhenUsed
  {
    get => _IsUnhiddenWhenUsed;
    set => UpdateField(ref _IsUnhiddenWhenUsed, value, nameof(IsUnhiddenWhenUsed));
  }

  private Boolean _IsUnhiddenWhenUsed;

  /// <summary>
  /// Optional user interface sorting order, specifying the priority of the style in the UI.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Style.UIPriority))]
  public Int32? UIPriority { get => _UIPriority; set => UpdateField(ref _UIPriority, value, nameof(UIPriority)); }

  private Int32? _UIPriority;

  /// <summary>
  /// Indicates whether the style is a primary style.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Style.PrimaryStyle))]
  public Boolean IsPrimary { get => _IsPrimary; set => UpdateField(ref _IsPrimary, value, nameof(IsPrimary)); }

  private Boolean _IsPrimary;

  /// <summary>
  /// Indicates whether the style cannot be applied.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Style.Locked))]
  public Boolean IsLocked { get => _IsLocked; set => UpdateField(ref _IsLocked, value, nameof(IsLocked)); }

  private Boolean _IsLocked;

  /// <summary>
  /// Indicates whether the style is used for e-mail message text.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Style.Personal))]
  public Boolean IsPersonal { get => _IsPersonal; set => UpdateField(ref _IsPersonal, value, nameof(IsPersonal)); }

  private Boolean _IsPersonal;

  /// <summary>
  /// Indicates whether the style is used for e-mail message composition.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Style.PersonalCompose))]
  public Boolean IsPersonalCompose
  {
    get => _IsPersonalCompose;
    set => UpdateField(ref _IsPersonalCompose, value, nameof(IsPersonalCompose));
  }

  private Boolean _IsPersonalCompose;

  /// <summary>
  /// Indicates whether the style is used for e-mail message replies.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Style.PersonalReply))]
  public Boolean IsPersonalReply
  {
    get => _IsPersonalReply;
    set => UpdateField(ref _IsPersonalReply, value, nameof(IsPersonalReply));
  }

  private Boolean _IsPersonalReply;

  /// <summary>
  /// Revision identifier for the style definition, used for change tracking.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Style.Rsid))]
  public HexInt? Rsid { get => _Rsid; set => UpdateField(ref _Rsid, value, nameof(Rsid)); }

  private HexInt? _Rsid;

  ///// <summary>
  ///// Style paragraph properties, specifying formatting for paragraphs in the style.
  ///// </summary>
  //public StyleParagraphProperties? StyleParagraphProperties
  //{
  //  get => _StyleParagraphProperties;
  //  set => UpdateField(ref _StyleParagraphProperties, value, nameof(StyleParagraphProperties));
  //}

  //private StyleParagraphProperties? _StyleParagraphProperties;

  ///// <summary>
  ///// Run properties, specifying formatting for text runs in the style.
  ///// </summary>
  //public StyleRunProperties? StyleRunProperties
  //{
  //  get => _StyleRunProperties;
  //  set => UpdateField(ref _StyleRunProperties, value, nameof(StyleRunProperties));
  //}

  //private StyleRunProperties? _StyleRunProperties;

  ///// <summary>
  ///// Style table properties, specifying formatting for tables in the style.
  ///// </summary>
  //public StyleTableProperties? StyleTableProperties
  //{
  //  get => _StyleTableProperties;
  //  set => UpdateField(ref _StyleTableProperties, value, nameof(StyleTableProperties));
  //}

  //private StyleTableProperties? _StyleTableProperties;

  ///// <summary>
  ///// Style table row properties, specifying formatting for table rows in the style.
  ///// </summary>
  //public TableStyleConditionalRowProperties? TableStyleConditionalFormattingTableRowProperties
  //{
  //  get => _TableStyleConditionalFormattingTableRowProperties;
  //  set => UpdateField(ref _TableStyleConditionalFormattingTableRowProperties, value,
  //    nameof(TableStyleConditionalFormattingTableRowProperties));
  //}

  //private TableStyleConditionalRowProperties? _TableStyleConditionalFormattingTableRowProperties;

  ///// <summary>
  ///// Style table cell properties, specifying formatting for table cells in the style.
  ///// </summary>
  //public StyleTableCellProperties? StyleTableCellProperties
  //{
  //  get => _StyleTableCellProperties;
  //  set => UpdateField(ref _StyleTableCellProperties, value, nameof(StyleTableCellProperties));
  //}

  //private StyleTableCellProperties? _StyleTableCellProperties;

  ///// <summary>
  ///// Table style properties, specifying conditional formatting for tables in the style.
  ///// </summary>
  //public TableStyleConditionalProperties? TableStyleConditionalProperties
  //{
  //  get => _TableStyleConditionalProperties;
  //  set => UpdateField(ref _TableStyleConditionalProperties, value, nameof(TableStyleConditionalProperties));
  //}

  //private TableStyleConditionalProperties? _TableStyleConditionalProperties;
}