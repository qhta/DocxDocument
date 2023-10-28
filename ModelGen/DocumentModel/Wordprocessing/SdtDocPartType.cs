namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the SdtDocPartType Class.
/// </summary>
public partial class SdtDocPartType
{
  
  /// <summary>
  ///   Document Part Gallery Filter.
  /// </summary>
  public DMW.DocPartGallery? DocPartGallery { get; set; }
  
  
  /// <summary>
  ///   Document Part Category Filter.
  /// </summary>
  public DMW.DocPartCategory? DocPartCategory { get; set; }
  
  
  /// <summary>
  ///   Built-In Document Part.
  /// </summary>
  public DMW.DocPartUnique? DocPartUnique { get; set; }
  
}
