namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the node type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocustomxmlnodetype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoCustomXMLNodeType))]
public enum CustomXMLNodeType
{
  /// <summary>
  /// The node is an element.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCustomXMLNodeType.msoCustomXMLNodeElement))]
  Element = 1,
  /// <summary>
  /// The node is an attribute.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCustomXMLNodeType.msoCustomXMLNodeAttribute))]
  Attribute = 2,
  /// <summary>
  /// The node is a text node.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCustomXMLNodeType.msoCustomXMLNodeText))]
  Text = 3,
  /// <summary>
  /// The node is a CData type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCustomXMLNodeType.msoCustomXMLNodeCData))]
  CData = 4,
  /// <summary>
  /// The node is a processing instruction.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCustomXMLNodeType.msoCustomXMLNodeProcessingInstruction))]
  ProcessingInstruction = 7,
  /// <summary>
  /// The node is a comment.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCustomXMLNodeType.msoCustomXMLNodeComment))]
  Comment = 8,
  /// <summary>
  /// The node is a Document node.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCustomXMLNodeType.msoCustomXMLNodeDocument))]
  Document = 9
}
