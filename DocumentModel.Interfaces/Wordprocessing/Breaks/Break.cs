namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single page, column, or section break.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.break?view=word-pia"/>
public interface IBreak: IModelObject
{
  /// <summary>
  /// Gets the range that represents the break.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.break.range?view=word-pia"/>
  public Range Range { get; }
  /// <summary>
  /// Gets the page number that contains the break.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.break.pageindex?view=word-pia"/>
  public int PageIndex { get; }

}
