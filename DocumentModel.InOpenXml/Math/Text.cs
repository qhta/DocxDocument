namespace DocumentModel.Math;
/// <summary>
///   Text.
/// </summary>
[OpenXmlType(typeof(DXM.Text))]
[XmlRoot("Text", Namespace = "DocumentModel.Math")]
public class Text : DMW.TextualElement<DXM.Text>
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