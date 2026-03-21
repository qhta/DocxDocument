namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single XML element applied to a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode?view=word-pia"/>
public partial interface XMLNode : InteropObject
{
  /// <summary>
  /// Returns the base name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.basename?view=word-pia"/>
  public string BaseName { get; }

  /// <summary>
  /// Returns the range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// Returns or sets the text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.text?view=word-pia"/>
  public string Text { get; set; }

  /// <summary>
  /// Returns the namespace u r i.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.namespaceuri?view=word-pia"/>
  public string NamespaceURI { get; }

  /// <summary>
  /// Returns the next sibling.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.nextsibling?view=word-pia"/>
  public XMLNode NextSibling { get; }

  /// <summary>
  /// Returns the previous sibling.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.previoussibling?view=word-pia"/>
  public XMLNode PreviousSibling { get; }

  /// <summary>
  /// Returns the parent node.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.parentnode?view=word-pia"/>
  public XMLNode ParentNode { get; }

  /// <summary>
  /// Returns the first child.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.firstchild?view=word-pia"/>
  public XMLNode FirstChild { get; }

  /// <summary>
  /// Returns the last child.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.lastchild?view=word-pia"/>
  public XMLNode LastChild { get; }

  /// <summary>
  /// Returns the owner document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.ownerdocument?view=word-pia"/>
  public Document OwnerDocument { get; }

  /// <summary>
  /// Returns the node type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.nodetype?view=word-pia"/>
  public WdXMLNodeType NodeType { get; }

  /// <summary>
  /// Returns the child nodes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.childnodes?view=word-pia"/>
  public XMLNodes ChildNodes { get; }

  /// <summary>
  /// Returns the attributes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.attributes?view=word-pia"/>
  public XMLNodes Attributes { get; }

  /// <summary>
  /// Returns or sets the node value.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.nodevalue?view=word-pia"/>
  public string NodeValue { get; set; }

  /// <summary>
  /// Returns whether child nodes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.haschildnodes?view=word-pia"/>
  public bool HasChildNodes { get; }

  /// <summary>
  /// Returns the child node suggestions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.childnodesuggestions?view=word-pia"/>
  public XMLChildNodeSuggestions ChildNodeSuggestions { get; }

  /// <summary>
  /// Returns the level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.level?view=word-pia"/>
  public WdXMLNodeLevel Level { get; }

  /// <summary>
  /// Returns the validation status.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.validationstatus?view=word-pia"/>
  public WdXMLValidationStatus ValidationStatus { get; }

  /// <summary>
  /// Returns the smart tag.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.smarttag?view=word-pia"/>
  public SmartTag SmartTag { get; }

  /// <summary>
  /// Returns or sets the placeholder text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.placeholdertext?view=word-pia"/>
  public string PlaceholderText { get; set; }

  /// <summary>
  /// Returns the word open x m l.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnode.wordopenxml?view=word-pia"/>
  public string WordOpenXML { get; }
}
