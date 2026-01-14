namespace DocumentModel;

/// <summary>
///   Represents a collection of alternate content choices that provide different rendering options for content.
/// </summary>
/// <remarks>
///   This interface extends <see cref="ElementCollection{ItemType}"/> of <see cref="AlternateContentChoice"/> and defines
///   a collection of content choice options within an <see cref="IAlternateContent"/> structure. Each choice in the
///   collection represents a different way to render or represent content, with associated requirements that specify
///   when that choice should be selected. The collection is evaluated in order, with the first choice whose requirements
///   are satisfied being selected for rendering by the Office application. This ordered evaluation mechanism enables
///   documents to provide progressively more sophisticated content representations, starting with choices that require
///   the latest features or capabilities and falling back to simpler choices if those requirements cannot be met.
///   The collection works in conjunction with the <see cref="IAlternateContent.Fallback"/> property to provide complete
///   forward compatibility: if none of the choices in this collection can be satisfied, the fallback content is used.
///   Common scenarios include ordering choices from most advanced to least advanced (such as 3D model, then 2D rendered
///   image, then placeholder), or from most feature-rich to most compatible (such as advanced chart type, then basic
///   chart type, then static image). The choice collection mechanism is fundamental to Office's ability to introduce
///   new content types and features while maintaining document compatibility across different application versions.
///   Each <see cref="AlternateContentChoice"/> in the collection contains both a requirement specification (typically
///   a namespace UriString) and the actual content items to display when that choice is selected.
/// </remarks>
public interface AlternateContentChoiceCollection: IElementCollection<AlternateContentChoice>
{

}