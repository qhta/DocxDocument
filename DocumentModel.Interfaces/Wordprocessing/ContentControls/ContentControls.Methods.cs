namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrols?view=word-pia"/>
public partial interface IContentControls: IModelObject
{
  /// <summary>
  /// Adds a content control of the specified type.
  /// </summary>
  /// <param name="Type">The type of content control to add.</param>
  /// <param name="Range">The range where the content control is added.</param>
  /// <returns>The created <see cref="IContentControl"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrols.add?view=word-pia"/>
  public IContentControl Add(ContentControlType Type, object Range);
}
