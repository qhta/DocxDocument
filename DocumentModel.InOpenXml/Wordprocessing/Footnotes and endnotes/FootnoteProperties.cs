namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents the properties of a footnote in a WordprocessingML document.
///   This class extends <see cref = "SectionPropertiesContent"/> and provides properties for footnote placement, numbering format, starting value, and numbering restart location, enabling advanced configuration and management of footnote behavior and formatting within document sections.
/// </summary>
[OpenXmlType(typeof(DXW.FootnoteProperties))]
public partial class FootnoteProperties : ModelElement<DXW.FootnoteProperties>, ISectionPropertiesContent
{
 /// <summary>
 ///   Placement of the footnote, specifying where the footnote appears (e.g., bottom of page, end of document).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FootnoteProperties.FootnotePosition))]
 [OpenXmlElement(typeof(DXW.FootnoteProperties))]
 public FootnotePositionKind? FootnotePosition { get => _FootnotePosition; set => UpdateField(ref _FootnotePosition, value, nameof(FootnotePosition)); }

 private FootnotePositionKind? _FootnotePosition;
 /// <summary>
 ///   Numbering format for the footnote, specifying the style of numbering (e.g., Arabic, Roman, letters).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FootnoteProperties.NumberingFormat))]
 [OpenXmlElement(typeof(DXW.FootnoteProperties))]
 public NumberingFormat? NumberingFormat { get => _NumberingFormat; set => UpdateField(ref _NumberingFormat, value, nameof(NumberingFormat)); }

 private NumberingFormat? _NumberingFormat;
 /// <summary>
 ///   Starting value for footnote and endnote numbering, specifying the initial number used for the first note.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FootnoteProperties.NumberingStart))]
 [OpenXmlElement(typeof(DXW.FootnoteProperties))]
 public UInt16? NumberingStart { get => _NumberingStart; set => UpdateField(ref _NumberingStart, value, nameof(NumberingStart)); }

 private UInt16? _NumberingStart;
 /// <summary>
 ///   Location where footnote and endnote numbering restarts (e.g., each section, each page, continuous).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FootnoteProperties.NumberingRestart))]
 [OpenXmlElement(typeof(DXW.FootnoteProperties))]
 public RestartNumberKind? NumberingRestart { get => _NumberingRestart; set => UpdateField(ref _NumberingRestart, value, nameof(NumberingRestart)); }

 private RestartNumberKind? _NumberingRestart;
}