namespace DocumentModel.CustomXmlSchemaReferences;

/// <summary>
/// Custom XML Schema Reference.
/// </summary>
public interface ISchema // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Custom XML Schema Namespace
  /// </summary>
  public System.String? Uri { get ; set; }
  
  /// <summary>
  /// Resource File Location
  /// </summary>
  public System.String? ManifestLocation { get ; set; }
  
  /// <summary>
  /// Custom XML Schema Location
  /// </summary>
  public System.String? SchemaLocation { get ; set; }
  
}
