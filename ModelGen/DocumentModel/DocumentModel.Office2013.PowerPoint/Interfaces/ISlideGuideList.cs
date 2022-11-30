namespace DocumentModel.Office2013.PowerPoint;

/// <summary>
/// Defines the SlideGuideList Class.
/// </summary>
public interface ISlideGuideList // : DocumentModel.Office2013.PowerPoint.IExtendedGuideList
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2013.PowerPoint.IExtendedGuide>? ExtendedGuides { get ; set; }
  
  public DocumentModel.Office2013.PowerPoint.IExtensionList? ExtensionList { get ; set; }
  
}
