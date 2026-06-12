namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a change to paragraph mark run properties, used in <see cref = "ParagraphMarkRunProperties"/>.
/// This class annotates <see cref = "PreviousParagraphMarkRunProperties"/> with author, date, and annotation identifier, enabling tracking and management of property revisions for paragraph mark formatting.
/// </summary>
[OpenXmlType(typeof(DXW.ParagraphMarkRunPropertiesChange))]
[XmlRoot("ParagraphMarkRunPropertiesChange", Namespace = "DocumentModel.Wordprocessing")]
public partial class ParagraphMarkRunPropertiesChange : IdentifiedChange<DXW.ParagraphMarkRunPropertiesChange>
{
 /// <summary>
 /// Annotation identifier for the change, used to uniquely identify the revision.
 /// </summary>
 public string? AnnotationId { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
 /// <summary>
 /// Previous run properties for the paragraph mark before the change, enabling comparison and tracking of revisions.
 /// </summary>
 public PreviousParagraphMarkRunProperties? PreviousParagraphMarkRunProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}