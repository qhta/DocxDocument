namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the previous version of paragraph properties, used in <see cref = "ParagraphPropertiesChange"/>.
/// This class extends <see cref = "AbstractParagraphProperties"/> and is used to store the state of paragraph formatting before a tracked change, enabling comparison and revision management in WordprocessingML documents.
/// </summary>
[OpenXmlType(typeof(DXW.PreviousParagraphProperties))]
[XmlRoot("PreviousParagraphProperties", Namespace = "DocumentModel.Wordprocessing")]
public class PreviousParagraphProperties : BaseParagraphProperties<DXW.PreviousParagraphProperties>
{
 /// <summary>
 /// Style ID of the paragraph style used to format the contents of this paragraph.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.PreviousParagraphProperties.ParagraphStyleId))]
 public string? ParagraphStyleId { get => _ParagraphStyleId; set => UpdateField(ref _ParagraphStyleId, value, nameof(ParagraphStyleId)); }

 private string? _ParagraphStyleId;
}