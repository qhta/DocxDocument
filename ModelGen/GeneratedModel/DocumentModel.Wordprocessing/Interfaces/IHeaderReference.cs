namespace DocumentModel.Wordprocessing;

/// <summary>
/// Header Reference.
/// </summary>
public interface IHeaderReference // : DocumentFormat.OpenXml.Wordprocessing.HeaderFooterReferenceType
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
