namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single gallery of list formats.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listgallery?view=word-pia"/>
public partial interface ListGallery : IModelObject
{
  /// <summary>
  /// Returns the list templates in the specified list gallery.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listgallery.listtemplates?view=word-pia"/>
  public ListTemplates ListTemplates { get; }
}
