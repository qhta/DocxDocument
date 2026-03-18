namespace DocumentModel.Interop;

public partial interface XMLNode
{
  /// <summary>
  /// Gets the XML representation of the node.
  /// </summary>
  /// <param name="DataOnly">true to return only the data; otherwise, false.</param>
  /// <returns>The XML string for the node.</returns>
  public string XML(bool DataOnly);

  /// <summary>
  /// Gets the validation error text for the node.
  /// </summary>
  /// <param name="Advanced">true to return advanced error information; otherwise, false.</param>
  /// <returns>The validation error text as a string.</returns>
  public string ValidationErrorText(bool Advanced);

  /// <summary>
  /// Selects a single XML node using the specified XPath expression.
  /// </summary>
  /// <param name="XPath">The XPath expression to evaluate.</param>
  /// <param name="PrefixMapping">The prefix mapping for the XPath expression.</param>
  /// <param name="FastSearchSkippingTextNodes">true to skip text nodes during the search; otherwise, false.</param>
  /// <returns>The selected <see cref="XMLNode"/> object, or null if not found.</returns>
  public XMLNode SelectSingleNode(string XPath, string PrefixMapping, bool FastSearchSkippingTextNodes);
}
