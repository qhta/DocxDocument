namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the XML mapping on a ContentControl object between custom XML and a content control. An XML mapping is a link between the text in a content control and an XML element in the custom XML data store for this document.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlmapping?view=word-pia"/>
public partial interface XMLMapping : InteropObject
{
  /// <summary>
  /// The is mapped.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlmapping.ismapped?view=word-pia"/>
  public bool IsMapped { get; }

  /// <summary>
  /// The custom xmlpart.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlmapping.customxmlpart?view=word-pia"/>
  public Core.CustomXMLPart CustomXMLPart { get; }

  /// <summary>
  /// The custom xmlnode.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlmapping.customxmlnode?view=word-pia"/>
  public Core.CustomXMLNode CustomXMLNode { get; }

  /// <summary>
  /// The xpath.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlmapping.xpath?view=word-pia"/>
  public string XPath { get; }

  /// <summary>
  /// The prefix mappings.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlmapping.prefixmappings?view=word-pia"/>
  public string PrefixMappings { get; }
}
