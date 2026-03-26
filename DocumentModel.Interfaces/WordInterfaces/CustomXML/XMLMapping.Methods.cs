namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlmapping?view=word-pia"/>
public partial interface XMLMapping: InteropObject
{
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
  public bool SetMapping(string XPath, string PrefixMapping, Core.CustomXMLPart Source);
}
