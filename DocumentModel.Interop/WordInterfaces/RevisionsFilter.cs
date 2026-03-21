namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the current settings related to display of reviewersĂ„â€šĂ‹ÂÄ‚â€šĂ˘â€šÂ¬Ä‚â€šĂ˘â€žË comments and revision marks in the document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revisionsfilter?view=word-pia"/>
public partial interface RevisionsFilter
{
  /// <summary>
  /// Returns or sets the view.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revisionsfilter.view?view=word-pia"/>
  public WdRevisionsView View { get; set; }

  /// <summary>
  /// Returns or sets the markup.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revisionsfilter.markup?view=word-pia"/>
  public WdRevisionsMarkup Markup { get; set; }

  /// <summary>
  /// Returns the reviewers.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revisionsfilter.reviewers?view=word-pia"/>
  public Reviewers Reviewers { get; }
}
