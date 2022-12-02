namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SlideGuideList Class.
/// </summary>
public interface ISlideGuideList // : DocumentModel.Presentation.IExtendedGuideList
{
  public Collection<IExtendedGuide>? ExtendedGuides { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
