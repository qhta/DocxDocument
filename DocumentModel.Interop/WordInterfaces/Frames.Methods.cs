namespace DocumentModel.Interop.Word;

public partial interface Frames
{
  /// <summary>
  /// Returns the value produced by the add operation.
  /// </summary>
  /// <param name="Range">Specifies the range.</param>
  /// <returns>The resulting value.</returns>
  public Frame Add(Range Range);

  /// <summary>
  /// Executes the delete operation.
  /// </summary>
  public void Delete();
}
