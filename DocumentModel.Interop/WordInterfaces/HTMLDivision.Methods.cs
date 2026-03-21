namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.htmldivision?view=word-pia"/>
public partial interface HTMLDivision
{
  /// <summary>
  /// Returns a parent HTML division for the current HTML division.
  /// </summary>
  /// <param name="LevelsUp">The number of levels to move up in the HTML division hierarchy.</param>
  /// <returns>The parent <see cref="HTMLDivision"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.htmldivision.htmldivisionparent?view=word-pia"/>
  public HTMLDivision HTMLDivisionParent(int LevelsUp);
}
