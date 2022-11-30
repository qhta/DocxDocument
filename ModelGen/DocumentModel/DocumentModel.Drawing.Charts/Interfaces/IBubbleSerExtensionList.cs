namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the BubbleSerExtensionList Class.
/// </summary>
public interface IBubbleSerExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IBubbleSerExtension>? BubbleSerExtensions { get ; set; }
  
}
