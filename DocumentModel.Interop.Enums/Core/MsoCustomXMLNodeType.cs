namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the node type.
/// </summary>
public enum MsoCustomXMLNodeType
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
  /// The node is a CData type. msoCustomXMLNodeProcessingInstruction7 The node is a processing instruction.
  /// </summary>
  CData = 4,
  /// <summary>
  /// Specifies the node type.
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
