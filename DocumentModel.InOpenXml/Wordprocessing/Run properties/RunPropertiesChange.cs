namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a change to run properties, used in <see cref = "RunProperties"/>.
/// This class annotates <see cref = "PreviousRunProperties"/> with author, date, and annotation identifier, enabling tracking and management of property revisions for text runs.
/// </summary>
[OpenXmlType(typeof(DXW.RunPropertiesChange))]
[DataContract]
[XmlRoot("RunPropertiesChange", Namespace = "DocumentModel.Wordprocessing")]
public partial class RunPropertiesChange : IdentifiedChange<DXW.RunPropertiesChange>
{
 /// <summary>
 /// Annotation identifier for the change, used to uniquely identify the revision.
 /// </summary>
 public string? AnnotationId { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
 /// <summary>
 /// Previous run properties before the change, enabling comparison and tracking of revisions.
 /// </summary>
 public PreviousRunProperties? PreviousRunProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}