namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.sections?view=word-pia"/>
public partial interface ISections: IModelObject
{
  /// <summary>
  /// Adds a new section to the document.
  /// </summary>
  /// <param name="Range">The range where the section is added.</param>
  /// <param name="Start">The starting position for the new section.</param>
  /// <returns>The created <see cref="ISection"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.sections.add?view=word-pia"/>
  public ISection Add(object Range, object Start);
}
