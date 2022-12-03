namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SlideGuideList Class.
/// </summary>
public interface SlideGuideList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<ExtendedGuide>? ExtendedGuides { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
