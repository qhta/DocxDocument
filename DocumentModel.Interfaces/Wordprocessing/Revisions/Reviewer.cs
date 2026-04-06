namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single reviewer of a document in which changes have been tracked.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.reviewer?view=word-pia"/>
public interface IReviewer : IModelObject
{
  /// <summary>
  /// True if the specified object is visible.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.reviewer.visible?view=word-pia"/>
  public bool Visible { get; set; }

}
