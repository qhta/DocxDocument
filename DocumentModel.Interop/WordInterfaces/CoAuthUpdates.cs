namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of CoAuthUpdate objects that represent the available updates in the document.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthupdates?view=word-pia"/>
public interface CoAuthUpdates : InteropObject, InteropCollection<CoAuthUpdate>
{
}
