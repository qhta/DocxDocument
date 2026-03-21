namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the current settings related to display of reviewersĂ„â€šĂ‹ÂÄ‚â€šĂ˘â€šÂ¬Ä‚â€šĂ˘â€žË comments and revision marks in the document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revisionsfilter?view=word-pia"/>
public partial interface RevisionsFilter
{
  /// <summary>
  /// The view.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revisionsfilter.view?view=word-pia"/>
  public WdRevisionsView View { get; set; }

  /// <summary>
  /// The markup.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revisionsfilter.markup?view=word-pia"/>
  public WdRevisionsMarkup Markup { get; set; }

  /// <summary>
  /// The reviewers.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revisionsfilter.reviewers?view=word-pia"/>
  public Reviewers Reviewers { get; }
}
