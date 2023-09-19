namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies any East Asian typography settings which shall be applied to the contents of the run.
/// </summary>
public partial class EastAsianLayout
{
  
  /// <summary>
  ///   East Asian Typography Run ID
  /// </summary>
  [SchemaAttr("w:id")]
  public Int32? Id { get; set; }
  
  
  /// <summary>
  ///   Two Lines in One
  /// </summary>
  [SchemaAttr("w:combine")]
  public Boolean? Combine { get; set; }
  
  
  /// <summary>
  ///   Display Brackets Around Two Lines in One
  /// </summary>
  [SchemaAttr("w:combineBrackets")]
  public DocumentModel.Wordprocessing.CombineBracketValues? CombineBrackets { get; set; }
  
  
  /// <summary>
  ///   Horizontal in Vertical (Rotate Text)
  /// </summary>
  [SchemaAttr("w:vert")]
  public Boolean? Vertical { get; set; }
  
  
  /// <summary>
  ///   Compress Rotated Text to Line Height
  /// </summary>
  [SchemaAttr("w:vertCompress")]
  public Boolean? VerticalCompress { get; set; }
  
}
