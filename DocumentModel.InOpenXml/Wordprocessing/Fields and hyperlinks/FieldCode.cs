namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a deleted field code within a WordprocessingML document. This class corresponds to the <c>DeletedFieldCode</c> element in the WordprocessingML schema and is used to represent field codes that have been marked as deleted in the document. The DeletedFieldCode class provides a strongly-typed representation for working with deleted field code content in Open XML word processing documents.
/// </summary>

[OpenXmlType(typeof(DXW.FieldCode))]
[DataContract]
[XmlRoot("FieldCode", Namespace = "DocumentModel.Wordprocessing")]
public class FieldCode : TextualElement<DXW.FieldCode>
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
        updatableElement.Text = text;
      else
      {
        updatableElement.Remove();
        SetUpdatableObject(null);
      }
    }
  }
}