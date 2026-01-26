using DocumentFormat.OpenXml.EMMA;

namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a carriage return character in a text run in WordprocessingML documents.
/// A carriage return is the equivalent of Unicode character 000D and is used to end the current line of text.
/// Its behavior is identical to a break character with null type and clear attributes, ending the current line and continuing on the next available line.
/// </summary>
[OpenXmlType(typeof(DXW.CarriageReturn))]
public class CarriageReturn : ModelElement<DXW.CarriageReturn>, IRunContent
{
}