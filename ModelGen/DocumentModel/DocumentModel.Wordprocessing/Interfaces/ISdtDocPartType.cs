namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtDocPartType Class.
/// </summary>
public interface ISdtDocPartType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Document Part Gallery Filter.
  /// </summary>
  public IDocPartGallery? DocPartGallery { get ; set; }
  
  /// <summary>
  /// Document Part Category Filter.
  /// </summary>
  public IDocPartCategory? DocPartCategory { get ; set; }
  
  /// <summary>
  /// Built-In Document Part.
  /// </summary>
  public IDocPartUnique? DocPartUnique { get ; set; }
  
}
