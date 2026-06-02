namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of ContentControl objects. Content controls are bounded and potentially labeled regions in a document that serve as containers for specific types of content. Individual content controls may contain content such as dates, lists, or paragraphs of formatted text.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrols?view=word-pia"/>
public partial class ContentControls : InteropCollection<ContentControl>
{


  #region methods

/// <summary>
  /// Adds a content control of the specified type.
  /// </summary>
  /// <param name="Type">The type of content control to add.</param>
  /// <param name="Range">The range where the content control is added.</param>
  /// <returns>The created <see cref="ContentControl"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrols.add?view=word-pia"/>
  public ContentControl Add(ContentControlType Type, object Range) { throw new NotImplementedException(); }

  #endregion methods
}
