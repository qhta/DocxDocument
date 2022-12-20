namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines SdtElement - the base class for the sdt elements.
/// </summary>
public partial interface SdtElement
{
  /// <summary>
  /// Gets or sets the SdtProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.SdtProperties? SdtProperties { get; set; }
  
  /// <summary>
  /// Gets or sets the SdtEndCharProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.SdtEndCharProperties? SdtEndCharProperties { get; set; }
  
}
