namespace DocumentModel.Drawing;

/// <summary>
/// Defines the StrDataExtensionList Class.
/// </summary>
public interface IStrDataExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IStrDataExtension>? StrDataExtensions { get ; set; }
  
}
