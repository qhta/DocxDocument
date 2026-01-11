namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a collection of custom tab stop elements in a WordprocessingML document.
/// This interface provides access to and management of <see cref="TabStop"/> objects, enabling advanced control over tab alignment, leader characters, and tab stop positions within paragraphs.
/// </summary>
public interface Tabs : ElementCollection<TabStop>
{
    
}