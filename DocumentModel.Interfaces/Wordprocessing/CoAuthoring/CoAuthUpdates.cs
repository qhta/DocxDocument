namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of CoAuthUpdate objects that represent the available updates in the document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthupdates?view=word-pia"/>
public interface ICoAuthUpdates : IModelCollection<ICoAuthUpdate>
{
}
