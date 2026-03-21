namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a style used to build a table of contents or figures.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headingstyle?view=word-pia"/>
public partial interface HeadingStyle : InteropObject
{
  /// <summary>
  /// The style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headingstyle.style?view=word-pia"/>
  public object Style { get; set; }

  /// <summary>
  /// The level.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headingstyle.level?view=word-pia"/>
  public short Level { get; set; }
}
