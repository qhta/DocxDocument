namespace DocumentModel.Interop;

public partial interface ContentControls
{
  /// <summary>
  /// Adds a content control of the specified type.
  /// </summary>
  /// <param name="Type">The type of content control to add.</param>
  /// <param name="Range">The range where the content control is added.</param>
  /// <returns>The created <see cref="ContentControl"/> object.</returns>
  public ContentControl Add(WdContentControlType Type, object Range);
}
