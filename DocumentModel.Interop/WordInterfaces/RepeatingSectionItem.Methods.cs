namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.repeatingsectionitem?view=word-pia"/>
public partial interface IRepeatingSectionItem
{
  /// <summary>
  /// Deletes the specified repeating section item.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.repeatingsectionitem.delete?view=word-pia"/>
  public void Delete();

  /// <summary>
  /// Inserts a new repeating section item after the current item.
  /// </summary>
  /// <returns>The newly inserted <see cref="RepeatingSectionItem"/>.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.repeatingsectionitem.insertitemafter?view=word-pia"/>
  public RepeatingSectionItem InsertItemAfter();

}
