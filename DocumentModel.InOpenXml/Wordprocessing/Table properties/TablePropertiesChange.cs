namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents a change to table properties, used in <see cref = "TableProperties"/>.
///   This class annotates <see cref = "PreviousTableProperties"/> with author, date, and annotation identifier, enabling tracking and management of property revisions for tables.
/// </summary>
[OpenXmlType(typeof(DXW.TablePropertiesChange))]
[XmlRoot("TablePropertiesChange", Namespace = "DocumentModel.Wordprocessing")]
public partial class TablePropertiesChange : IdentifiedChange<DXW.TablePropertiesChange>
{
 /// <summary>
 ///   Annotation identifier for the change, used to uniquely identify the revision.
 /// </summary>
 public string? AnnotationId { get; set; }
 /// <summary>
 ///   Previous table properties before the change, enabling comparison and tracking of revisions.
 /// </summary>
 public PreviousTableProperties? PreviousTableProperties { get; set; }
}