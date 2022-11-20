namespace DocumentModel.CustomXmlDataProperties;

/// <summary>
/// Associated XML Schema.
/// </summary>
public interface ISchemaReference // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Target Namespace of Associated XML Schema
  /// </summary>
  public string? Uri { get ; set; }
  
}
