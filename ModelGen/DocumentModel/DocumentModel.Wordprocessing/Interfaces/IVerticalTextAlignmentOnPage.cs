namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the VerticalTextAlignmentOnPage Class.
/// </summary>
public interface IVerticalTextAlignmentOnPage // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Vertical Alignment Setting
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalJustificationValues? Val { get ; set; }
  
}
