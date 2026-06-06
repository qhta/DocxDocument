namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the collection of visible chart categories in the document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.categorycollection?view=word-pia"/>
public interface ICategoryCollection : IInteropObject, IInteropCollection<IChartCategory>
{
}
