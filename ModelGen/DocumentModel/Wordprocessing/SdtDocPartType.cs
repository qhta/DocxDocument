namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the SdtDocPartType Class.
/// </summary>
public partial class SdtDocPartType
{
  
  /// <summary>
  ///   Document Part Gallery Filter.
  /// </summary>
  public DocumentModel.Wordprocessing.DocPartGallery? DocPartGallery { get; set; }
  
  
  /// <summary>
  ///   Document Part Category Filter.
  /// </summary>
  public DocumentModel.Wordprocessing.DocPartCategory? DocPartCategory { get; set; }
  
  
  /// <summary>
  ///   Built-In Document Part.
  /// </summary>
  public DocumentModel.Wordprocessing.DocPartUnique? DocPartUnique { get; set; }
  
}
