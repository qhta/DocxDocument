namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the collection of visible chart categories in the document.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.categorycollection?view=word-pia"/>
public interface CategoryCollection : InteropObject, InteropCollection<ChartCategory>
{
}
