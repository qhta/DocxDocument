namespace DocumentModel.Math;
/// <summary>
///   This element serves several functions (18 total) including that of the base argument 
///   of a mathematical object or function, the elements in an array, and the elements in boxes. 
///   If all subelements are omitted, this element specifies the presence of an empty argument. 
/// </summary>
[OpenXmlType(typeof(DXM.Argument))]
public abstract partial class Argument<T> : OfficeMathArgumentType<T> where T : DX.OpenXmlElement
{

}