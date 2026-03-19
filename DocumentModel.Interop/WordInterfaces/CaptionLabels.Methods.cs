namespace DocumentModel.Interop.Word;

public partial interface CaptionLabels
{
  /// <summary>
  /// Adds a custom caption label to the collection.
  /// </summary>
  /// <param name="Name">The name of the caption label to add.</param>
  /// <returns>The created <see cref="CaptionLabel"/> object.</returns>
  public CaptionLabel Add(string Name);
}
