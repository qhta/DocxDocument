namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies any East Asian typography settings which shall be applied to the contents of the run.
/// </summary>
public partial class EastAsianLayout
{
  
  /// <summary>
  ///   East Asian Typography Run ID
  /// </summary>
  public Int32? Id { get; set; }
  
  
  /// <summary>
  ///   Two Lines in One
  /// </summary>
  public Boolean? Combine { get; set; }
  
  
  /// <summary>
  ///   Display Brackets Around Two Lines in One
  /// </summary>
  public CombineBracketKind? CombineBrackets { get; set; }
  
  
  /// <summary>
  ///   Horizontal in Vertical (Rotate Text)
  /// </summary>
  public Boolean? Vertical { get; set; }
  
  
  /// <summary>
  ///   Compress Rotated Text to Line Height
  /// </summary>
  public Boolean? VerticalCompress { get; set; }
  
}
