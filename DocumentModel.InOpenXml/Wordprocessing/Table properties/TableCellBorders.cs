namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the set of borders for a table cell in a Wordprocessing document.
/// This class provides properties for configuring the top, left, start, bottom, right, end, inside horizontal, inside vertical, and diagonal borders, enabling advanced formatting and appearance control for cell edges and internal lines.
/// </summary>
[OpenXmlType(typeof(DXW.TableCellBorders))]
[DataContract]
[XmlRoot("TableCellBorders", Namespace = "DocumentModel.Wordprocessing")]
public partial class TableCellBorders: ModelElement<DXW.TableCellBorders>
{
  /// <summary>
  /// Table cell top border, specifying the style and appearance of the top edge of the cell.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.TableCellBorders.TopBorder))]
  public Border? TopBorder
  {
    get => _TopBorder ??= GetProperty<Border?>(GetUpdatableElement()?.TopBorder);
    set => UpdateField(ref _TopBorder, value, nameof(TopBorder));
  }

  private Border? _TopBorder;

  /// <summary>
  /// Table cell left border, specifying the style and appearance of the left edge of the cell.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.TableCellBorders.LeftBorder))]
  public Border? LeftBorder
  {
    get => _LeftBorder ??= GetProperty<Border?>(GetUpdatableElement()?.LeftBorder);
    set => UpdateField(ref _LeftBorder, value, nameof(LeftBorder));
  }

  private Border? _LeftBorder;

  /// <summary>
  /// Start border, specifying the style and appearance of the starting edge of the cell (contextual to document direction).
  /// </summary>
  [OpenXmlProperty(nameof(DXW.TableCellBorders.StartBorder))]
  public Border? StartBorder
  {
    get => _StartBorder ??= GetProperty<Border?>(GetUpdatableElement()?.StartBorder);
    set => UpdateField(ref _StartBorder, value, nameof(StartBorder));
  }

  private Border? _StartBorder;

  /// <summary>
  /// Table cell bottom border, specifying the style and appearance of the bottom edge of the cell.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.TableCellBorders.BottomBorder))]
  public Border? BottomBorder
  {
    get => _BottomBorder ??= GetProperty<Border?>(GetUpdatableElement()?.BottomBorder);
    set => UpdateField(ref _BottomBorder, value, nameof(BottomBorder));
  }

  private Border? _BottomBorder;

  /// <summary>
  /// Table cell right border, specifying the style and appearance of the right edge of the cell.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.TableCellBorders.RightBorder))]
  public Border? RightBorder
  {
    get => _RightBorder ??= GetProperty<Border?>(GetUpdatableElement()?.RightBorder);
    set => UpdateField(ref _RightBorder, value, nameof(RightBorder));
  }

  private Border? _RightBorder;

  /// <summary>
  /// End border, specifying the style and appearance of the ending edge of the cell (contextual to document direction).
  /// </summary>
  [OpenXmlProperty(nameof(DXW.TableCellBorders.EndBorder))]
  public Border? EndBorder
  {
    get => _EndBorder ??= GetProperty<Border?>(GetUpdatableElement()?.EndBorder);
    set => UpdateField(ref _EndBorder, value, nameof(EndBorder));
  }

  private Border? _EndBorder;

  /// <summary>
  /// Table cell inside horizontal edges border, specifying the style and appearance of horizontal lines within the cell.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.TableCellBorders.InsideHorizontalBorder))]
  public Border? InsideHorizontalBorder
  {
    get => _InsideHorizontalBorder ??= GetProperty<Border?>(GetUpdatableElement()?.InsideHorizontalBorder);
    set => UpdateField(ref _InsideHorizontalBorder, value, nameof(InsideHorizontalBorder));
  }

  private Border? _InsideHorizontalBorder;

  /// <summary>
  /// Table cell inside vertical edges border, specifying the style and appearance of vertical lines within the cell.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.TableCellBorders.InsideVerticalBorder))]
  public Border? InsideVerticalBorder
  {
    get => _InsideVerticalBorder ??= GetProperty<Border?>(GetUpdatableElement()?.InsideVerticalBorder);
    set => UpdateField(ref _InsideVerticalBorder, value, nameof(InsideVerticalBorder));
  }

  private Border? _InsideVerticalBorder;

  /// <summary>
  /// Table cell top left to bottom right diagonal border, specifying the style and appearance of the diagonal line from top left to bottom right.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.TableCellBorders.TopLeftToBottomRightCellBorder))]
  public Border? TopLeftToBottomRightCellBorder
  {
    get => _TopLeftToBottomRightCellBorder ??=
      GetProperty<Border?>(GetUpdatableElement()?.TopLeftToBottomRightCellBorder);
    set => UpdateField(ref _TopLeftToBottomRightCellBorder, value, nameof(TopLeftToBottomRightCellBorder));
  }

  private Border? _TopLeftToBottomRightCellBorder;

  /// <summary>
  /// Table cell top right to bottom left diagonal border, specifying the style and appearance of the diagonal line from top right to bottom left.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.TableCellBorders.TopRightToBottomLeftCellBorder))]
  public Border? TopRightToBottomLeftCellBorder
  {
    get => _TopRightToBottomLeftCellBorder ??=
      GetProperty<Border?>(GetUpdatableElement()?.TopRightToBottomLeftCellBorder);
    set => UpdateField(ref _TopRightToBottomLeftCellBorder, value, nameof(TopRightToBottomLeftCellBorder));
  }

  private Border? _TopRightToBottomLeftCellBorder;
}