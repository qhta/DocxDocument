namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a collection of recipient data elements for mail merge in a WordprocessingML document.
///   This interface provides access to and management of <see cref="RecipientData"/> objects, enabling advanced configuration and organization of recipient records for mail merge operations.
/// </summary>
public interface Recipients: IElementCollection<RecipientData>
{
}