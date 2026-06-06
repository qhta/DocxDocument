namespace DocumentModel.Interop.Word;	
/// <summary>
/// Represents a repeating section item in a content control.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.repeatingsectionitem?view=word-pia"/>
public interface IRepeatingSectionItem : IInteropObject
{
  /// <summary>
  /// Returns the range of the specified repeating section item, excluding the start and end tags. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.repeatingsectionitem.range?view=word-pia"/>
  public IRange range { get; }	

  #region methods	
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
  /// <returns>The newly inserted <see cref="IRepeatingSectionItem"/>.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.repeatingsectionitem.insertitemafter?view=word-pia"/>
  public IRepeatingSectionItem InsertItemAfter();	
  #endregion methods
}
