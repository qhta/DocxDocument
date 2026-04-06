namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tables?view=word-pia"/>
public partial interface ITables: IModelObject
{
  /// <summary>
  /// Returns the value produced by the add old operation.
  /// </summary>
  /// <param name="Range">Specifies the range.</param>
  /// <param name="NumRows">Specifies the num rows.</param>
  /// <param name="NumColumns">Specifies the num columns.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tables.addold?view=word-pia"/>
  public ITable AddOld(IRange Range, int NumRows, int NumColumns);
}
