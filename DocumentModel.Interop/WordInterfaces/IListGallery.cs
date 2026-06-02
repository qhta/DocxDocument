namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single gallery of list formats.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listgallery?view=word-pia"/>
public interface IListGallery : IInteropObject
{
  /// <summary>
  /// Returns the list templates in the specified list gallery.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listgallery.listtemplates?view=word-pia"/>
  public ListTemplates ListTemplates { get; }


  #region methods

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

  #endregion methods
}
