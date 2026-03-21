namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of MappedDataField objects that represents all the mapped data fields available in Microsoft Word.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mappeddatafields?view=word-pia"/>
public partial interface MappedDataFields : InteropObject, IDictionary<WdMappedDataFields, MappedDataField>
{
}
