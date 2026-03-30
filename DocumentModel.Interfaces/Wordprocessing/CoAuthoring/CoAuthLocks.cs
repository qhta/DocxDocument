namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of CoAuthLock objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthlocks?view=word-pia"/>
public partial interface CoAuthLocks : IModelObject, IModelCollection<CoAuthLock>
{
}
