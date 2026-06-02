namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a collection of HTML division objects in a web document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.htmldivisions?view=word-pia"/>
public partial interface IHTMLDivisions : IInteropObject, IInteropCollection<HTMLDivision>
{
  /// <summary>
  /// Returns the nesting level of the HTML divisions collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.htmldivisions.nestinglevel?view=word-pia"/>
  public int NestingLevel { get; }
}
