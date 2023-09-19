namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the CompatibilitySetting Class.
/// </summary>
public partial class CompatibilitySetting
{
  
  /// <summary>
  ///   name
  /// </summary>
  [SchemaAttr("w:name")]
  public DocumentModel.Wordprocessing.CompatSettingNameValues? Name { get; set; }
  
  
  /// <summary>
  ///   uri
  /// </summary>
  [SchemaAttr("w:uri")]
  public String? Uri { get; set; }
  
  
  /// <summary>
  ///   val
  /// </summary>
  [SchemaAttr("w:val")]
  public String? Val { get; set; }
  
}
