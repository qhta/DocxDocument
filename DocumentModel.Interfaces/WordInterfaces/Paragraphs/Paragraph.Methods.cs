namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph?view=word-pia"/>
public partial interface IParagraph: IModelObject
{
  /// <summary>
  /// Returns the list number original.
  /// </summary>
  /// <param name="Level">Specifies the level.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.listnumberoriginal?view=word-pia"/>
  public short ListNumberOriginal(short Level);

  /// <summary>
  /// Removes any spacing before the specified paragraphs.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.closeup?view=word-pia"/>
  public void CloseUp();
}
