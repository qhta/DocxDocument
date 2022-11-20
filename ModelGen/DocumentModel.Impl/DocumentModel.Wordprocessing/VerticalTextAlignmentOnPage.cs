namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the VerticalTextAlignmentOnPage Class.
/// </summary>
public class VerticalTextAlignmentOnPage: IVerticalTextAlignmentOnPage
{
  /// <summary>
  /// Vertical Alignment Setting
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalJustificationValues? Val
  {
    get;
    set;
  }
  
}
