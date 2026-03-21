namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Section objects in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.sections?view=word-pia"/>
public partial interface Sections : InteropObject, InteropCollection<Section>
{
  /// <summary>
  /// Returns the first.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.sections.first?view=word-pia"/>
  public Section First { get; }

  /// <summary>
  /// Returns the last.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.sections.last?view=word-pia"/>
  public Section Last { get; }

  /// <summary>
  /// Returns or sets the page setup.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.sections.pagesetup?view=word-pia"/>
  public PageSetup PageSetup { get; set; }
}
