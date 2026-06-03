namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the XML mapping on a ContentControl object between custom XML and a content control. An XML mapping
/// is a link between the text in a content control and an XML element in the custom XML data store for this
/// document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlmapping?view=word-pia"/>
public interface IXMLMapping : IInteropObject
{
  /// <summary>
  /// Returns a Boolean that represents whether the content control in the document is mapped to an XML node in the
  /// documentâ€™s XML data store. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlmapping.ismapped?view=word-pia"/>
  public bool IsMapped { get; }

  /// <summary>
  /// Returns a CustomXMLPart object that represents the custom XML part to which the content control in the
  /// document maps.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlmapping.customxmlpart?view=word-pia"/>
  public Core.ICustomXMLPart ICustomXMLPart { get; }

  /// <summary>
  /// Returns a CustomXMLNode object that represents the custom XML node in the data store to which the content
  /// control in the document maps.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlmapping.customxmlnode?view=word-pia"/>
  public Core.ICustomXMLNode ICustomXMLNode { get; }

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


  #region methods

/// <summary>
  /// Sets the XML mapping for the specified XPath, prefix mapping, and source.
  /// </summary>
  /// <param name="XPath">The XPath expression to map.</param>
  /// <param name="PrefixMapping">The prefix mapping for the XPath expression.</param>
  /// <param name="Source">The custom XML part to use as the source.</param>
  /// <returns>true if the mapping is set successfully; otherwise, false.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlmapping.setmapping?view=word-pia"/>
  public bool SetMapping(string XPath, string PrefixMapping, Core.ICustomXMLPart Source);

  #endregion methods
}
