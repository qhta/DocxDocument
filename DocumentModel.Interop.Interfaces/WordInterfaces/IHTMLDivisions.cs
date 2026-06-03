namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a collection of HTML division objects in a web document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.htmldivisions?view=word-pia"/>
public interface IHTMLDivisions : IInteropObject, IInteropCollection<IHTMLDivision>
{
  /// <summary>
  /// Returns the nesting level of the HTML divisions collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.htmldivisions.nestinglevel?view=word-pia"/>
  public int NestingLevel { get; }


  #region methods

/// <summary>
  /// Adds a new HTMLDivision to the collection.
  /// </summary>
  /// <param name="range">The Range object that represents the range of the new HTMLDivision.</param>
  /// <returns>The newly created <see cref="IHTMLDivision"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.htmldivisions.add?view=word-pia"/>
  public IHTMLDivision Add(object range);

  #endregion methods
}
