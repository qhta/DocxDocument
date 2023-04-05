namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Represents a textual element of text run.
/// </summary>
public abstract class TextType: ModelElement, IRunContent
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