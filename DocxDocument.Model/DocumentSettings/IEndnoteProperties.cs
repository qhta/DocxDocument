namespace DocxDocument.Model;

public interface IEndnoteProperties
{
  /// <summary> 
  /// Endnote Placement.
  ///</summary> 
  public DM.EndnotePosition? EndnotePosition { get; set; }
  /// <summary> 
  /// Endnote Numbering Format.
  ///</summary> 
  public DM.NumberingFormat? NumberingFormat { get; set; }
  /// <summary> 
  /// Footnote and Endnote Numbering Restart Location.
  ///</summary> 
  public DM.RestartNumber? NumberingRestart { get; set; }
  /// <summary> 
  /// Footnote and Endnote Numbering Starting Value.
  ///</summary> 
  public int? NumberingStart { get; set; }

}