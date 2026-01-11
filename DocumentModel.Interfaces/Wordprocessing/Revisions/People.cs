namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a collection of person elements in a WordprocessingML document.
/// This interface provides access to and management of <see cref="Person"/> objects, enabling advanced organization and tracking of user metadata for collaborative editing and revision history.
/// </summary>
public interface People : ElementCollection<Person>
{
}