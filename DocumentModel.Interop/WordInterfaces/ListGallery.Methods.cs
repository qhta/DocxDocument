namespace DocumentModel.Interop.Word;

public partial interface ListGallery
{
  /// <summary>
  /// Determines whether the specified list template has been modified.
  /// </summary>
  /// <param name="Index">The index of the list template to check.</param>
  /// <returns>true if the template is modified; otherwise, false.</returns>
  public bool IsTemplateModified(int Index);
}
