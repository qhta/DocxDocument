namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies a set of table properties to be applied to the contents of this row in place of the table properties specified in the tblPr element.
/// These properties are typically used in cases involving legacy documents, as well as cases where two existing independent tables are merged, in order to prevent the look of the second table from being superseded by the first table.
/// </summary>
[OpenXmlType(typeof(DXW.TablePropertyExceptions))]
public partial class TablePropertyExceptions : CurrentTableProperties<DXW.TablePropertyExceptions>
{
  /// <summary>
  /// Revision information for table-level property exceptions, enabling tracking and management of property changes and historical settings.
  /// </summary>
  public TablePropertyExceptionsChange? TablePropertyExceptionsChange { get; set; }
}