namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of HTMLDivision objects that represents the HTML divisions that exist in a Web document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.htmldivisions?view=word-pia"/>
public partial interface HTMLDivisions : InteropObject, InteropCollection<HTMLDivision>
{
  /// <summary>
  /// The nesting level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.htmldivisions.nestinglevel?view=word-pia"/>
  public int NestingLevel { get; }
}
