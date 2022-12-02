namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CommonSlideDataExtensionList Class.
/// </summary>
public interface ICommonSlideDataExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ICommonSlideDataExtension>? CommonSlideDataExtensions { get ; set; }
  
}
