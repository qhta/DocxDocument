namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the node type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocustomxmlnodetype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoCustomXMLNodeType")]
public enum CustomXMLNodeType
{
  /// <summary>
  /// The node is an element.
  /// </summary>
  [OfficeInteropEnumValue("msoCustomXMLNodeElement")]
  Element = 1,
  /// <summary>
  /// The node is an attribute.
  /// </summary>
  [OfficeInteropEnumValue("msoCustomXMLNodeAttribute")]
  Attribute = 2,
  /// <summary>
  /// The node is a text node.
  /// </summary>
  [OfficeInteropEnumValue("msoCustomXMLNodeText")]
  Text = 3,
  /// <summary>
  /// The node is a CData type.
  /// </summary>
  [OfficeInteropEnumValue("msoCustomXMLNodeCData")]
  CData = 4,
  /// <summary>
  /// The node is a processing instruction.
  /// </summary>
  [OfficeInteropEnumValue("msoCustomXMLNodeProcessingInstruction")]
  ProcessingInstruction = 7,
  /// <summary>
  /// The node is a comment.
  /// </summary>
  [OfficeInteropEnumValue("msoCustomXMLNodeComment")]
  Comment = 8,
  /// <summary>
  /// The node is a Document node.
  /// </summary>
  [OfficeInteropEnumValue("msoCustomXMLNodeDocument")]
  Document = 9
}
