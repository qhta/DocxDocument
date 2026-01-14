namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a collection of field elements in a WordprocessingML document.
/// This interface provides access to and management of <see cref="Field"/> objects, enabling advanced automation, referencing, and dynamic content generation through the use of fields such as references, calculations, dates, and other automatically updated information within the document.
/// </summary>
public interface Fields: IElementCollection<Field>
{
  
}