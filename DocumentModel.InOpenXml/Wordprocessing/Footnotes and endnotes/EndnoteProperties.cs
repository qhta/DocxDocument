namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the properties of an endnote in a WordprocessingML document.
/// This class extends <see cref = "SectionPropertiesContent"/> and provides properties for endnote placement, numbering format, starting value, and numbering restart location, enabling advanced configuration and management of endnote behavior and formatting within document sections.
/// </summary>
[OpenXmlType(typeof(DXW.EndnoteProperties))]
[DataContract]
[XmlRoot("EndnoteProperties", Namespace = "DocumentModel.Wordprocessing")]
public partial class EndnoteProperties : ModelElement<DXW.EndnoteProperties>, ISectionPropertiesContent
{
 /// <summary>
 /// Placement of the endnote, specifying where the endnote appears (e.g., end of section, end of document).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.EndnoteProperties.EndnotePosition))]
 public EndnotePosition? EndnotePosition { get => _EndnotePosition; set => UpdateField(ref _EndnotePosition, value, nameof(EndnotePosition)); }
 private EndnotePosition? _EndnotePosition;

 /// <summary>
 /// Numbering format for the endnote, specifying the style of numbering (e.g., Arabic, Roman, letters).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.EndnoteProperties.NumberingFormat))]
 public NumberingFormat? NumberingFormat { get => _NumberingFormat; set => UpdateField(ref _NumberingFormat, value, nameof(NumberingFormat)); }
 private NumberingFormat? _NumberingFormat;

 /// <summary>
 /// Starting value for footnote and endnote numbering, specifying the initial number used for the first note.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.EndnoteProperties.NumberingStart))]
 public UInt16? NumberingStart { get => _NumberingStart; set => UpdateField(ref _NumberingStart, value, nameof(NumberingStart)); }
 private UInt16? _NumberingStart;

 /// <summary>
 /// Location where footnote and endnote numbering restarts (e.g., each section, each page, continuous).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.EndnoteProperties.NumberingRestart))]
 public RestartNumber? NumberingRestart { get => _NumberingRestart; set => UpdateField(ref _NumberingRestart, value, nameof(NumberingRestart)); }
 private RestartNumber? _NumberingRestart;
}