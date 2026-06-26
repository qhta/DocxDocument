namespace DocumentModel.Wordprocessing;
/// <summary>
///  Represents a field code in a text run within a complex field in the document.
///  If this element is contained within a run which is not part of a complex field's field codes, 
///  then it and its contents should be treated as regular text. If this element is contained within a del element, 
///  then the document is non-conformant.
/// </summary>
[OpenXmlType(typeof(DXW.DeletedFieldCode))]
[XmlRoot("DeletedFieldCode", Namespace = "DocumentModel.Wordprocessing")]
public class DeletedFieldCode : TextualElement<DXW.FieldCode>
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