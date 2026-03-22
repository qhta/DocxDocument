namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset?view=word-pia"/>
public partial interface Frameset
{
  /// <summary>
  /// Returns the child frameset item.
  /// </summary>
  /// <param name="Index">Specifies the index.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.get_childframesetitem?view=word-pia"/>
  public Frameset ChildFramesetItem(int Index);

  /// <summary>
  /// Returns the value produced by the add new frame operation.
  /// </summary>
  /// <param name="Where">Specifies the where.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.addnewframe?view=word-pia"/>
  public Frameset AddNewFrame(WdFramesetNewFrameLocation Where);
}
