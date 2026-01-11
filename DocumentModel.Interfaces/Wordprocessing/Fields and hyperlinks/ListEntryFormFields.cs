namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a collection of list entry form fields for a drop-down list in a WordprocessingML document.
/// This interface provides access to and management of <see cref="ListEntryFormField"/> objects, enabling advanced configuration and organization of selectable options within interactive drop-down lists in forms and documents.
/// </summary>
public interface ListEntryFormFields : ElementCollection<ListEntryFormField>
{
}