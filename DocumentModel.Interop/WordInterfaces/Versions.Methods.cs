namespace DocumentModel.Interop;

public partial interface Versions
{
  /// <summary>
  /// Saves a new version of the document with an optional comment.
  /// </summary>
  /// <param name="Comment">A comment describing the version.</param>
  public void Save(object Comment);
}
