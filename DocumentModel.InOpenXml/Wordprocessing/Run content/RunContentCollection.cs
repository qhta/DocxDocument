namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a collection of run content elements in a WordprocessingML document.
/// This class provides access to and management of <see cref="IRunContent"/> objects, enabling advanced organization and manipulation of inline content such as text, breaks, fields, and other run-level elements within paragraphs.
/// </summary>
public class RunContentCollection: ElementCollection<IRunContent>
{

}