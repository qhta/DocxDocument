namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents document-wide properties for footnotes in a WordprocessingML document.
/// This class provides properties for footnote placement, numbering format, starting value, restart location, and special footnote references, enabling advanced configuration and management of footnote behavior and formatting across the entire document.
/// </summary>
public partial class FootnoteDocumentWideProperties : ModelElement<DXW.FootnoteDocumentWideProperties>
{
    /// <summary>
    /// Placement of footnotes in the document, specifying where footnotes appear (e.g., bottom of page, end of document).
    /// </summary>
    [OpenXmlProperty(nameof(DXW.FootnoteDocumentWideProperties.FootnotePosition))]
    /// <summary>
    /// Placement of footnotes in the document, specifying where footnotes appear (e.g., bottom of page, end of document).
    /// </summary>
    [OpenXmlElement(typeof(DXW.FootnoteDocumentWideProperties))]
    public FootnotePositionKind? FootnotePosition { get => _FootnotePosition; set => UpdateField(ref _FootnotePosition, value, nameof(FootnotePosition)); }

    private FootnotePositionKind? _FootnotePosition;
    /// <summary>
    /// Numbering format for footnotes, specifying the style of numbering (e.g., Arabic, Roman, letters).
    /// </summary>
    [OpenXmlProperty(nameof(DXW.FootnoteDocumentWideProperties.NumberingFormat))]
    /// <summary>
    /// Numbering format for footnotes, specifying the style of numbering (e.g., Arabic, Roman, letters).
    /// </summary>
    [OpenXmlElement(typeof(DXW.FootnoteDocumentWideProperties))]
    public NumberingFormat? NumberingFormat { get => _NumberingFormat; set => UpdateField(ref _NumberingFormat, value, nameof(NumberingFormat)); }

    private NumberingFormat? _NumberingFormat;
    /// <summary>
    /// Starting value for footnote numbering, specifying the initial number used for the first footnote.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.FootnoteDocumentWideProperties.NumberingStart))]
    /// <summary>
    /// Starting value for footnote numbering, specifying the initial number used for the first footnote.
    /// </summary>
    [OpenXmlElement(typeof(DXW.FootnoteDocumentWideProperties))]
    public UInt16? NumberingStart { get => _NumberingStart; set => UpdateField(ref _NumberingStart, value, nameof(NumberingStart)); }

    private UInt16? _NumberingStart;
    /// <summary>
    /// Location where footnote numbering restarts (e.g., each section, each page, continuous).
    /// </summary>
    [OpenXmlProperty(nameof(DXW.FootnoteDocumentWideProperties.NumberingRestart))]
    /// <summary>
    /// Location where footnote numbering restarts (e.g., each section, each page, continuous).
    /// </summary>
    [OpenXmlElement(typeof(DXW.FootnoteDocumentWideProperties))]
    public RestartNumberKind? NumberingRestart { get => _NumberingRestart; set => UpdateField(ref _NumberingRestart, value, nameof(NumberingRestart)); }

    private RestartNumberKind? _NumberingRestart;
    /// <summary>
    /// Special references for footnotes, such as separators and continuation notices.
    /// </summary>
    [OpenXmlElement(typeof(DXW.FootnoteDocumentWideProperties))]
    public FootnoteSeparators? FootnoteSeparators { get => _FootnoteSeparators; set => UpdateField(ref _FootnoteSeparators, value, nameof(FootnoteSeparators)); }

    private FootnoteSeparators? _FootnoteSeparators;
}