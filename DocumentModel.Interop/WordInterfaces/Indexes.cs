namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Index objects that represents all the indexes in the specified document.
/// </summary>
public partial interface Indexes : InteropObject, InteropCollection<Index>
{
  /// <summary>
  /// The format.
  /// </summary>
  public WdIndexFormat Format { get; set; }
}
