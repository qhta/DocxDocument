namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheet?view=word-pia"/>
public partial interface IStyleSheet
{
  /// <summary>
  /// Moves the style sheet to a new precedence level.
  /// </summary>
  /// <param name="Precedence">The new precedence for the style sheet.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheet.move?view=word-pia"/>
  public void Move(StyleSheetPrecedence Precedence);
}
