namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup?view=word-pia"/>
public partial interface PageSetup: InteropObject
{
  /// <summary>
  /// Switches between portrait and landscape page orientations for a document or section.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.toggleportrait?view=word-pia"/>
  public void TogglePortrait();
}
