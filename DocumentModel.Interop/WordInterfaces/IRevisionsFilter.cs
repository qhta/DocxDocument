namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the current settings related to display of reviewers’ comments and revision marks in the document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revisionsfilter?view=word-pia"/>
public partial interface IRevisionsFilter
{
  /// <summary>
  /// Sets or returns a RevisionsView constant that represents the global option that specifies whether Word
  /// displays the original version of a document or the final version, which might have revisions and formatting
  /// changes applied. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revisionsfilter.view?view=word-pia"/>
  public RevisionsView View { get; set; }

  /// <summary>
  /// Returns or sets a RevisionsMarkup constant that specifies the extent of reviewer markup displayed in the
  /// document. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revisionsfilter.markup?view=word-pia"/>
  public RevisionsMarkup Markup { get; set; }

  /// <summary>
  /// Returns a Reviewers object that represents the collection of reviewers of one or more documents.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revisionsfilter.reviewers?view=word-pia"/>
  public Reviewers Reviewers { get; }


  #region methods

/// <summary>
  /// Shows or hides all revisions in a document that contains comments and tracked changes.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revisionsfilter.toggleshowallreviewers?view=word-pia"/>
  public void ToggleShowAllReviewers();

  #endregion methods
}
