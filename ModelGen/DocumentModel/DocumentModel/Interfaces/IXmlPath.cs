namespace DocumentModel;

/// <summary>
/// Defines XPath like information for OpenXmlElement.
/// </summary>
public interface IXmlPath // : 
{
  /// <summary>
  /// Gets the namespace definitions used in . Use  instead
  /// </summary>
  public System.Collections.Generic.IList<System.String>? NamespacesDefinitions { get ; set; }
  
  /// <summary>
  /// Gets the namespace definitions used in
  /// </summary>
  public System.Xml.IXmlNamespaceResolver? Namespaces { get ; set; }
  
  /// <summary>
  /// Gets the XPath string.
  /// </summary>
  public System.String? XPath { get ; set; }
  
  /// <summary>
  /// Gets the public URI of the part relative to the package root.
  /// </summary>
  public System.Uri? PartUri { get ; set; }
  
}
