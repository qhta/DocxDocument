namespace DocumentModel.Wordprocessing;


/// <summary>
///   Custom Set of Characters Which Cannot End a Line.
/// </summary>
public partial class NoLineBreaksAfterKinsoku
{
  
  /// <summary>
  ///   lang
  /// </summary>
  [SchemaAttr("w:lang")]
  public String? Language { get; set; }
  
  
  /// <summary>
  ///   val
  /// </summary>
  [SchemaAttr("w:val")]
  public String? Val { get; set; }
  
}
