namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SlideGuideList Class.
/// </summary>
public interface ISlideGuideList // : DocumentModel.Presentation.IExtendedGuideList
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Presentation.IExtendedGuide>? ExtendedGuides { get ; set; }
  
  public DocumentModel.Presentation.IExtensionList? ExtensionList { get ; set; }
  
}
