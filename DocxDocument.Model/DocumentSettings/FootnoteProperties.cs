
namespace DocxDocument.Model;

public class FootnoteProperties: DocxBasedElement<WD.FootnoteProperties>, IFootnoteProperties
{
  public FootnoteProperties() : base(new WD.FootnoteProperties())
  {
  }

  public FootnoteProperties(WD.FootnoteProperties element) : base(element)
  {
  }

  /// <summary> 
  /// Endnote Placement.
  ///</summary> 
  public DM.FootnotePosition? FootnotePosition
  {
    get => (DM.FootnotePosition?)DocxElement.FootnotePosition?.Val?.Value;
    set => DocxElement.FootnotePosition = (value != null) ? new WD.FootnotePosition { Val = (WD.FootnotePositionValues)value } : null;
  }

  /// <summary> 
  /// Endnote Numbering Format.
  ///</summary> 
  public DM.NumberingFormat? NumberingFormat
  {
    get => (DM.NumberingFormat?)DocxElement.NumberingFormat?.Val?.Value;
    set => DocxElement.NumberingFormat = (value != null) ? new WD.NumberingFormat { Val = (WD.NumberFormatValues)value } : null;
  }

  /// <summary> 
  /// Footnote and Endnote Numbering Restart Location.
  ///</summary> 
  public DM.RestartNumber? NumberingRestart
  {
    get => (DM.RestartNumber?)DocxElement.NumberingRestart?.Val?.Value;
    set => DocxElement.NumberingRestart = (value != null) ? new WD.NumberingRestart { Val = (WD.RestartNumberValues)value } : null;
  }

  /// <summary> 
  /// Footnote and Endnote Numbering Starting Value.
  ///</summary> 
  public int? NumberingStart
  {
    get => DocxElement.NumberingStart?.Val?.Value;
    set => DocxElement.NumberingStart = (value != null) ? new WD.NumberingStart { Val = (UInt16)value } : null;
  }

}