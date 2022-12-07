namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines SdtElement - the base class for the sdt elements.
/// </summary>
public class SdtElementImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.SdtElement>, SdtElement
{
  /// <summary>
  /// Gets or sets the SdtProperties.
  /// </summary>
  public virtual SdtProperties? SdtProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the SdtEndCharProperties.
  /// </summary>
  public virtual SdtEndCharProperties? SdtEndCharProperties
  {
    get;
    set;
  }
  
}
