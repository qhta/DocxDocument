namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the Extension Class.
/// </summary>
public partial class Extension
{
  
  /// <summary>
  ///   uri, this property is only available in Office 2021 and later.
  /// </summary>
  [Nullable((Byte)2)]
  [SchemaAttr("w16cur:uri")]
  public String? Uri { get; set; }
  
}
