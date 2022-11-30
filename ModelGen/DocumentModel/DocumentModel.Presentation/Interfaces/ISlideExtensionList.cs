namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SlideExtensionList Class.
/// </summary>
public interface ISlideExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Presentation.ISlideExtension>? SlideExtensions { get ; set; }
  
}
