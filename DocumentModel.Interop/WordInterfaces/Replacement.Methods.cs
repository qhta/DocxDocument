namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.replacement?view=word-pia"/>
public partial interface Replacement
{
  /// <summary>
  /// Removes text and paragraph formatting from a selection or from the formatting specified in a find or replace
  /// operation.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.replacement.clearformatting?view=word-pia"/>
  public void ClearFormatting();
}
