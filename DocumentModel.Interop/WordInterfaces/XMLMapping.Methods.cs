namespace DocumentModel.Interop;

public partial interface XMLMapping
{
  /// <summary>
  /// Sets the XML mapping for the specified XPath, prefix mapping, and source.
  /// </summary>
  /// <param name="XPath">The XPath expression to map.</param>
  /// <param name="PrefixMapping">The prefix mapping for the XPath expression.</param>
  /// <param name="Source">The custom XML part to use as the source.</param>
  /// <returns>true if the mapping is set successfully; otherwise, false.</returns>
  public bool SetMapping(string XPath, string PrefixMapping, Core.CustomXMLPart Source);
}
