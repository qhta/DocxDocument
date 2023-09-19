namespace DocumentModel.CustomXml;


/// <summary>
///   Custom XML Schema Reference.
/// </summary>
public partial class Schema
{
  
  /// <summary>
  ///   Custom XML Schema Namespace
  /// </summary>
  [SchemaAttr("sl:uri")]
  public String? Uri { get; set; }
  
  
  /// <summary>
  ///   Resource File Location
  /// </summary>
  [SchemaAttr("sl:manifestLocation")]
  public String? ManifestLocation { get; set; }
  
  
  /// <summary>
  ///   Custom XML Schema Location
  /// </summary>
  [SchemaAttr("sl:schemaLocation")]
  public String? SchemaLocation { get; set; }
  
}
