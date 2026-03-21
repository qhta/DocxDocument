namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the XML mapping on a ContentControl object between custom XML and a content control. An XML mapping is a link between the text in a content control and an XML element in the custom XML data store for this document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlmapping?view=word-pia"/>
public partial interface XMLMapping : InteropObject
{
  /// <summary>
  /// Returns whether mapped.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlmapping.ismapped?view=word-pia"/>
  public bool IsMapped { get; }

  /// <summary>
  /// Returns the custom x m l part.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlmapping.customxmlpart?view=word-pia"/>
  public Core.CustomXMLPart CustomXMLPart { get; }

  /// <summary>
  /// Returns the custom x m l node.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlmapping.customxmlnode?view=word-pia"/>
  public Core.CustomXMLNode CustomXMLNode { get; }

  /// <summary>
  /// Returns the x path.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlmapping.xpath?view=word-pia"/>
  public string XPath { get; }

  /// <summary>
  /// Returns the prefix mappings.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlmapping.prefixmappings?view=word-pia"/>
  public string PrefixMappings { get; }
}
