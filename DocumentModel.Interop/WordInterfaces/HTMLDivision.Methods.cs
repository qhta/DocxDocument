namespace DocumentModel.Interop.Word;

public partial interface HTMLDivision
{
  /// <summary>
  /// Returns a parent HTML division for the current HTML division.
  /// </summary>
  /// <param name="LevelsUp">The number of levels to move up in the HTML division hierarchy.</param>
  /// <returns>The parent <see cref="HTMLDivision"/> object.</returns>
  public HTMLDivision HTMLDivisionParent(int LevelsUp);
}
