namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Table objects that represent the tables in a selection, range, or document.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tables?view=word-pia"/>
public partial interface Tables : InteropObject, InteropCollection<Table>
{
  /// <summary>
  /// The nesting level.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tables.nestinglevel?view=word-pia"/>
  public int NestingLevel { get; }
}
