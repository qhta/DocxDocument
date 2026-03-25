namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the list gallery objects for the Bullets and Numbering dialog box tabs.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listgalleries?view=word-pia"/>
public partial interface ListGalleries : InteropObject, InteropCollection<ListGallery>
{
}
