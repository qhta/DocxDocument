namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of SmartTag objects that represents the text in a document that is marked as containing
/// recognized type information.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttags?view=word-pia"/>
public interface ISmartTags : IInteropObject, IInteropCollection<ISmartTag>
{


  #region methods

/// <summary>
  /// Adds a new smart tag to the collection.
  /// </summary>
  /// <param name="name">The name of the smart tag type.</param>
  /// <param name="range">The range to which the smart tag is applied.</param>
  /// <param name="properties">The properties for the smart tag.</param>
  /// <returns>The created <see cref="ISmartTag"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttags.add?view=word-pia"/>
  public ISmartTag Add(string name, object range, object properties);

  /// <summary>
  /// Returns a collection of smart tags of the specified type.
  /// </summary>
  /// <param name="name">The name of the smart tag type to retrieve.</param>
  /// <returns>The <see cref="ISmartTags"/> collection for the specified type.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttags.smarttagsbytype?view=word-pia"/>
  public ISmartTags SmartTagsByType(string name);

  #endregion methods
}
