namespace DocumentModel.Wordprocessing;

public partial interface TableRow
{
  /// <summary>
  /// Selects the row.
  /// </summary>
  public void Select();

  /// <summary>
  /// Deletes the row from the table.
  /// </summary>
  public void Delete();

  /// <summary>
  /// Converts the row to text.
  /// </summary>
  /// <param name="separator">Optional separator character.</param>
  /// <returns>Range containing the converted text.</returns>
  public Range? ConvertToText(string? separator = null);

  /// <summary>
  /// Sets the height of the row.
  /// </summary>
  /// <param name="height">Height in points.</param>
  /// <param name="heightRule">Height rule.</param>
  public void SetHeight(float height, HeightMeasureType heightRule);

}