namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listgallery?view=word-pia"/>
public partial interface ListGallery: InteropObject
{
  /// <summary>
  /// Returns whether the specified list template in the gallery has been modified.
  /// </summary>
  /// <param name="Index">The index of the list template to check.</param>
  /// <returns>true if the template has been modified; otherwise, false.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listgallery.istemplatemodified?view=word-pia"/>
  public bool IsTemplateModified(int Index);
}
