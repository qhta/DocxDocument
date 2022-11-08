
namespace DocxDocument.Model;

public interface IFootnoteProperties
{
  /// <summary> 
  /// Footnote Placement.
  ///</summary> 
  public FootnotePosition? FootnotePosition { get; set; }
  /// <summary> 
  /// Footnote Numbering Format.
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