namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a change to table row properties, used in <see cref = "TableRowProperties"/>.
/// This class annotates <see cref = "PreviousTableRowProperties"/> with author, date, and annotation identifier, enabling tracking and management of property revisions for table rows.
/// </summary>
[OpenXmlType(typeof(DXW.TableRowPropertiesChange))]
[DataContract]
[XmlRoot("TableRowPropertiesChange", Namespace = "DocumentModel.Wordprocessing")]
public partial class TableRowPropertiesChange : IdentifiedChange<DXW.TableRowPropertiesChange>
{
 /// <summary>
 /// Annotation identifier for the change, used to uniquely identify the revision.
 /// </summary>
 public string? AnnotationId { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
 /// <summary>
 /// Previous table row properties before the change, enabling comparison and tracking of revisions.
 /// </summary>
 public PreviousTableRowProperties? PreviousTableRowProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}