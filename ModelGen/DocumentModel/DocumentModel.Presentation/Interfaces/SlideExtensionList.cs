namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SlideExtensionList Class.
/// </summary>
public interface SlideExtensionList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<SlideExtension>? SlideExtensions { get ; set; }
  
}
