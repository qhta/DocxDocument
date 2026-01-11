namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a textual element within a text run in WordprocessingML documents.
/// This interface is used for inline text content, such as <see cref="Text"/> and <see cref="FieldCode"/>, and provides properties for the text value and deletion status.
/// </summary>
public interface TextualElement : RunContent
{
  
  /// <summary>
  /// Indicates whether this textual element is deleted.
  /// </summary>
  [DefaultValue(false)]
  public bool IsDeleted { get; set; }
  
  /// <summary>
  /// The text value represented by this element.
  /// </summary>
  [XmlText]
  public string Text { get; set; }
}