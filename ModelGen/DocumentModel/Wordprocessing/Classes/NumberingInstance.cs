namespace DocumentModel.Wordprocessing;


/// <summary>
///   Numbering Definition Instance.
/// </summary>
public partial class NumberingInstance
{
  
  /// <summary>
  ///   numId
  /// </summary>
  [SchemaAttr("w:numId")]
  public Int32? NumberID { get; set; }
  
  
  /// <summary>
  ///   durableId
  /// </summary>
  [SchemaAttr("w:durableId")]
  public Int32? DurableId { get; set; }
  
  
  /// <summary>
  ///   AbstractNumId.
  /// </summary>
  public Int32? AbstractNumId { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.Wordprocessing.LevelOverride>? Items { get; set; }
  
}
