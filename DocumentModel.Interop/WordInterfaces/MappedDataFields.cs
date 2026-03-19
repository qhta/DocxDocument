namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of MappedDataField objects that represents all the mapped data fields available in Microsoft Word.
/// </summary>
public partial interface MappedDataFields : InteropObject, IDictionary<WdMappedDataFields, MappedDataField>
{
}
