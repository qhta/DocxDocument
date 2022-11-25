namespace DocumentModel.CustomXmlDataProperties;

/// <summary>
/// Associated XML Schema.
/// </summary>
public interface ISchemaReference // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Target Namespace of Associated XML Schema
  /// </summary>
  public System.String? Uri { get ; set; }
  
}
