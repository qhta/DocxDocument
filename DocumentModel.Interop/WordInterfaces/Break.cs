namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents individual page, column, and section breaks in a page.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.break?view=word-pia"/>
public interface Break
{
  /// <summary>
  /// The range.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.break.range?view=word-pia"/>
  public Range Range { get; }
  /// <summary>
  /// The page index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.break.pageindex?view=word-pia"/>
  public int PageIndex { get; }

}
