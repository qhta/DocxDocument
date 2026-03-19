namespace DocumentModel.Interop.Word;

public partial interface Sections
{
  /// <summary>
  /// Adds a new section to the document.
  /// </summary>
  /// <param name="Range">The range where the section is added.</param>
  /// <param name="Start">The starting position for the new section.</param>
  /// <returns>The created <see cref="Section"/> object.</returns>
  public Section Add(object Range, object Start);
}
