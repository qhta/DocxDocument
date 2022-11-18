namespace DocumentModel.Wordprocessing;

/// <summary>
/// Custom XML Attribute.
/// </summary>
public interface ICustomXmlAttribute // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// uri
  /// </summary>
  public string? Uri { get ; set; }
  
  /// <summary>
  /// name
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// val
  /// </summary>
  public string? Val { get ; set; }
  
}
