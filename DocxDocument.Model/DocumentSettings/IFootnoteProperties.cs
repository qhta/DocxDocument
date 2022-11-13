
namespace DocxDocument.Model;

public interface IFootnoteProperties
{
  /// <summary> 
  /// Footnote Placement.
  ///</summary> 
  public DM.FootnotePosition? FootnotePosition { get; set; }
  /// <summary> 
  /// Footnote Numbering Format.
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