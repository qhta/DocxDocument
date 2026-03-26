namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the node type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocustomxmlnodetype?view=office-pia` for Office interop details.
/// </remarks>
public enum CustomXMLNodeType
{
  /// <summary>
  /// The node is an element.
  /// </summary>
  Element = 1,
  /// <summary>
  /// The node is an attribute.
  /// </summary>
  Attribute = 2,
  /// <summary>
  /// The node is a text node.
  /// </summary>
  Text = 3,
  /// <summary>
  /// The node is a CData type.
  /// </summary>
  CData = 4,
  /// <summary>
  /// The node is a processing instruction.
  /// </summary>
  ProcessingInstruction = 7,
  /// <summary>
  /// The node is a comment.
  /// </summary>
  Comment = 8,
  /// <summary>
  /// The node is a Document node.
  /// </summary>
  Document = 9
}
