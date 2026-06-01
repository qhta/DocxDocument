namespace DocumentModel.Wordprocessing;

/// <summary>
///  Represents a field code Iin a text run within a complex field Iin the document.
///  If this element is contained within a run which is not part of a complex field's field codes, 
///  then it and its contents should be treated as regular text. If this element is contained within a del element, 
///  then the document is non-conformant.
/// </summary>
public class FieldCode: TextualElement
{
}
