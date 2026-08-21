namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a textual element within a text run in WordprocessingML documents.
/// This class is used for inline text content, such as <see cref = "RunText"/> and <see cref = "FieldCode"/>, and provides properties for the text value and deletion status.
/// </summary>
[DataContract]
[XmlRoot("TextualElement", Namespace = "DocumentModel.Wordprocessing")]
[DirectAccess]
public abstract partial class TextualElement<T> : ModelElement<T>, ITextualElement, IRunContent where T : DX.OpenXmlElement
{

  /// <summary>
  /// Indicates whether this textual element is deleted.
  /// </summary>
  public bool? IsDeleted { get => _IsDeleted; set => UpdateField(ref _IsDeleted, value, nameof(IsDeleted)); }
  private bool? _IsDeleted;

  /// <summary>
  /// The text value represented by this element.
  /// </summary>
  [XmlText]
  public string? Text { get => GetText(); set => SetText(value); }

  /// <summary>
  /// Retrieves the text content of this textual element.
  /// </summary>
  /// <returns>Text content of the element</returns>
  public abstract string? GetText();

  /// <summary>
  /// Sets the text content of this textual element.
  /// </summary>
  /// <param name="text">The text content to set</param>
  public abstract void SetText(string? text);
}