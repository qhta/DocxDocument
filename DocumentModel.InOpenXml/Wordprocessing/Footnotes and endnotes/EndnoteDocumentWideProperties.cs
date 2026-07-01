namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents document-wide properties for endnotes in a WordprocessingML document.
/// This class provides properties for endnote placement, numbering format, starting value, restart location, and special endnote references, enabling advanced configuration and management of endnote behavior and formatting across the entire document.
/// </summary>
[OpenXmlType(typeof(DXW.EndnoteDocumentWideProperties))]
[DataContract]
[XmlRoot("EndnoteDocumentWideProperties", Namespace = "DocumentModel.Wordprocessing")]
public partial class EndnoteDocumentWideProperties : ModelElement<DXW.EndnoteDocumentWideProperties>
{
 /// <summary>
 /// Placement of endnotes in the document, specifying where endnotes appear (e.g., end of section, end of document).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.EndnoteDocumentWideProperties.EndnotePosition))]
 public EndnotePosition? EndnotePosition { get => _EndnotePosition; set => UpdateField(ref _EndnotePosition, value, nameof(EndnotePosition)); }
 private EndnotePosition? _EndnotePosition;

 /// <summary>
 /// Numbering format for endnotes, specifying the style of numbering (e.g., Arabic, Roman, letters).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.EndnoteDocumentWideProperties.NumberingFormat))]
 public NumberingFormat? NumberingFormat { get => _NumberingFormat; set => UpdateField(ref _NumberingFormat, value, nameof(NumberingFormat)); }
 private NumberingFormat? _NumberingFormat;

 /// <summary>
 /// Starting value for endnote numbering, specifying the initial number used for the first endnote.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.EndnoteDocumentWideProperties.NumberingStart))]
 public UInt16? NumberingStart { get => _NumberingStart; set => UpdateField(ref _NumberingStart, value, nameof(NumberingStart)); }
 private UInt16? _NumberingStart;

 /// <summary>
 /// Location where endnote numbering restarts (e.g., each section, each page, continuous).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.EndnoteDocumentWideProperties.NumberingRestart))]
 public RestartNumber? NumberingRestart { get => _NumberingRestart; set => UpdateField(ref _NumberingRestart, value, nameof(NumberingRestart)); }
 private RestartNumber? _NumberingRestart;

 /// <summary>
 /// Special references for endnotes, such as separators and continuation notices.
 /// </summary>
 [OpenXmlElementCollection(typeof(DXW.EndnoteSpecialReference))]
 public EndnoteSeparators EndnoteSeparators
 {
   get => _EndnoteSeparators ??= new EndnoteSeparators(this);
    set => UpdateField(ref _EndnoteSeparators, value, nameof(EndnoteSeparators));
 }
  private EndnoteSeparators? _EndnoteSeparators;
}