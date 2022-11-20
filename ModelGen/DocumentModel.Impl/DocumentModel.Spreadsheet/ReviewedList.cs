namespace DocumentModel.Spreadsheet;

/// <summary>
/// Reviewed List.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IReviewed))]
public class ReviewedList: IReviewedList
{
  /// <summary>
  /// Reviewed Revisions Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
