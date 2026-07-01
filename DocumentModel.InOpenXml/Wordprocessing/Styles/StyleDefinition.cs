using BooleanConverter = DocumentModel.OpenXml.BooleanConverter;

namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a style definition in a Wordprocessing document.
/// This class provides properties for style type, identifiers, inheritance, UI settings, revision tracking, and formatting options, enabling advanced style management and customization for document content.
/// </summary>
[OpenXmlType(typeof(DXW.Style))]
[DataContract]
[XmlRoot("StyleDef", Namespace = "DocumentModel.Wordprocessing")]
public partial class StyleDefinition : ModelElement<DXW.Style>
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
  public string? NextParagraphStyle { get => _NextParagraphStyle; set => UpdateField(ref _NextParagraphStyle, value, nameof(NextParagraphStyle)); }
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
  [DefaultValue(false)]
  public Boolean? IsAutoRedefined { get => _IsAutoRedefined; set => UpdateField(ref _IsAutoRedefined, value, nameof(IsAutoRedefined)); }
  private Boolean? _IsAutoRedefined;

  /// <summary>
  /// Indicates whether the style is hidden in the user interface, preventing it from being displayed in style galleries or lists.
  /// </summary>
  [OpenXmlLoadData(nameof(LoadStyleHide))]
  [OpenXmlUpdateData(nameof(UpdateStyleHide))]
  public StyleHide? IsHidden { get => _IsHidden; set => UpdateField(ref _IsHidden, value, nameof(IsHidden)); }
  private StyleHide? _IsHidden;

  /// <summary>
  /// Loads the style visibility flags from the specified OpenXmlElement and updates the hidden state accordingly.
  /// </summary>
  /// <remarks>If the provided element is not a DXW.Style, this method does not modify the hidden state. The
  /// method interprets the StyleHidden, SemiHidden, and UnhideWhenUsed properties to determine the style's visibility
  /// flags.</remarks>
  /// <param name = "element">The OpenXmlElement representing a style from which to read visibility properties. Must be a DXW.Style element to
  /// have an effect.</param>
  public void LoadStyleHide(DX.OpenXmlElement element)
  {
    if (element is DXW.Style styleElement)
    {
      if (styleElement.StyleHidden == null)
      {
        IsHidden = null;
        return;
      }
      StyleHide isHidden = 0;
      if (styleElement.StyleHidden?.Val?.Value == DXW.OnOffOnlyValues.On)
        isHidden |= StyleHide.Hidden;
      else
        isHidden |= StyleHide.Hidden;
      if (styleElement.SemiHidden?.Val?.Value == DXW.OnOffOnlyValues.On)
        isHidden |= StyleHide.SemiHidden;
      if (styleElement.UnhideWhenUsed?.Val?.Value == DXW.OnOffOnlyValues.On)
        isHidden |= StyleHide.UnhiddenWhenUsed;
      IsHidden = isHidden;
    }
  }

  /// <summary>
  /// Updates the visibility-related style properties of the specified OpenXml style element based on the current style
  /// hide settings.  
  /// </summary>
  /// <remarks>This method modifies the StyleHidden, SemiHidden, and UnhideWhenUsed properties of the style
  /// element to reflect the current hide settings. No changes are made if the provided element is not a style
  /// element.</remarks>
  /// <param name = "element">The OpenXmlElement to update. Must be a style element to apply visibility changes; otherwise, no action is taken.</param>
  public void UpdateStyleHide(DX.OpenXmlElement element)
  {
    if (element is DXW.Style styleElement)
    {
      if (IsHidden == null)
      {
        styleElement.StyleHidden = null;
        styleElement.SemiHidden = null;
        styleElement.UnhideWhenUsed = null;
        return;
      }
      styleElement.StyleHidden = BooleanConverter.ConvertTo<DXW.StyleHidden>((IsHidden & StyleHide.Hidden) != 0);
      styleElement.SemiHidden = BooleanConverter.ConvertTo<DXW.SemiHidden>((IsHidden & StyleHide.SemiHidden) != 0);
      styleElement.UnhideWhenUsed = BooleanConverter.ConvertTo<DXW.UnhideWhenUsed>((IsHidden & StyleHide.UnhiddenWhenUsed) != 0);
    }
  }

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
  [DefaultValue(false)]
  public Boolean IsPrimary { get => _IsPrimary; set => UpdateField(ref _IsPrimary, value, nameof(IsPrimary)); }
  private Boolean _IsPrimary;

  /// <summary>
  /// Indicates whether the style cannot be applied.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Style.Locked))]
  [DefaultValue(false)]
  public Boolean IsLocked { get => _IsLocked; set => UpdateField(ref _IsLocked, value, nameof(IsLocked)); }
  private Boolean _IsLocked;

  /// <summary>
  /// Indicates whether the style is used for e-mail message text.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Style.Personal))]
  public Boolean IsPersonal { get => _IsPersonal; set => UpdateField(ref _IsPersonal, value, nameof(IsPersonal)); }

  [DefaultValue(false)]
  private Boolean _IsPersonal;

  /// <summary>
  /// Indicates whether the style is used for e-mail message composition.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Style.PersonalCompose))]
  [DefaultValue(false)]
  public Boolean IsPersonalCompose { get => _IsPersonalCompose; set => UpdateField(ref _IsPersonalCompose, value, nameof(IsPersonalCompose)); }
  private Boolean _IsPersonalCompose;

  /// <summary>
  /// Indicates whether the style is used for e-mail message replies.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Style.PersonalReply))]
  [DefaultValue(false)]
  public Boolean IsPersonalReply { get => _IsPersonalReply; set => UpdateField(ref _IsPersonalReply, value, nameof(IsPersonalReply)); }
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