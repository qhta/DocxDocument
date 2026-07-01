namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents a change to table cell properties, used in <see cref = "TableCellProperties"/>.
///   This class annotates <see cref = "PreviousTableCellProperties"/> with author, date, and annotation identifier, enabling tracking and management of property revisions in table cells.
/// </summary>
[OpenXmlType(typeof(DXW.TableCellPropertiesChange))]
[DataContract]
[XmlRoot("TableCellPropertiesChange", Namespace = "DocumentModel.Wordprocessing")]
public partial class TableCellPropertiesChange : IdentifiedChange<DXW.TableCellPropertiesChange>
{
 /// <summary>
 ///   Annotation identifier for the change, used to uniquely identify the revision.
 /// </summary>
 public string? AnnotationId { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
 /// <summary>
 ///   Previous table cell properties before the change, enabling comparison and tracking of revisions.
 /// </summary>
 public PreviousTableCellProperties? PreviousTableCellProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}