namespace DocumentModel.Interop;

/// <summary>
/// Represents the current settings related to display of reviewersÄ‚ËĂ‚â‚¬Ă‚â„˘ comments and revision marks in the document.
/// </summary>
public partial interface RevisionsFilter
{
  /// <summary>
  /// The view.
  /// </summary>
  public WdRevisionsView View { get; set; }

  /// <summary>
  /// The markup.
  /// </summary>
  public WdRevisionsMarkup Markup { get; set; }

  /// <summary>
  /// The reviewers.
  /// </summary>
  public Reviewers Reviewers { get; }
}
