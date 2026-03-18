namespace DocumentModel.Interop;

public partial interface Paragraph
{
  /// <summary>
  /// Returns the list number original.
  /// </summary>
  /// <param name="Level">Specifies the level.</param>
  /// <returns>The resulting value.</returns>
  public short ListNumberOriginal(short Level);

  /// <summary>
  /// Removes any spacing before the specified paragraphs.
  /// </summary>
  public void CloseUp();
}
