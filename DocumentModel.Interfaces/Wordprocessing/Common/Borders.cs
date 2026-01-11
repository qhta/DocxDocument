namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a collection of border definitions in a WordprocessingML document.
/// This interface is used to organize and manage multiple <see cref="Border"/> objects, enabling advanced formatting and visual separation of document content through the application of various border styles, colors, and effects.
/// </summary>
public interface Borders : ElementCollection<Border>
{
  
}