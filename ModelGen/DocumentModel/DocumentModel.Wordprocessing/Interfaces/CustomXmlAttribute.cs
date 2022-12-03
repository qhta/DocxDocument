namespace DocumentModel.Wordprocessing;

/// <summary>
/// Custom XML Attribute.
/// </summary>
public interface CustomXmlAttribute // : System.Boolean
{
  /// <summary>
  /// uri
  /// </summary>
  public String? Uri { get ; set; }
  
  /// <summary>
  /// name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// val
  /// </summary>
  public String? Val { get ; set; }
  
}
