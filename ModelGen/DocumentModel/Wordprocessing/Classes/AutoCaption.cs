namespace DocumentModel.Wordprocessing;


/// <summary>
///   Single Automatic Captioning Setting.
/// </summary>
public partial class AutoCaption
{
  
  /// <summary>
  ///   Identifier of Object to be Automatically Captioned
  /// </summary>
  [SchemaAttr("w:name")]
  public String? Name { get; set; }
  
  
  /// <summary>
  ///   Caption Used for Automatic Captioning
  /// </summary>
  [SchemaAttr("w:caption")]
  public String? Caption { get; set; }
  
}
