namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrols?view=word-pia"/>
public partial interface ContentControls
{
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
  public ContentControl Add(WdContentControlType Type, object Range);
}
