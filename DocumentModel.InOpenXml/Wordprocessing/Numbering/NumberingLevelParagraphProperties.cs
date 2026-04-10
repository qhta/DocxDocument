namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents paragraph properties for a specific numbering level, used in <see cref = "NumLevel"/> definitions in a WordprocessingML document.
/// This class extends <see cref = "AbstractParagraphProperties"/> and is used to specify formatting, layout, and other paragraph-level settings that apply to paragraphs at a particular numbering level, enabling advanced list and outline formatting.
/// </summary>
[OpenXmlType(typeof(DX.OpenXmlElement))]
[XmlRoot("NumberingLevelParagraphProperties", Namespace = "DocumentModel.Wordprocessing")]
public class NumberingLevelParagraphProperties : BaseParagraphProperties<DXW.PreviousParagraphProperties>
{
 /// <summary>
 /// Style ID of the paragraph style used to format the contents of this paragraph.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.PreviousParagraphProperties.ParagraphStyleId))]
 public string? ParagraphStyleId { get => _ParagraphStyleId; set => UpdateField(ref _ParagraphStyleId, value, nameof(ParagraphStyleId)); }

 private string? _ParagraphStyleId;
}