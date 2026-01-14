namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the end of a single range permission within a WordprocessingML document.
/// This end marker is matched with the appropriately paired start marker by matching the value of the Id attribute from the associated permStart element, enabling advanced management and enforcement of document editing permissions for specific content ranges.
/// </summary>
public class PermEnd : MarkupRangeElement
{
}