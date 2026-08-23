namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the table look settings for a table in a Wordprocessing document.
/// This class provides properties for configuring visual appearance flags, such as row and column banding, header and footer rows, and other style options, enabling advanced table styling and formatting.
/// </summary>
[OpenXmlType(typeof(DXW.TableLook))]
[DataContract]
[XmlRoot("TableLook", Namespace = "DocumentModel.Wordprocessing")]
public partial class TableLook: ModelElement<DXW.TableLook>
{
  /// <summary>
  /// Hexadecimal value representing the table look settings.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.TableLook.Val))]
  public HexChar? Val
  {
    get => _Val ??= GetProperty<HexChar?>(GetUpdatableElement()?.Val);
    set => UpdateField(ref _Val, value, nameof(Val));
  }

  private HexChar? _Val;

  /// <summary>
  /// Indicates whether the first row is styled as a header row.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.TableLook.FirstRow))]
  public bool? FirstRow
  {
    get => _FirstRow ??= GetProperty<bool?>(GetUpdatableElement()?.FirstRow);
    set => UpdateField(ref _FirstRow, value, nameof(FirstRow));
  }

  private bool? _FirstRow;

  /// <summary>
  /// Indicates whether the last row is styled as a footer row.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.TableLook.LastRow))]
  public bool? LastRow
  {
    get => _LastRow ??= GetProperty<bool?>(GetUpdatableElement()?.LastRow);
    set => UpdateField(ref _LastRow, value, nameof(LastRow));
  }

  private bool? _LastRow;

  /// <summary>
  /// Indicates whether the first column is styled as a header column.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.TableLook.FirstColumn))]
  public bool? FirstColumn
  {
    get => _FirstColumn ??= GetProperty<bool?>(GetUpdatableElement()?.FirstColumn);
    set => UpdateField(ref _FirstColumn, value, nameof(FirstColumn));
  }

  private bool? _FirstColumn;

  /// <summary>
  /// Indicates whether the last column is styled as a footer column.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.TableLook.LastColumn))]
  public bool? LastColumn
  {
    get => _LastColumn ??= GetProperty<bool?>(GetUpdatableElement()?.LastColumn);
    set => UpdateField(ref _LastColumn, value, nameof(LastColumn));
  }

  private bool? _LastColumn;

  /// <summary>
  /// Indicates whether horizontal banding is disabled for the table.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.TableLook.NoHorizontalBand))]
  public bool? NoHorizontalBand
  {
    get => _NoHorizontalBand ??= GetProperty<bool?>(GetUpdatableElement()?.NoHorizontalBand);
    set => UpdateField(ref _NoHorizontalBand, value, nameof(NoHorizontalBand));
  }

  private bool? _NoHorizontalBand;

  /// <summary>
  /// Indicates whether vertical banding is disabled for the table.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.TableLook.NoVerticalBand))]
  public bool? NoVerticalBand
  {
    get => _NoVerticalBand ??= GetProperty<bool?>(GetUpdatableElement()?.NoVerticalBand);
    set => UpdateField(ref _NoVerticalBand, value, nameof(NoVerticalBand));
  }

  private bool? _NoVerticalBand;
}