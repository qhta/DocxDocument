namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of ListGallery objects that represent the three tabs in the Bullets and Numbering dialog box.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listgalleries?view=word-pia"/>
public partial interface ListGalleries : InteropObject, InteropCollection<ListGallery>
{
}
