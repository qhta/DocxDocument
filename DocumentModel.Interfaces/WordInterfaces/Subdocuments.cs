namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Subdocument objects that represent the subdocuments in a range or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.subdocuments?view=word-pia"/>
public partial interface Subdocuments : InteropObject, InteropCollection<Subdocument>
{
  /// <summary>
  /// True if the subdocuments in the specified document are expanded.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.subdocuments.expanded?view=word-pia"/>
  public bool Expanded { get; set; }
}
