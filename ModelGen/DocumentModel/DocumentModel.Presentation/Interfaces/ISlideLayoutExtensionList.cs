namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SlideLayoutExtensionList Class.
/// </summary>
public interface ISlideLayoutExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Presentation.ISlideLayoutExtension>? SlideLayoutExtensions { get ; set; }
  
}
