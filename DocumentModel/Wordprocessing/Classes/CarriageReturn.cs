namespace DocumentModel.Wordprocessing;

/// <summary>
///  Represents a carriage return character in a text run. 
///  A carriage return is the equivalent of Unicode character 000D, and is used to end the current line of text.
/// The behavior of a carriage return in run content shall be identical to a break character with null type and clear attributes, 
/// which shall end the current line and find the next available line on which to continue.
/// </summary>
public class CarriageReturn: ModelElement, IRunElement
{
}