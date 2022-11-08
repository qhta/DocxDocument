namespace DocxDocument.Model;

public class EndnoteProperties: IEndnoteProperties
{
  /// <summary> 
  /// Endnote Placement.
  ///</summary> 
  public EndnotePosition? EndnotePosition { get; set; }
  /// <summary> 
  /// Endnote Numbering Format.
  ///</summary> 
  public NumberingFormat? NumberingFormat { get; set; }
  /// <summary> 
  /// Footnote and Endnote Numbering Restart Location.
  ///</summary> 
  public RestartNumber? NumberingRestart { get; set; }
  /// <summary> 
  /// Footnote and Endnote Numbering Starting Value.
  ///</summary> 
  public int? NumberingStart { get; set; }

}