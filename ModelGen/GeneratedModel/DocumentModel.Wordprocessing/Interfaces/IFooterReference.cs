namespace DocumentModel.Wordprocessing;

/// <summary>
/// Footer Reference.
/// </summary>
public interface IFooterReference // : DocumentFormat.OpenXml.Wordprocessing.HeaderFooterReferenceType
{
  /// <summary>
  /// type
  /// </summary>
  public HeaderFooter? Type { get ; set; }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public string? Id { get ; set; }
  
}
