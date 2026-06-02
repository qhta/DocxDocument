namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single HTML division in a web document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.htmldivision?view=word-pia"/>
public partial interface IHTMLDivision : IInteropObject
{
  /// <summary>
  /// Returns a range object that represents the contents of the HTML division.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.htmldivision.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// Returns a borders collection that represents the borders for the HTML division.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.htmldivision.borders?view=word-pia"/>
  public Borders Borders { get; }

  /// <summary>
  /// Returns or sets the left indent value, in points, for the HTML division.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.htmldivision.leftindent?view=word-pia"/>
  public float LeftIndent { get; set; }

  /// <summary>
  /// Returns or sets the right indent value, in points, for the HTML division.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.htmldivision.rightindent?view=word-pia"/>
  public float RightIndent { get; set; }

  /// <summary>
  /// Returns or sets the spacing, in points, before the HTML division.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.htmldivision.spacebefore?view=word-pia"/>
  public float SpaceBefore { get; set; }

  /// <summary>
  /// Returns or sets the spacing, in points, after the HTML division.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.htmldivision.spaceafter?view=word-pia"/>
  public float SpaceAfter { get; set; }

  /// <summary>
  /// Returns the HTML divisions collection that contains this HTML division.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.htmldivision.htmldivisions?view=word-pia"/>
  public HTMLDivisions HTMLDivisions { get; }


  #region methods

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

  #endregion methods
}
