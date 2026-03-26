namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.captionlabels?view=word-pia"/>
public partial interface CaptionLabels: InteropObject
{
  /// <summary>
  /// Adds a custom caption label to the collection.
  /// </summary>
  /// <param name="Name">The name of the caption label to add.</param>
  /// <returns>The created <see cref="CaptionLabel"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.captionlabels.add?view=word-pia"/>
  public CaptionLabel Add(string Name);
}
