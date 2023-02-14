namespace DocumentModel.Wordprocessing;

/// <summary>
///   Document.
/// </summary>
public partial class Document
{
  public DocumentProperties? Properties { get; set; }

  public Styles? Styles { get; set; }

  public DMDraws.Theme? Theme { get; set; }

  public Fonts? Fonts { get; set; }

}