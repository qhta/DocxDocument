namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single XML element applied to a document.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode?view=word-pia"/>
public partial interface XMLNode : InteropObject
{
  /// <summary>
  /// The base name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.basename?view=word-pia"/>
  public string BaseName { get; }

  /// <summary>
  /// The range.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// The text.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.text?view=word-pia"/>
  public string Text { get; set; }

  /// <summary>
  /// The namespace uri.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.namespaceuri?view=word-pia"/>
  public string NamespaceURI { get; }

  /// <summary>
  /// The next sibling.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.nextsibling?view=word-pia"/>
  public XMLNode NextSibling { get; }

  /// <summary>
  /// The previous sibling.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.previoussibling?view=word-pia"/>
  public XMLNode PreviousSibling { get; }

  /// <summary>
  /// The parent node.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.parentnode?view=word-pia"/>
  public XMLNode ParentNode { get; }

  /// <summary>
  /// The first child.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.firstchild?view=word-pia"/>
  public XMLNode FirstChild { get; }

  /// <summary>
  /// The last child.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.lastchild?view=word-pia"/>
  public XMLNode LastChild { get; }

  /// <summary>
  /// The owner document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.ownerdocument?view=word-pia"/>
  public Document OwnerDocument { get; }

  /// <summary>
  /// The node type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.nodetype?view=word-pia"/>
  public WdXMLNodeType NodeType { get; }

  /// <summary>
  /// The child nodes.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.childnodes?view=word-pia"/>
  public XMLNodes ChildNodes { get; }

  /// <summary>
  /// The attributes.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.attributes?view=word-pia"/>
  public XMLNodes Attributes { get; }

  /// <summary>
  /// The node value.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.nodevalue?view=word-pia"/>
  public string NodeValue { get; set; }

  /// <summary>
  /// The has child nodes.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.haschildnodes?view=word-pia"/>
  public bool HasChildNodes { get; }

  /// <summary>
  /// The child node suggestions.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.childnodesuggestions?view=word-pia"/>
  public XMLChildNodeSuggestions ChildNodeSuggestions { get; }

  /// <summary>
  /// The level.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.level?view=word-pia"/>
  public WdXMLNodeLevel Level { get; }

  /// <summary>
  /// The validation status.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.validationstatus?view=word-pia"/>
  public WdXMLValidationStatus ValidationStatus { get; }

  /// <summary>
  /// The smart tag.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.smarttag?view=word-pia"/>
  public SmartTag SmartTag { get; }

  /// <summary>
  /// The placeholder text.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.placeholdertext?view=word-pia"/>
  public string PlaceholderText { get; set; }

  /// <summary>
  /// The word open xml.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.wordopenxml?view=word-pia"/>
  public string WordOpenXML { get; }
}
