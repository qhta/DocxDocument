namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Table objects that represent the tables in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tables?view=word-pia"/>
public partial class Tables : InteropCollection<Table>
{
  /// <summary>
  /// Returns the nesting level of the specified tables.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tables.nestinglevel?view=word-pia"/>
  public int NestingLevel { get; set; }


  #region methods

/// <summary>
  /// Returns the value produced by the add old operation.
  /// </summary>
  /// <param name="range">Specifies the range.</param>
  /// <param name="numRows">Specifies the num rows.</param>
  /// <param name="numColumns">Specifies the num columns.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tables.addold?view=word-pia"/>
  public Table AddOld(Range range, int numRows, int numColumns) { throw new NotImplementedException(); }

  #endregion methods
}
