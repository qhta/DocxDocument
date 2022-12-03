namespace DocumentModel;

/// <summary>
/// Defines XPath like information for OpenXmlElement.
/// </summary>
public interface XmlPath // : 
{
  /// <summary>
  /// Gets the namespace definitions used in . Use  instead
  /// </summary>
  [Obsolete("Use the Namespaces property instead")]
  public IList<String>? NamespacesDefinitions { get ; set; }
  
  /// <summary>
  /// Gets the namespace definitions used in
  /// </summary>
  public IXmlNamespaceResolver? Namespaces { get ; set; }
  
  /// <summary>
  /// Gets the XPath string.
  /// </summary>
  public String? XPath { get ; set; }
  
  /// <summary>
  /// Gets the internal URI of the part relative to the package root.
  /// </summary>
  public Uri? PartUri { get ; set; }
  
}
