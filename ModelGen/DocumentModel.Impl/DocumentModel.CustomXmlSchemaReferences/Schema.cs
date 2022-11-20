namespace DocumentModel.CustomXmlSchemaReferences;

/// <summary>
/// Custom XML Schema Reference.
/// </summary>
public class Schema: ISchema
{
  /// <summary>
  /// Custom XML Schema Namespace
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
  /// <summary>
  /// Resource File Location
  /// </summary>
  public string? ManifestLocation
  {
    get;
    set;
  }
  
  /// <summary>
  /// Custom XML Schema Location
  /// </summary>
  public string? SchemaLocation
  {
    get;
    set;
  }
  
}
