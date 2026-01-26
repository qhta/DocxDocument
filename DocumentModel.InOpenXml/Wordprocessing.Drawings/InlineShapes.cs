namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents a collection of inline shapes within a Wordprocessing document.
/// This class provides access to and management of <see cref = "InlineShape"/> elements, which are graphical objects embedded directly within the text flow.
/// </summary>
[OpenXmlType(typeof(InlineShape))]
public class InlineShapes : ElementCollection<InlineShape>
{
}