namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SlideExtensionList Class.
/// </summary>
public interface ISlideExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ISlideExtension>? SlideExtensions { get ; set; }
  
}
