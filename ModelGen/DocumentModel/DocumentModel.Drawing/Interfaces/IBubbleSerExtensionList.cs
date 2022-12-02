namespace DocumentModel.Drawing;

/// <summary>
/// Defines the BubbleSerExtensionList Class.
/// </summary>
public interface IBubbleSerExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IBubbleSerExtension>? BubbleSerExtensions { get ; set; }
  
}
