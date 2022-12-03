namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SlideMasterExtension Class.
/// </summary>
public interface SlideMasterExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public SlideGuideList? SlideGuideList { get ; set; }
  
}
