namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single XML element applied to a document.
/// </summary>
public partial interface XMLNode : InteropObject
{
  /// <summary>
  /// The base name.
  /// </summary>
  public string BaseName { get; }

  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }

  /// <summary>
  /// The text.
  /// </summary>
  public string Text { get; set; }

  /// <summary>
  /// The namespace uri.
  /// </summary>
  public string NamespaceURI { get; }

  /// <summary>
  /// The next sibling.
  /// </summary>
  public XMLNode NextSibling { get; }

  /// <summary>
  /// The previous sibling.
  /// </summary>
  public XMLNode PreviousSibling { get; }

  /// <summary>
  /// The parent node.
  /// </summary>
  public XMLNode ParentNode { get; }

  /// <summary>
  /// The first child.
  /// </summary>
  public XMLNode FirstChild { get; }

  /// <summary>
  /// The last child.
  /// </summary>
  public XMLNode LastChild { get; }

  /// <summary>
  /// The owner document.
  /// </summary>
  public Document OwnerDocument { get; }

  /// <summary>
  /// The node type.
  /// </summary>
  public WdXMLNodeType NodeType { get; }

  /// <summary>
  /// The child nodes.
  /// </summary>
  public XMLNodes ChildNodes { get; }

  /// <summary>
  /// The attributes.
  /// </summary>
  public XMLNodes Attributes { get; }

  /// <summary>
  /// The node value.
  /// </summary>
  public string NodeValue { get; set; }

  /// <summary>
  /// The has child nodes.
  /// </summary>
  public bool HasChildNodes { get; }

  /// <summary>
  /// The child node suggestions.
  /// </summary>
  public XMLChildNodeSuggestions ChildNodeSuggestions { get; }

  /// <summary>
  /// The level.
  /// </summary>
  public WdXMLNodeLevel Level { get; }

  /// <summary>
  /// The validation status.
  /// </summary>
  public WdXMLValidationStatus ValidationStatus { get; }

  /// <summary>
  /// The smart tag.
  /// </summary>
  public SmartTag SmartTag { get; }

  /// <summary>
  /// The placeholder text.
  /// </summary>
  public string PlaceholderText { get; set; }

  /// <summary>
  /// The word open xml.
  /// </summary>
  public string WordOpenXML { get; }
}
