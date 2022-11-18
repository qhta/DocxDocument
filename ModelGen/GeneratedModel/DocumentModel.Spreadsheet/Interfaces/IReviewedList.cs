namespace DocumentModel.Spreadsheet;

/// <summary>
/// Reviewed List.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IReviewed))]
public interface IReviewedList // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Reviewed Revisions Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
