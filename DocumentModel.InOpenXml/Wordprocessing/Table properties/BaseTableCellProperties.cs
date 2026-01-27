namespace DocumentModel.Wordprocessing;

/// <summary>
/// Base interface for all TableCellProperties classes.
/// Contains common properties for table cell formatting, including shading, text wrapping, margins, and vertical alignment.
/// </summary>
[OpenXmlType(typeof(DXW.TableCellProperties))]
public partial class BaseTableCellProperties<T>: ModelElement<T> where T: DX.OpenXmlElement
{
  /// <summary>
  /// Shading applied to the table cell, specifying background and pattern formatting.
  /// </summary>
  [OpenXmlElement(typeof(Shading))]
  public Shading? Shading
  {
    get => _Shading;
    set => UpdateField(ref _Shading, value, nameof(Shading));
  }

  private Shading? _Shading;

  /// <summary>
  /// Indicates whether text wrapping is disabled for the cell.
  /// </summary>
  [OpenXmlElement(typeof(DXW.NoWrap))]
  public bool? NoWrap
  {
    get => _NoWrap;
    set => UpdateField(ref _NoWrap, value, nameof(NoWrap));
  }

  private bool? _NoWrap;

  /// <summary>
  /// Margins for the table cell, specifying padding on each side.
  /// </summary>
  [OpenXmlElement(typeof(DXW.TableCellMargin))]
  public TableCellMargin? TableCellMargin
  {
    get => _TableCellMargin;
    set => UpdateField(ref _TableCellMargin, value, nameof(TableCellMargin));
  }

  private TableCellMargin? _TableCellMargin;

  /// <summary>
  /// Vertical alignment of content within the table cell.
  /// </summary>
  [OpenXmlElement(typeof(DXW.TableCellVerticalAlignment))]
  public TableVerticalAlignmentKind? TableCellVerticalAlignment
  {
    get => _TableCellVerticalAlignment;
    set => UpdateField(ref _TableCellVerticalAlignment, value, nameof(TableCellVerticalAlignment));
  }

  private TableVerticalAlignmentKind? _TableCellVerticalAlignment;
}