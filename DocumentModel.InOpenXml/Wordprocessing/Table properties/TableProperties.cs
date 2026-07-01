namespace DocumentModel.Wordprocessing;
/// <summary>
///   Specifies the set of table-wide properties applied to the current table.
///   These properties affect the appearance of all rows and cells within the parent table, 
///   but can be overridden by individual table-level exception, row, and cell level properties as defined by each property.
/// </summary>
[OpenXmlType(typeof(DXW.TableProperties))]
[DataContract]
[XmlRoot("TableProperties", Namespace = "DocumentModel.Wordprocessing")]
public partial class TableProperties : ExtBaseTableProperties<DXW.TableProperties>
{
 /// <summary>
 ///   Revision information for table properties, enabling tracking and management of property changes and historical settings.
 /// </summary>
 public TablePropertiesChange? TablePropertiesChange { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}