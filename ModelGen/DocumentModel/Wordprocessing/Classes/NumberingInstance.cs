namespace DocumentModel.Wordprocessing;


/// <summary>
///   Numbering Definition Instance.
/// </summary>
public partial class NumberingInstance
{
  
  /// <summary>
  ///   numId
  /// </summary>
  public Int32? NumberID { get; set; }
  
  
  /// <summary>
  ///   durableId
  /// </summary>
  public Int32? DurableId { get; set; }
  
  
  /// <summary>
  ///   AbstractNumId.
  /// </summary>
  public DocumentModel.Wordprocessing.AbstractNumId? AbstractNumId { get; set; }
  
  public DM.ElementCollection<LevelOverride>? Items { get; set; }
  
}
