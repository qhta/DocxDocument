namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the properties of a glossary document entry (DocPart) in a WordprocessingML document.
/// This interface provides properties for entry name, associated style, categorization, types, behaviors, description, and unique identifier, enabling advanced management, classification, and configuration of reusable document parts such as building blocks and autotext entries.
/// </summary>
public interface DocPartProperties
{
  /// <summary>
  /// Entry name, specifying the unique identifier or display name for the glossary document entry.
  /// </summary>
  public DocPartName? DocPartName { get; set; }

  /// <summary>
  /// Associated paragraph style name for the entry, linking the entry to a specific style.
  /// </summary>
  public string? StyleId { get; set; }

  /// <summary>
  /// Entry categorization, specifying the category and gallery for the entry.
  /// </summary>
  public Category? Category { get; set; }

  /// <summary>
  /// Entry types, specifying the types of document parts represented by the entry.
  /// </summary>
  public DocPartTypes? DocPartTypes { get; set; }

  /// <summary>
  /// Entry insertion behaviors, specifying how the entry behaves when inserted into a document.
  /// </summary>
  public Behaviors? Behaviors { get; set; }

  /// <summary>
  /// Description for the entry, providing additional information or context.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// Unique identifier for the entry.
  /// </summary>
  public string? DocPartId { get; set; }
}