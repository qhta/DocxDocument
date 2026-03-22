namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the node type.
/// </summary>
public enum MsoCustomXMLNodeType
{
  /// <summary>
  /// The node is an element.
  /// </summary>
  msoCustomXMLNodeElement = 1,
  /// <summary>
  /// The node is an attribute.
  /// </summary>
  msoCustomXMLNodeAttribute = 2,
  /// <summary>
  /// The node is a text node.
  /// </summary>
  msoCustomXMLNodeText = 3,
  /// <summary>
  /// The node is a CData type. msoCustomXMLNodeProcessingInstruction7 The node is a processing instruction.
  /// </summary>
  msoCustomXMLNodeCData = 4,
  /// <summary>
  /// Specifies the node type.
  /// </summary>
  msoCustomXMLNodeProcessingInstruction = 7,
  /// <summary>
  /// The node is a comment.
  /// </summary>
  msoCustomXMLNodeComment = 8,
  /// <summary>
  /// The node is a Document node.
  /// </summary>
  msoCustomXMLNodeDocument = 9
}
