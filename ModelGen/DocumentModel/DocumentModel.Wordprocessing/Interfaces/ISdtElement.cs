namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines SdtElement - the base class for the sdt elements.
/// </summary>
public interface ISdtElement // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Gets or sets the SdtProperties.
  /// </summary>
  public ISdtProperties? SdtProperties { get ; set; }
  
  /// <summary>
  /// Gets or sets the SdtEndCharProperties.
  /// </summary>
  public ISdtEndCharProperties? SdtEndCharProperties { get ; set; }
  
}
