namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the presence of a simple field at the current location in a WordprocessingML document.
/// The semantics of this field are defined via its field codes. Simple fields provide a way to insert dynamic content, such as references, calculations, or dates, using a single field code instruction.
/// </summary>
public class SimpleField : SimpleField<DXW.SimpleField>
{
}
