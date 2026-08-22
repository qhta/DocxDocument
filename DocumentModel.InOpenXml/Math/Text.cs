namespace DocumentModel.Math;
/// <summary>
///   Text.
/// </summary>
[OpenXmlType(typeof(DXM.Text))]
[DataContract]
[XmlRoot("Text", Namespace = "DocumentModel.Math")]
public class Text : DMW.TextualElement<DXM.Text>
{
  /// <summary>
  /// Gets the text content of this Text element.
  /// </summary>
  /// <returns>The text content of this element.</returns>
  public override string? GetText()
  {
    return GetUpdatableElement()?.Text;
  }

  /// <summary>
  /// Sets the text content of this Text element.
  /// </summary>
  /// <param name="text">The text content to set.</param>
  public override void SetText(string? text)
  {
    var updatableElement = GetUpdatableElement();
    if (updatableElement != null)
    {
      if (text != null && text.Length > 0)
      {
        updatableElement.Text = text;
        UpdateXmlSpacePreserve(updatableElement, text);
      }
      else
      {
        updatableElement.Remove();
        SetUpdatableObject(null);
      }
    }
  }
}