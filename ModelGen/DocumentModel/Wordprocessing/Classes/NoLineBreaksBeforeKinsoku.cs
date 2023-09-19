namespace DocumentModel.Wordprocessing;


/// <summary>
///   Custom Set Of Characters Which Cannot Begin A Line.
/// </summary>
public partial class NoLineBreaksBeforeKinsoku
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
