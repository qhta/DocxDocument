namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a collection of Source objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.sources?view=word-pia"/>
public partial class Sources : InteropCollection<Source>
{


  #region methods

/// <summary>
  /// Adds a new source to the collection.
  /// </summary>
  /// <param name="Data">The data for the new source.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.sources.add?view=word-pia"/>
  public void Add(string Data) { throw new NotImplementedException(); }

  #endregion methods
}
