namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linkformat?view=word-pia"/>
public partial interface ILinkFormat
{
  /// <summary>
  /// Breaks the link between the source file and the specified OLE object, picture, or linked field.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linkformat.breaklink?view=word-pia"/>
  public void BreakLink();
}
