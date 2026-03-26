namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of Section objects in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.sections?view=word-pia"/>
public partial interface Sections : InteropObject, InteropCollection<Section>
{
  /// <summary>
  /// Returns a Section object that represents the first item in the Sections collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.sections.first?view=word-pia"/>
  public Section First { get; }

  /// <summary>
  /// Returns the last item in the Sections collection as a Section object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.sections.last?view=word-pia"/>
  public Section Last { get; }

  /// <summary>
  /// Returns a PageSetup object that's associated with the specified sections
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.sections.pagesetup?view=word-pia"/>
  public PageSetup PageSetup { get; set; }
}
