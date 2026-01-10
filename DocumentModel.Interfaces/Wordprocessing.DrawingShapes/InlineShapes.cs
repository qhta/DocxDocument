namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a collection of inline shapes within a Wordprocessing document.
/// This interface provides access to and management of <see cref="InlineShape"/> elements, which are graphical objects embedded directly within the text flow.
/// </summary>
public interface InlineShapes : ElementCollection<InlineShape>
{
  
}