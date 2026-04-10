namespace DocumentModel.Math;
/// <summary>
///   Represents the base component of a mathematical object, such as the base of a fraction, radical, or subscript in Office Math.
/// </summary>
[OpenXmlType(typeof(DXM.Base))]
[XmlRoot("Base", Namespace = "DocumentModel.Math")]
public class Base : OfficeMathArgumentType<DXM.Base>
{
}