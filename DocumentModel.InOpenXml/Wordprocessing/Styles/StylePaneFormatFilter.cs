namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents suggested filtering options for the list of document styles in a Wordprocessing document.
/// This class provides properties for filtering by style type, usage, visibility, formatting, and alternate names, enabling advanced style pane customization and management.
/// </summary>
[OpenXmlType(typeof(DXW.StylePaneFormatFilter))]
[DataContract]
[XmlRoot("StylePaneFormatFilter", Namespace = "DocumentModel.Wordprocessing")]
public partial class StylePaneFormatFilter : ModelElement<DXW.StylePaneFormatFilter>
{
 /// <summary>
 /// Hexadecimal value representing the style pane format filter settings.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.StylePaneFormatFilter.Val))]
 public HexChar? Val { get => _Val; set => UpdateField(ref _Val, value, nameof(Val)); }
 private HexChar? _Val;

 /// <summary>
 /// Indicates whether all styles are included in the filter.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.StylePaneFormatFilter.AllStyles))]
 public bool? AllStyles { get => _AllStyles; set => UpdateField(ref _AllStyles, value, nameof(AllStyles)); }
 private bool? _AllStyles;

 /// <summary>
 /// Indicates whether only custom styles are included in the filter.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.StylePaneFormatFilter.CustomStyles))]
 public bool? CustomStyles { get => _CustomStyles; set => UpdateField(ref _CustomStyles, value, nameof(CustomStyles)); }
 private bool? _CustomStyles;

 /// <summary>
 /// Indicates whether latent styles are included in the filter.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.StylePaneFormatFilter.LatentStyles))]
 public bool? LatentStyles { get => _LatentStyles; set => UpdateField(ref _LatentStyles, value, nameof(LatentStyles)); }
 private bool? _LatentStyles;

 /// <summary>
 /// Indicates whether only styles currently in use are included in the filter.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.StylePaneFormatFilter.StylesInUse))]
 public bool? StylesInUse { get => _StylesInUse; set => UpdateField(ref _StylesInUse, value, nameof(StylesInUse)); }
 private bool? _StylesInUse;

 /// <summary>
 /// Indicates whether heading styles are included in the filter.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.StylePaneFormatFilter.HeadingStyles))]
 public bool? HeadingStyles { get => _HeadingStyles; set => UpdateField(ref _HeadingStyles, value, nameof(HeadingStyles)); }
 private bool? _HeadingStyles;

 /// <summary>
 /// Indicates whether numbering styles are included in the filter.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.StylePaneFormatFilter.NumberingStyles))]
 public bool? NumberingStyles { get => _NumberingStyles; set => UpdateField(ref _NumberingStyles, value, nameof(NumberingStyles)); }
 private bool? _NumberingStyles;

 /// <summary>
 /// Indicates whether table styles are included in the filter.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.StylePaneFormatFilter.TableStyles))]
 public bool? TableStyles { get => _TableStyles; set => UpdateField(ref _TableStyles, value, nameof(TableStyles)); }
 private bool? _TableStyles;

 /// <summary>
 /// Indicates whether direct formatting on runs is included in the filter.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.StylePaneFormatFilter.DirectFormattingOnRuns))]
 public bool? DirectFormattingOnRuns { get => _DirectFormattingOnRuns; set => UpdateField(ref _DirectFormattingOnRuns, value, nameof(DirectFormattingOnRuns)); }
 private bool? _DirectFormattingOnRuns;

 /// <summary>
 /// Indicates whether direct formatting on paragraphs is included in the filter.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.StylePaneFormatFilter.DirectFormattingOnParagraphs))]
 public bool? DirectFormattingOnParagraphs { get => _DirectFormattingOnParagraphs; set => UpdateField(ref _DirectFormattingOnParagraphs, value, nameof(DirectFormattingOnParagraphs)); }
 private bool? _DirectFormattingOnParagraphs;

 /// <summary>
 /// Indicates whether direct formatting on numbering is included in the filter.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.StylePaneFormatFilter.DirectFormattingOnNumbering))]
 public bool? DirectFormattingOnNumbering { get => _DirectFormattingOnNumbering; set => UpdateField(ref _DirectFormattingOnNumbering, value, nameof(DirectFormattingOnNumbering)); }
 private bool? _DirectFormattingOnNumbering;

 /// <summary>
 /// Indicates whether direct formatting on tables is included in the filter.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.StylePaneFormatFilter.DirectFormattingOnTables))]
 public bool? DirectFormattingOnTables { get => _DirectFormattingOnTables; set => UpdateField(ref _DirectFormattingOnTables, value, nameof(DirectFormattingOnTables)); }
 private bool? _DirectFormattingOnTables;

 /// <summary>
 /// Indicates whether clear formatting is included in the filter.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.StylePaneFormatFilter.ClearFormatting))]
 public bool? ClearFormatting { get => _ClearFormatting; set => UpdateField(ref _ClearFormatting, value, nameof(ClearFormatting)); }
 private bool? _ClearFormatting;

 /// <summary>
 /// Indicates whether the top three heading styles are included in the filter.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.StylePaneFormatFilter.Top3HeadingStyles))]
 public bool? Top3HeadingStyles { get => _Top3HeadingStyles; set => UpdateField(ref _Top3HeadingStyles, value, nameof(Top3HeadingStyles)); }
 private bool? _Top3HeadingStyles;

 /// <summary>
 /// Indicates whether only visible styles are included in the filter.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.StylePaneFormatFilter.VisibleStyles))]
 public bool? VisibleStyles { get => _VisibleStyles; set => UpdateField(ref _VisibleStyles, value, nameof(VisibleStyles)); }
 private bool? _VisibleStyles;

 /// <summary>
 /// Indicates whether alternate style names are included in the filter.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.StylePaneFormatFilter.AlternateStyleNames))]
 public bool? AlternateStyleNames { get => _AlternateStyleNames; set => UpdateField(ref _AlternateStyleNames, value, nameof(AlternateStyleNames)); }
 private bool? _AlternateStyleNames;
}