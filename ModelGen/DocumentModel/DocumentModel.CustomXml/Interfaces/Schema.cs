namespace DocumentModel.CustomXml;

/// <summary>
/// Custom XML Schema Reference.
/// </summary>
public partial interface Schema
{
  /// <summary>
  /// Custom XML Schema Namespace
  /// </summary>
  public String? Uri { get; set; }
  
  /// <summary>
  /// Resource File Location
  /// </summary>
  public String? ManifestLocation { get; set; }
  
  /// <summary>
  /// Custom XML Schema Location
  /// </summary>
  public String? SchemaLocation { get; set; }
  
}
