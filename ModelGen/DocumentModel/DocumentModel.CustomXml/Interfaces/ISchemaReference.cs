namespace DocumentModel.CustomXml;

/// <summary>
/// Associated XML Schema.
/// </summary>
public interface ISchemaReference // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Target Namespace of Associated XML Schema
  /// </summary>
  public String? Uri { get ; set; }
  
}
