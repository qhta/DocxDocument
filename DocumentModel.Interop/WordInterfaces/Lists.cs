namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of List objects that represent all the lists in the specified document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lists?view=word-pia"/>
public interface Lists : InteropObject, InteropCollection<List>
{
}
