namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents run properties for the paragraph mark, used in <see cref = "ParagraphProperties"/>.
/// This class extends <see cref = "BaseParagraphMarkRunProperties"/> and provides support for revision tracking of paragraph mark formatting changes.
/// </summary>
[OpenXmlType(typeof(DXW.ParagraphMarkRunProperties))]
[XmlRoot("ParagraphMarkRunProperties", Namespace = "DocumentModel.Wordprocessing")]
public partial class ParagraphMarkRunProperties : BaseParagraphMarkRunProperties<DXW.ParagraphMarkRunProperties>
{
 /// <summary>
 /// Set of run properties applied to the glyph representing the physical location of the paragraph mark, attributed to a revision by a specific author at a specific time. Contains the set of properties tracked as a specific set of revisions by one author.
 /// </summary>
 public ParagraphMarkRunPropertiesChange? ParagraphMarkRunPropertiesChange { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}