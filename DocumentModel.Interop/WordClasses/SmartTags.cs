namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of SmartTag objects that represents the text in a document that is marked as containing
/// recognized type information.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttags?view=word-pia"/>
public partial class SmartTags : InteropCollection<SmartTag>
{


  #region methods

/// <summary>
  /// Adds a new smart tag to the collection.
  /// </summary>
  /// <param name="Name">The name of the smart tag type.</param>
  /// <param name="Range">The range to which the smart tag is applied.</param>
  /// <param name="Properties">The properties for the smart tag.</param>
  /// <returns>The created <see cref="SmartTag"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttags.add?view=word-pia"/>
  public SmartTag Add(string Name, object Range, object Properties) { throw new NotImplementedException(); }

  /// <summary>
  /// Returns a collection of smart tags of the specified type.
  /// </summary>
  /// <param name="Name">The name of the smart tag type to retrieve.</param>
  /// <returns>The <see cref="SmartTags"/> collection for the specified type.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttags.smarttagsbytype?view=word-pia"/>
  public SmartTags SmartTagsByType(string Name) { throw new NotImplementedException(); }

  #endregion methods
}
