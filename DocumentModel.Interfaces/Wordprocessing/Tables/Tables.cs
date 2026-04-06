namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of Table objects that represent the tables in a selection, range, or document.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tables?view=word-pia"/>
public partial interface ITables : IModelCollection<ITable>
{
  /// <summary>
  /// Returns the nesting level of the specified tables.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tables.nestinglevel?view=word-pia"/>
  public int NestingLevel { get; }
}
