namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a textual element of text run. There are two textual elements: Text and FieldCode
/// </summary>
public abstract class TextualElement: ModelElement, IRunContent
{
  /// <summary>
  ///   Indicates whether this element is deleted.
  /// </summary>
  [DefaultValue(false)]
  public bool IsDeleted {get; set; }

  /// <summary>
  /// Represents the text itself.
  /// </summary>
  [XmlText] public string Text { get; set; } = string.Empty;
}