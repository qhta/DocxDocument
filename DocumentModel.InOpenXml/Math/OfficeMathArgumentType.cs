namespace DocumentModel.Math;
/// <summary>
///   Represents an argument type for Office Math elements, providing a model wrapper for OpenXml math argument types.
/// </summary>
/// <typeparam name = "OpenXmlType">The OpenXml math argument type being wrapped.</typeparam>
[XmlRoot("OfficeMathArgumentType", Namespace = "DocumentModel.Math")]
public class OfficeMathArgumentType<OpenXmlType> : ModelElement<OpenXmlType> //, IElementCollection<IMathArgumentContent>
 where OpenXmlType : DXM.OfficeMathArgumentType
{
}