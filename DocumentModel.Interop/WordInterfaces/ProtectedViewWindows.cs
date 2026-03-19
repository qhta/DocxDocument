namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of all the ProtectedViewWindow objects that are currently open in Word 2010.
/// </summary>
public partial interface ProtectedViewWindows : InteropObject, InteropCollection<ProtectedViewWindow>
{
}
