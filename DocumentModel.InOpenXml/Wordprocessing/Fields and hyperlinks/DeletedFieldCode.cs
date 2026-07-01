namespace DocumentModel.Wordprocessing;
/// <summary>
///  Represents a field code in a text run within a complex field in the document.
///  If this element is contained within a run which is not part of a complex field's field codes, 
///  then it and its contents should be treated as regular text. If this element is contained within a del element, 
///  then the document is non-conformant.
/// </summary>
[OpenXmlType(typeof(DXW.DeletedFieldCode))]
[DataContract]
[XmlRoot("DeletedFieldCode", Namespace = "DocumentModel.Wordprocessing")]
public class DeletedFieldCode : TextualElement<DXW.FieldCode>
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