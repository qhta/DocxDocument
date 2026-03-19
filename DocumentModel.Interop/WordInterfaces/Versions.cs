namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Version objects that represent all the versions of a document. Corresponds to the items listed in the Versions dialog box (File menu).
/// </summary>
public partial interface Versions : InteropObject, InteropCollection<Version>
{
  /// <summary>
  /// The auto version.
  /// </summary>
  public WdAutoVersions AutoVersion { get; set; }
}
