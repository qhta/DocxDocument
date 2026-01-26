namespace DocumentModel.Wordprocessing;
/// <summary>
/// Base interface for current table properties.
/// Contains properties for preferred table width, layout, and conditional formatting settings, enabling advanced configuration and management of table appearance and behavior.
/// </summary>
[OpenXmlType(typeof(DXW.TableProperties))]
public partial class CurrentTableProperties<T> : BaseTableProperties<T> where T : DX.OpenXmlElement
{
  /// <summary>
  /// Preferred table width, used in table layout algorithms to determine the optimal width of the table.
  /// </summary>
  public TableWidth? TableWidth { get; set; }
  /// <summary>
  /// Table layout type, specifying the layout algorithm used for the table (e.g., fixed or auto).
  /// </summary>
  public TableLayoutKind? TableLayout { get; set; }
  /// <summary>
  /// Table style conditional formatting settings, controlling the appearance and behavior of table styles.
  /// </summary>
  public TableLookFlags? TableLook { get; set; }
}