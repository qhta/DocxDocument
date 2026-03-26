namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey?view=word-pia"/>
public partial interface LegendKey: InteropObject
{
  /// <summary>
  /// Clears the formatting of the object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.clearformats?view=word-pia"/>
  public void ClearFormats();
}
