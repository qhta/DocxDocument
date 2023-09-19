namespace DocumentModel.Wordprocessing;


/// <summary>
///   Single Document Variable.
/// </summary>
public partial class DocumentVariable
{
  
  /// <summary>
  ///   Document Variable Name
  /// </summary>
  [SchemaAttr("w:name")]
  public String? Name { get; set; }
  
  
  /// <summary>
  ///   Document Variable Value
  /// </summary>
  [SchemaAttr("w:val")]
  public String? Val { get; set; }
  
}
