namespace DocumentModel.Interop.Word;

public partial interface RepeatingSectionItem
{
  /// <summary>
  /// Deletes the repeating section item.
  /// </summary>
  public void Delete();

  /// <summary>
  /// Inserts a new repeating section item after the current item.
  /// </summary>
  /// <returns>The newly inserted <see cref="RepeatingSectionItem"/>.</returns>
  public RepeatingSectionItem InsertItemAfter();

}
