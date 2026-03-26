namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of Version objects that represent all the versions of a document. Corresponds to the items listed
/// in the Versions dialog box (File menu).
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.versions?view=word-pia"/>
public partial interface Versions : InteropObject, InteropCollection<Version>
{
  /// <summary>
  /// Returns or sets the state of the option for automatically saving document versions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.versions.autoversion?view=word-pia"/>
  public AutoVersions AutoVersion { get; set; }
}
