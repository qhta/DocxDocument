namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the node type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocustomxmlnodetype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoCustomXMLNodeType")]
public enum CustomXMLNodeType
{
  /// <summary>
  /// The node is an element.
  /// </summary>
  [InteropEnumValue("msoCustomXMLNodeElement")]
  Element = 1,
  /// <summary>
  /// The node is an attribute.
  /// </summary>
  [InteropEnumValue("msoCustomXMLNodeAttribute")]
  Attribute = 2,
  /// <summary>
  /// The node is a text node.
  /// </summary>
  [InteropEnumValue("msoCustomXMLNodeText")]
  Text = 3,
  /// <summary>
  /// The node is a CData type.
  /// </summary>
  [InteropEnumValue("msoCustomXMLNodeCData")]
  CData = 4,
  /// <summary>
  /// The node is a processing instruction.
  /// </summary>
  [InteropEnumValue("msoCustomXMLNodeProcessingInstruction")]
  ProcessingInstruction = 7,
  /// <summary>
  /// The node is a comment.
  /// </summary>
  [InteropEnumValue("msoCustomXMLNodeComment")]
  Comment = 8,
  /// <summary>
  /// The node is a Document node.
  /// </summary>
  [InteropEnumValue("msoCustomXMLNodeDocument")]
  Document = 9
}
