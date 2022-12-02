namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DateAxExtensionList Class.
/// </summary>
public interface IDateAxExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IDateAxExtension>? DateAxExtensions { get ; set; }
  
}
