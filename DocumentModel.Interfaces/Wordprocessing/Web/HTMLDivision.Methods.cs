namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.htmldivision?view=word-pia"/>
public partial interface IHTMLDivision: IModelObject
{
  /// <summary>
  /// Returns a parent HTML division for the current HTML division.
  /// </summary>
  /// <param name="LevelsUp">The number of levels to move up in the HTML division hierarchy.</param>
  /// <returns>The parent <see cref="IHTMLDivision"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.htmldivision.htmldivisionparent?view=word-pia"/>
  public IHTMLDivision HTMLDivisionParent(int LevelsUp);
}
