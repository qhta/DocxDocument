namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single XML element applied to a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode?view=word-pia"/>
public partial interface XMLNode : InteropObject
{
  /// <summary>
  /// Returns a String that represents the name of the element without any prefix.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.basename?view=word-pia"/>
  public string BaseName { get; }

  /// <summary>
  /// Returns a Range object that represents the portion of a document that's contained in the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// Returns or sets a String that represents the text displayed for an XML element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.text?view=word-pia"/>
  public string Text { get; set; }

  /// <summary>
  /// Returns a String that represents the Uniform Resource Identifier (URI) of the schema namespace for the
  /// specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.namespaceuri?view=word-pia"/>
  public string NamespaceURI { get; }

  /// <summary>
  /// Returns a XMLNode object that represents the next element in the document that is at the same level as the
  /// specified element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.nextsibling?view=word-pia"/>
  public XMLNode NextSibling { get; }

  /// <summary>
  /// Returns a XMLNode object that represents the previous element in the document that is at the same level as the
  /// specified element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.previoussibling?view=word-pia"/>
  public XMLNode PreviousSibling { get; }

  /// <summary>
  /// Returns a XMLNode object that represents the parent element of the specified element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.parentnode?view=word-pia"/>
  public XMLNode ParentNode { get; }

  /// <summary>
  /// Returns a DiagramNode object that represents the first child node of a parent node.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.firstchild?view=word-pia"/>
  public XMLNode FirstChild { get; }

  /// <summary>
  /// Returns a DiagramNode object that represents the last child node of a parent node.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.lastchild?view=word-pia"/>
  public XMLNode LastChild { get; }

  /// <summary>
  /// Returns a Document object that represents the parent document of the specified XML element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.ownerdocument?view=word-pia"/>
  public Document OwnerDocument { get; }

  /// <summary>
  /// Returns a WdXMLNodeType constant that represents the type of node.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.nodetype?view=word-pia"/>
  public WdXMLNodeType NodeType { get; }

  /// <summary>
  /// Returns a XMLNodes collection that represents the child elements of a specified element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.childnodes?view=word-pia"/>
  public XMLNodes ChildNodes { get; }

  /// <summary>
  /// Returns a XMLNodes collection that represents the attributes for the specified element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.attributes?view=word-pia"/>
  public XMLNodes Attributes { get; }

  /// <summary>
  /// Returns or sets a String that represents the value of an attribute.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.nodevalue?view=word-pia"/>
  public string NodeValue { get; set; }

  /// <summary>
  /// Determines if the specified XML element has child elements.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.haschildnodes?view=word-pia"/>
  public bool HasChildNodes { get; }

  /// <summary>
  /// Returns a XMLChildNodeSuggestions collection that represents the list of allowed elements for the XMLNode
  /// object (which returns the child elements of a specified element).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.childnodesuggestions?view=word-pia"/>
  public XMLChildNodeSuggestions ChildNodeSuggestions { get; }

  /// <summary>
  /// Returns the level of the specified XML element within the hierarchy of elements applied to a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.level?view=word-pia"/>
  public WdXMLNodeLevel Level { get; }

  /// <summary>
  /// Returns a WdXMLValidationStatus constant that represents whether an element or attribute is valid according to
  /// the attached schema.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.validationstatus?view=word-pia"/>
  public WdXMLValidationStatus ValidationStatus { get; }

  /// <summary>
  /// Returns a SmartTag object that represents the smart tag associated with an XML element.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.smarttag?view=word-pia"/>
  public SmartTag SmartTag { get; }

  /// <summary>
  /// Returns or sets a String that represents the text displayed for an element that contains no text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.placeholdertext?view=word-pia"/>
  public string PlaceholderText { get; set; }

  /// <summary>
  /// Returns a String that represents the XML for the node in the Microsoft Office Word Open XML format. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.wordopenxml?view=word-pia"/>
  public string WordOpenXML { get; }
}
