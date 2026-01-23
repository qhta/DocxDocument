namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the page borders settings for a section in a Wordprocessing document.
/// This class provides properties for z-ordering, display options, border positioning, and individual borders for each page edge, enabling advanced configuration of page border appearance and behavior.
/// </summary>
public partial class PageBorders : ModelElement<DXW.PageBorders>, ISectionPropertiesContent
{
    /// <summary>
    /// Z-ordering of the page border, specifying the stacking order relative to other elements.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.PageBorders.ZOrder))]
    /// <summary>
    /// Z-ordering of the page border, specifying the stacking order relative to other elements.
    /// </summary>
    [OpenXmlElement(typeof(DXW.PageBorders))]
    public PageBorderZOrderKind? ZOrder { get => _ZOrder; set => UpdateField(ref _ZOrder, value, nameof(ZOrder)); }

    private PageBorderZOrderKind? _ZOrder;
    /// <summary>
    /// Pages to display page borders, specifying which pages the borders are shown on.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.PageBorders.Display))]
    /// <summary>
    /// Pages to display page borders, specifying which pages the borders are shown on.
    /// </summary>
    [OpenXmlElement(typeof(DXW.PageBorders))]
    public PageBorderDisplayKind? Display { get => _Display; set => UpdateField(ref _Display, value, nameof(Display)); }

    private PageBorderDisplayKind? _Display;
    /// <summary>
    /// Page border positioning, specifying the offset from the page edge.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.PageBorders.OffsetFrom))]
    /// <summary>
    /// Page border positioning, specifying the offset from the page edge.
    /// </summary>
    [OpenXmlElement(typeof(DXW.PageBorders))]
    public PageBorderOffsetKind? OffsetFrom { get => _OffsetFrom; set => UpdateField(ref _OffsetFrom, value, nameof(OffsetFrom)); }

    private PageBorderOffsetKind? _OffsetFrom;
    /// <summary>
    /// Top border of the page, specifying the style and appearance of the top edge.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.PageBorders.TopBorder))]
    /// <summary>
    /// Top border of the page, specifying the style and appearance of the top edge.
    /// </summary>
    [OpenXmlElement(typeof(DXW.PageBorders))]
    public Border? TopBorder { get => _TopBorder; set => UpdateField(ref _TopBorder, value, nameof(TopBorder)); }

    private Border? _TopBorder;
    /// <summary>
    /// Left border of the page, specifying the style and appearance of the left edge.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.PageBorders.LeftBorder))]
    /// <summary>
    /// Left border of the page, specifying the style and appearance of the left edge.
    /// </summary>
    [OpenXmlElement(typeof(DXW.PageBorders))]
    public Border? LeftBorder { get => _LeftBorder; set => UpdateField(ref _LeftBorder, value, nameof(LeftBorder)); }

    private Border? _LeftBorder;
    /// <summary>
    /// Bottom border of the page, specifying the style and appearance of the bottom edge.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.PageBorders.BottomBorder))]
    /// <summary>
    /// Bottom border of the page, specifying the style and appearance of the bottom edge.
    /// </summary>
    [OpenXmlElement(typeof(DXW.PageBorders))]
    public Border? BottomBorder { get => _BottomBorder; set => UpdateField(ref _BottomBorder, value, nameof(BottomBorder)); }

    private Border? _BottomBorder;
    /// <summary>
    /// Right border of the page, specifying the style and appearance of the right edge.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.PageBorders.RightBorder))]
    /// <summary>
    /// Right border of the page, specifying the style and appearance of the right edge.
    /// </summary>
    [OpenXmlElement(typeof(DXW.PageBorders))]
    public Border? RightBorder { get => _RightBorder; set => UpdateField(ref _RightBorder, value, nameof(RightBorder)); }

    private Border? _RightBorder;
}