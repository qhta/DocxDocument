namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents the properties of a footnote in a WordprocessingML document.
///   This class extends <see cref = "SectionPropertiesContent"/> and provides properties for footnote placement, numbering format, starting value, and numbering restart location, enabling advanced configuration and management of footnote behavior and formatting within document sections.
/// </summary>
[OpenXmlType(typeof(DXW.FootnoteProperties))]
[DataContract]
[XmlRoot("FootnoteProperties", Namespace = "DocumentModel.Wordprocessing")]
public partial class FootnoteProperties: ModelElement<DXW.FootnoteProperties>, ISectionPropertiesContent
{
  /// <summary>
  ///   Placement of the footnote, specifying where the footnote appears (e.g., bottom of page, end of document).
  /// </summary>
  [OpenXmlProperty(nameof(DXW.FootnoteProperties.FootnotePosition))]
  public FootnotePosition? FootnotePosition
  {
    get => _FootnotePosition ??= GetProperty<FootnotePosition?>(GetUpdatableElement()?.FootnotePosition);
    set => UpdateField(ref _FootnotePosition, value, nameof(FootnotePosition));
  }

  private FootnotePosition? _FootnotePosition;

  /// <summary>
  ///   Numbering format for the footnote, specifying the style of numbering (e.g., Arabic, Roman, letters).
  /// </summary>
  [OpenXmlProperty(nameof(DXW.FootnoteProperties.NumberingFormat))]
  public NumberingFormat? NumberingFormat
  {
    get => _NumberingFormat ??= GetProperty<NumberingFormat?>(GetUpdatableElement()?.NumberingFormat);
    set => UpdateField(ref _NumberingFormat, value, nameof(NumberingFormat));
  }

  private NumberingFormat? _NumberingFormat;

  /// <summary>
  ///   Starting value for footnote and endnote numbering, specifying the initial number used for the first note.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.FootnoteProperties.NumberingStart))]
  public UInt16? NumberingStart
  {
    get => _NumberingStart ??= GetProperty<UInt16?>(GetUpdatableElement()?.NumberingStart);
    set => UpdateField(ref _NumberingStart, value, nameof(NumberingStart));
  }

  private UInt16? _NumberingStart;

  /// <summary>
  ///   Location where footnote and endnote numbering restarts (e.g., each section, each page, continuous).
  /// </summary>
  [OpenXmlProperty(nameof(DXW.FootnoteProperties.NumberingRestart))]
  public RestartNumber? NumberingRestart
  {
    get => _NumberingRestart ??= GetProperty<RestartNumber?>(GetUpdatableElement()?.NumberingRestart);
    set => UpdateField(ref _NumberingRestart, value, nameof(NumberingRestart));
  }

  private RestartNumber? _NumberingRestart;
}