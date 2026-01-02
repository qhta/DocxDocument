namespace DocumentModel.Wordprocessing;
/// <summary>
///   This element specifies the end of a single range permission within a WordprocessingML document. 
///   This end marker is matched with the appropriately paired start marker 
///   by matching the value of the Id attribute from the associated permStart element.
/// </summary>
public class PermEnd: MarkupRangeElement, ICommonContent
{
}