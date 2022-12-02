namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SlideLayoutExtensionList Class.
/// </summary>
public interface ISlideLayoutExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ISlideLayoutExtension>? SlideLayoutExtensions { get ; set; }
  
}
