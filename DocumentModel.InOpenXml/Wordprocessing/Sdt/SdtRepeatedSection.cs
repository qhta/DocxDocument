namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents a repeated section structured document tag in a Wordprocessing document.
///   This class provides properties for the section title and options to restrict insertion or deletion of sections, enabling advanced configuration and management of repeated sections in structured document tags.
/// </summary>
[OpenXmlType(typeof(DXO13W.SdtRepeatedSection))]
[XmlRoot("SdtRepeatedSection", Namespace = "DocumentModel.Wordprocessing")]
public partial class SdtRepeatedSection : ModelElement<DXO13W.SdtRepeatedSection>
{
 /// <summary>
 ///   Title of the repeated section, used for identification and display purposes.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13W.SdtRepeatedSection.SectionTitle))]
 public string? SectionTitle { get => _SectionTitle; set => UpdateField(ref _SectionTitle, value, nameof(SectionTitle)); }

 private string? _SectionTitle;
 /// <summary>
 ///   Indicates whether insertion or deletion of sections is disallowed.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13W.SdtRepeatedSection.DoNotAllowInsertDeleteSection))]
 public bool? DoNotAllowInsertDeleteSection { get => _DoNotAllowInsertDeleteSection; set => UpdateField(ref _DoNotAllowInsertDeleteSection, value, nameof(DoNotAllowInsertDeleteSection)); }

 private bool? _DoNotAllowInsertDeleteSection;
}