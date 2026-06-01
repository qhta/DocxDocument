namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axistitle?view=word-pia"/>
public partial class AxisTitle
{
  /// <summary>
  /// Returns a ChartCharacters object that represents a range of characters in the axis title text.
  /// </summary>
  /// <param name="Start">The starting character position.</param>
  /// <param name="Length">The number of characters to return.</param>
  /// <returns>The requested <see cref="ChartCharacters"/> range.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axistitle.get_characters?view=word-pia"/>
  public ChartCharacters Characters(object Start, object Length) { throw new NotImplementedException(); }

  /// <summary>
  /// Deletes the object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axistitle.delete?view=word-pia"/>
  public void Delete() { throw new NotImplementedException(); }
}
