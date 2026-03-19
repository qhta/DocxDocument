namespace DocumentModel.Interop.Word;

public partial interface Frameset
{
  /// <summary>
  /// Returns the child frameset item.
  /// </summary>
  /// <param name="Index">Specifies the index.</param>
  /// <returns>The resulting value.</returns>
  public Frameset get_ChildFramesetItem(int Index);

  /// <summary>
  /// Returns the value produced by the add new frame operation.
  /// </summary>
  /// <param name="Where">Specifies the where.</param>
  /// <returns>The resulting value.</returns>
  public Frameset AddNewFrame(WdFramesetNewFrameLocation Where);
}
