namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Section objects in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.sections?view=word-pia"/>
public interface ISections : IInteropObject, IInteropCollection<ISection>
{
  /// <summary>
  /// Returns a Section object that represents the first item in the Sections collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.sections.first?view=word-pia"/>
  public ISection First { get; }

  /// <summary>
  /// Returns the last item in the Sections collection as a Section object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.sections.last?view=word-pia"/>
  public ISection Last { get; }

  /// <summary>
  /// Returns a PageSetup object that's associated with the specified sections
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.sections.pagesetup?view=word-pia"/>
  public IPageSetup PageSetup { get; set; }


  #region methods

/// <summary>
  /// Adds a new section to the document.
  /// </summary>
  /// <param name="range">The range where the section is added.</param>
  /// <param name="start">The starting position for the new section.</param>
  /// <returns>The created <see cref="ISection"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.sections.add?view=word-pia"/>
  public ISection Add(object range, object start);

  #endregion methods
}
