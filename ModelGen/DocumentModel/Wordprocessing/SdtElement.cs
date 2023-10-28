namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines SdtElement - the base class for the sdt elements.
/// </summary>
public partial class SdtElement
{
  
  /// <summary>
  ///   Gets or sets the SdtProperties.
  /// </summary>
  public DMW.SdtProperties? SdtProperties { get; set; }
  
  
  /// <summary>
  ///   Gets or sets the SdtEndCharProperties.
  /// </summary>
  public DMW.SdtEndCharProperties? SdtEndCharProperties { get; set; }
  
}
