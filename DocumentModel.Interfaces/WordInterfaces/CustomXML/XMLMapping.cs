namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the XML mapping on a ContentControl object between custom XML and a content control. An XML mapping
/// is a link between the text in a content control and an XML element in the custom XML data store for this
/// document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlmapping?view=word-pia"/>
public partial interface XMLMapping : InteropObject
{
  /// <summary>
  /// Returns a Boolean that represents whether the content control in the document is mapped to an XML node in the
  /// document’s XML data store. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlmapping.ismapped?view=word-pia"/>
  public bool IsMapped { get; }

  /// <summary>
  /// Returns a CustomXMLPart object that represents the custom XML part to which the content control in the
  /// document maps.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlmapping.customxmlpart?view=word-pia"/>
  public Core.CustomXMLPart CustomXMLPart { get; }

  /// <summary>
  /// Returns a CustomXMLNode object that represents the custom XML node in the data store to which the content
  /// control in the document maps.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlmapping.customxmlnode?view=word-pia"/>
  public Core.CustomXMLNode CustomXMLNode { get; }

  /// <summary>
  /// Returns a String that represents the XPath for the XML mapping, which evaluates to the currently mapped XML
  /// node. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlmapping.xpath?view=word-pia"/>
  public string XPath { get; }

  /// <summary>
  /// Returns a String that represents the prefix mappings used to evaluate the XPath for the current XML mapping.
  /// Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlmapping.prefixmappings?view=word-pia"/>
  public string PrefixMappings { get; }
}
