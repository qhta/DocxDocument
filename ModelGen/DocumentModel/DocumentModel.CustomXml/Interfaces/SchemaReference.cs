namespace DocumentModel.CustomXml;

/// <summary>
/// Associated XML Schema.
/// </summary>
public interface SchemaReference // : System.Boolean
{
  /// <summary>
  /// Target Namespace of Associated XML Schema
  /// </summary>
  public String? Uri { get ; set; }
  
}
