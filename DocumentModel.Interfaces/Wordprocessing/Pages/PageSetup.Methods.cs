namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup?view=word-pia"/>
public partial interface IPageSetup : IModelObject
{
  /// <summary>
  /// Switches between portrait and landscape page orientations for a document or section.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.toggleportrait?view=word-pia"/>
  public void TogglePortrait();
}
