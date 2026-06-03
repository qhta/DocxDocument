namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Table objects that represent the tables in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tables?view=word-pia"/>
public interface ITables : IInteropObject, IInteropCollection<ITable>
{
  /// <summary>
  /// Returns the nesting level of the specified tables.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tables.nestinglevel?view=word-pia"/>
  public int NestingLevel { get; }


  #region methods

/// <summary>
  /// Returns the value produced by the add old operation.
  /// </summary>
  /// <param name="range">Specifies the range.</param>
  /// <param name="NumRows">Specifies the num rows.</param>
  /// <param name="NumColumns">Specifies the num columns.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tables.addold?view=word-pia"/>
  public ITable AddOld(IRange range, int NumRows, int NumColumns);

  #endregion methods
}
