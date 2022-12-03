namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SlideLayoutExtension Class.
/// </summary>
public interface SlideLayoutExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public SlideGuideList? SlideGuideList { get ; set; }
  
}
