namespace DocumentModel.Vml.Office;


/// <summary>
///   Regroup Entry.
/// </summary>
public partial class Entry
{
  
  /// <summary>
  ///   New Group ID
  /// </summary>
  [SchemaAttr("new")]
  public Int32? New { get; set; }
  
  
  /// <summary>
  ///   Old Group ID
  /// </summary>
  [SchemaAttr("old")]
  public Int32? Old { get; set; }
  
}
