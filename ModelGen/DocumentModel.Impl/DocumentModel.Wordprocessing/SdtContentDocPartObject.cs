namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentDocPartObject Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDocPartUnique))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDocPartGallery))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDocPartCategory))]
public class SdtContentDocPartObject: ISdtContentDocPartObject
{
  /// <summary>
  /// Document Part Gallery Filter.
  /// </summary>
  public IDocPartGallery? DocPartGallery
  {
    get;
    set;
  }
  
  /// <summary>
  /// Document Part Category Filter.
  /// </summary>
  public IDocPartCategory? DocPartCategory
  {
    get;
    set;
  }
  
  /// <summary>
  /// Built-In Document Part.
  /// </summary>
  public IDocPartUnique? DocPartUnique
  {
    get;
    set;
  }
  
}
