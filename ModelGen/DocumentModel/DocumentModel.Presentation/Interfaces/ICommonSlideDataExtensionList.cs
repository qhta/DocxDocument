namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CommonSlideDataExtensionList Class.
/// </summary>
public interface ICommonSlideDataExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Presentation.ICommonSlideDataExtension>? CommonSlideDataExtensions { get ; set; }
  
}
