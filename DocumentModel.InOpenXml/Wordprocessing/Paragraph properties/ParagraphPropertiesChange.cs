namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a change to paragraph properties, used in <see cref = "ParagraphProperties"/>.
/// This class annotates <see cref = "PreviousParagraphProperties"/> with author, date, and annotation identifier, enabling tracking and management of property revisions for paragraph formatting in WordprocessingML documents.
/// </summary>
[OpenXmlType(typeof(DXW.ParagraphPropertiesChange))]
[DataContract]
[XmlRoot("ParagraphPropertiesChange", Namespace = "DocumentModel.Wordprocessing")]
public partial class ParagraphPropertiesChange : TrackChangeType<DXW.ParagraphPropertiesChange>
{
 /// <summary>
 /// Previous paragraph properties before the change, enabling comparison and tracking of revisions.
 /// </summary>
 public PreviousParagraphProperties? PreviousParagraphProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}