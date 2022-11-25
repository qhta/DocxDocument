namespace DocumentModel.Wordprocessing;

/// <summary>
/// Custom XML Attribute.
/// </summary>
public interface ICustomXmlAttribute // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// uri
  /// </summary>
  public System.String? Uri { get ; set; }
  
  /// <summary>
  /// name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// val
  /// </summary>
  public System.String? Val { get ; set; }
  
}
