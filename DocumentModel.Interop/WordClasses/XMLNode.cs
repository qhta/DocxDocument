namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single XML element applied to a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode?view=word-pia"/>
public partial class XMLNode : InteropObject
{
  /// <summary>
  /// Returns a String that represents the name of the element without any prefix.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.basename?view=word-pia"/>
  public string? BaseName { get; set; }

  /// <summary>
  /// Returns a Range object that represents the portion of a document that's contained in the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.range?view=word-pia"/>
  public Range Range { get; set; }

  /// <summary>
  /// Returns or sets a String that represents the text displayed for an XML element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.text?view=word-pia"/>
  public string? Text { get; set; }

  /// <summary>
  /// Returns a String that represents the Uniform Resource Identifier (URI) of the schema namespace for the
  /// specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.namespaceuri?view=word-pia"/>
  public string? NamespaceURI { get; set; }

  /// <summary>
  /// Returns a XMLNode object that represents the next element in the document that is at the same level as the
  /// specified element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.nextsibling?view=word-pia"/>
  public XMLNode NextSibling { get; set; }

  /// <summary>
  /// Returns a XMLNode object that represents the previous element in the document that is at the same level as the
  /// specified element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.previoussibling?view=word-pia"/>
  public XMLNode PreviousSibling { get; set; }

  /// <summary>
  /// Returns a XMLNode object that represents the parent element of the specified element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.parentnode?view=word-pia"/>
  public XMLNode ParentNode { get; set; }

  /// <summary>
  /// Returns a DiagramNode object that represents the first child node of a parent node.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.firstchild?view=word-pia"/>
  public XMLNode FirstChild { get; set; }

  /// <summary>
  /// Returns a DiagramNode object that represents the last child node of a parent node.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.lastchild?view=word-pia"/>
  public XMLNode LastChild { get; set; }

  /// <summary>
  /// Returns a Document object that represents the parent document of the specified XML element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.ownerdocument?view=word-pia"/>
  public Document OwnerDocument { get; set; }

  /// <summary>
  /// Returns a XMLNodeType constant that represents the type of node.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.nodetype?view=word-pia"/>
  public XMLNodeType NodeType { get; set; }

  /// <summary>
  /// Returns a XMLNodes collection that represents the child elements of a specified element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.childnodes?view=word-pia"/>
  public XMLNodes ChildNodes { get; set; }

  /// <summary>
  /// Returns a XMLNodes collection that represents the attributes for the specified element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.attributes?view=word-pia"/>
  public XMLNodes Attributes { get; set; }

  /// <summary>
  /// Returns or sets a String that represents the value of an attribute.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.nodevalue?view=word-pia"/>
  public string? NodeValue { get; set; }

  /// <summary>
  /// Determines if the specified XML element has child elements.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.haschildnodes?view=word-pia"/>
  public bool HasChildNodes { get; set; }

  /// <summary>
  /// Returns a XMLChildNodeSuggestions collection that represents the list of allowed elements for the XMLNode
  /// object (which returns the child elements of a specified element).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.childnodesuggestions?view=word-pia"/>
  public XMLChildNodeSuggestions ChildNodeSuggestions { get; set; }

  /// <summary>
  /// Returns the level of the specified XML element within the hierarchy of elements applied to a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.level?view=word-pia"/>
  public XMLNodeLevel Level { get; set; }

  /// <summary>
  /// Returns a XMLValidationStatus constant that represents whether an element or attribute is valid according to
  /// the attached schema.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.validationstatus?view=word-pia"/>
  public XMLValidationStatus ValidationStatus { get; set; }

  /// <summary>
  /// Returns a SmartTag object that represents the smart tag associated with an XML element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.smarttag?view=word-pia"/>
  public SmartTag SmartTag { get; set; }

  /// <summary>
  /// Returns or sets a String that represents the text displayed for an element that contains no text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.placeholdertext?view=word-pia"/>
  public string? PlaceholderText { get; set; }

  /// <summary>
  /// Returns a String that represents the XML for the node in the Microsoft Office Word Open XML format. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.wordopenxml?view=word-pia"/>
  public string? WordOpenXML { get; set; }


  #region methods

/// <summary>
  /// Gets the XML representation of the node.
  /// </summary>
  /// <param name="DataOnly">true to return only the data; otherwise, false.</param>
  /// <returns>The XML string for the node.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.xml?view=word-pia"/>
  public string? XML(bool DataOnly) { throw new NotImplementedException(); }

  /// <summary>
  /// Gets the validation error text for the node.
  /// </summary>
  /// <param name="Advanced">true to return advanced error information; otherwise, false.</param>
  /// <returns>The validation error text as a string.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.validationerrortext?view=word-pia"/>
  public string? ValidationErrorText(bool Advanced) { throw new NotImplementedException(); }

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
  public XMLNode SelectSingleNode(string XPath, string PrefixMapping, bool FastSearchSkippingTextNodes) { throw new NotImplementedException(); }

  #endregion methods
}
