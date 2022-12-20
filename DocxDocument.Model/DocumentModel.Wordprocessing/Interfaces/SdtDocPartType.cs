namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtDocPartType Class.
/// </summary>
public partial interface SdtDocPartType
{
  /// <summary>
  /// Document Part Gallery Filter.
  /// </summary>
  public String? DocPartGallery { get; set; }
  
  /// <summary>
  /// Document Part Category Filter.
  /// </summary>
  public String? DocPartCategory { get; set; }
  
  /// <summary>
  /// Built-In Document Part.
  /// </summary>
  public Boolean? DocPartUnique { get; set; }
  
}
