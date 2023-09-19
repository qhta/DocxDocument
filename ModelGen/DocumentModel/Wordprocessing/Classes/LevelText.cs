namespace DocumentModel.Wordprocessing;


/// <summary>
///   Numbering Level Text.
/// </summary>
public partial class LevelText
{
  
  /// <summary>
  ///   Level Text
  /// </summary>
  [SchemaAttr("w:val")]
  public String? Val { get; set; }
  
  
  /// <summary>
  ///   Level Text Is Null Character
  /// </summary>
  [SchemaAttr("w:null")]
  public Boolean? Null { get; set; }
  
}
