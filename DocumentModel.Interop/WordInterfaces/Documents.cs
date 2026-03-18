namespace DocumentModel.Interop;

/// <summary>
/// A collection of all the Document objects that are currently open in Word.
/// </summary>
public partial interface Documents : InteropObject, InteropCollection<Document>
{
}
