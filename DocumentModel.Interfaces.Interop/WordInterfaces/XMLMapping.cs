namespace DocumentModel.Interop;

/// <summary>
/// Represents the XML mapping on a ContentControl object between custom XML and a content control. An XML mapping is a link between the text in a content control and an XML element in the custom XML data store for this document.
/// </summary>
public partial interface XMLMapping : InteropObject
{
  /// <summary>
  /// The is mapped.
  /// </summary>
  public bool IsMapped { get; }

  /// <summary>
  /// The custom xmlpart.
  /// </summary>
  //public Core.CustomXMLPart CustomXMLPart { get; }

  /// <summary>
  /// The custom xmlnode.
  /// </summary>
  //public Core.CustomXMLNode CustomXMLNode { get; }

  /// <summary>
  /// The xpath.
  /// </summary>
  public string XPath { get; }

  /// <summary>
  /// The prefix mappings.
  /// </summary>
  public string PrefixMappings { get; }
}
