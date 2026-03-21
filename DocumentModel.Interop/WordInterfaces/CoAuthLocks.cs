namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of CoAuthLock objects.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthlocks?view=word-pia"/>
public partial interface CoAuthLocks : InteropObject, InteropCollection<CoAuthLock>
{
}
