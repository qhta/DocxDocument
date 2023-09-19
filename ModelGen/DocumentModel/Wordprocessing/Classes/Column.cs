namespace DocumentModel.Wordprocessing;


/// <summary>
///   Single Column Definition.
/// </summary>
public partial class Column
{
  
  /// <summary>
  ///   Column Width
  /// </summary>
  [SchemaAttr("w:w")]
  public String? Width { get; set; }
  
  
  /// <summary>
  ///   Space Before Following Column
  /// </summary>
  [SchemaAttr("w:space")]
  public String? Space { get; set; }
  
}
