namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttags?view=word-pia"/>
public partial interface ISmartTags: IModelObject
{
  /// <summary>
  /// Adds a new smart tag to the collection.
  /// </summary>
  /// <param name="Name">The name of the smart tag type.</param>
  /// <param name="Range">The range to which the smart tag is applied.</param>
  /// <param name="Properties">The properties for the smart tag.</param>
  /// <returns>The created <see cref="ISmartTag"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttags.add?view=word-pia"/>
  public ISmartTag Add(string Name, object Range, object Properties);

  /// <summary>
  /// Returns a collection of smart tags of the specified type.
  /// </summary>
  /// <param name="Name">The name of the smart tag type to retrieve.</param>
  /// <returns>The <see cref="ISmartTags"/> collection for the specified type.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttags.smarttagsbytype?view=word-pia"/>
  public ISmartTags SmartTagsByType(string Name);
}
