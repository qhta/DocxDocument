namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the mapped data field objects available in Microsoft Word.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mappeddatafields?view=word-pia"/>
public partial interface IMappedDataFields : IModelObject, IDictionary<IMappedDataFields, IMappedDataField>
{
}
