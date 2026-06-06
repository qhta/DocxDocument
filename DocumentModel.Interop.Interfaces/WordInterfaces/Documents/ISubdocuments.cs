namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Subdocument objects that represent the subdocuments in a range or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.subdocuments?view=word-pia"/>
public interface ISubdocuments : IInteropObject, IInteropCollection<ISubdocument>
{
  /// <summary>
  /// True if the subdocuments in the specified document are expanded.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.subdocuments.expanded?view=word-pia"/>
  public bool Expanded { get; set; }


  #region methods

/// <summary>
  /// Adds a subdocument from a file to the collection.
  /// </summary>
  /// <param name="name">The name or path of the file to add as a subdocument.</param>
  /// <param name="confirmConversions">true to confirm file format conversions; otherwise, false.</param>
  /// <param name="readOnly">true to open the file as read-only; otherwise, false.</param>
  /// <param name="passwordDocument">The password for opening the document, if required.</param>
  /// <param name="passwordTemplate">The password for opening the template, if required.</param>
  /// <param name="revert">true to revert to the last saved version; otherwise, false.</param>
  /// <param name="writePasswordDocument">The write password for the document, if required.</param>
  /// <param name="writePasswordTemplate">The write password for the template, if required.</param>
  /// <returns>The created <see cref="ISubdocument"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.subdocuments.addfromfile?view=word-pia"/>
  public ISubdocument AddFromFile(string name, bool confirmConversions, bool readOnly, string passwordDocument, 
    string passwordTemplate, bool revert, string writePasswordDocument, string writePasswordTemplate);

  #endregion methods
}
