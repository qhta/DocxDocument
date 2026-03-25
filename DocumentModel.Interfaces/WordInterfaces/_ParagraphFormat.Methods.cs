namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat?view=word-pia"/>
public partial interface _ParagraphFormat
{
  /// <summary>
  /// Removes any spacing before the specified paragraphs.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.closeup?view=word-pia"/>
  public void CloseUp();
}
