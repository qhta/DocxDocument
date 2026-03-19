namespace DocumentModel.Interop.Word;

public partial interface DisplayUnitLabel
{
  /// <summary>
  /// Returns a ChartCharacters object that represents a range of characters in the display unit label text.
  /// </summary>
  /// <param name="Start">The starting character position.</param>
  /// <param name="Length">The number of characters to return.</param>
  /// <returns>The requested <see cref="ChartCharacters"/> range.</returns>
  public ChartCharacters get_Characters(object Start, object Length);

  /// <summary>
  /// Deletes the display unit label.
  /// </summary>
  public void Delete();
}
