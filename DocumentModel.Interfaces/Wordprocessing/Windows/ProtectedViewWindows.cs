namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of all the ProtectedViewWindow objects that are currently open in Word 2010.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindows?view=word-pia"/>
public partial interface ProtectedViewWindows : IModelCollection<ProtectedViewWindow>
{
}
