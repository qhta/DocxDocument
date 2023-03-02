namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a textual element of text run.
/// </summary>
public abstract record TextType: RunElement
{
  /// <summary>
  ///   Indicates whether this element is deleted.
  /// </summary>
  [DefaultValue(false)]
  [XmlAttribute] public bool IsDeleted {get; set; }

  /// <summary>
  /// Represents the text itself.
  /// </summary>
  [XmlText] public string Text { get; set; } = string.Empty;
}