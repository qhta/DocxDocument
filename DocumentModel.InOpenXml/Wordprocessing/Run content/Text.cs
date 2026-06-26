namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a text element within a document element in WordprocessingML documents.
/// This class is used for inline text content, enabling the representation and manipulation of textual data within runs, paragraphs, and other document structures.
/// </summary>

[OpenXmlType(typeof(DXW.Text))]
[XmlRoot("Text", Namespace = "DocumentModel.Wordprocessing")]
public class RunText : TextualElement<DXW.Text>
{
  /// <summary>
  /// Gets the text content of this Text element.
  /// </summary>
  /// <returns>The text content of this element.</returns>
  public override string? GetText()
  {
    return _UpdatableElement?.Text;
  }

  /// <summary>
  /// Sets the text content of this Text element.
  /// </summary>
  /// <param name="text">The text content to set.</param>
  public override void SetText(string? text)
  {
    if (_UpdatableElement != null)
    {
      if (text != null && text.Length > 0)
        _UpdatableElement.Text = text;
      else
      {
        _UpdatableElement.Remove();
        _UpdatableElement = null;
      }
    }
  }
}