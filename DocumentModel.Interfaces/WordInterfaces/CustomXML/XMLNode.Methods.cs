namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode?view=word-pia"/>
public partial interface XMLNode: InteropObject
{
  /// <summary>
  /// Gets the XML representation of the node.
  /// </summary>
  /// <param name="DataOnly">true to return only the data; otherwise, false.</param>
  /// <returns>The XML string for the node.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.xml?view=word-pia"/>
  public string XML(bool DataOnly);

  /// <summary>
  /// Gets the validation error text for the node.
  /// </summary>
  /// <param name="Advanced">true to return advanced error information; otherwise, false.</param>
  /// <returns>The validation error text as a string.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.validationerrortext?view=word-pia"/>
  public string ValidationErrorText(bool Advanced);

  /// <summary>
  /// Selects a single XML node using the specified XPath expression.
  /// </summary>
  /// <param name="XPath">The XPath expression to evaluate.</param>
  /// <param name="PrefixMapping">The prefix mapping for the XPath expression.</param>
  /// <param name="FastSearchSkippingTextNodes">true to skip text nodes during the search; otherwise, false.</param>
  /// <returns>The selected <see cref="XMLNode"/> object, or null if not found.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.selectsinglenode?view=word-pia"/>
  public XMLNode SelectSingleNode(string XPath, string PrefixMapping, bool FastSearchSkippingTextNodes);
}
