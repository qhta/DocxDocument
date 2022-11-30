namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the StrDataExtensionList Class.
/// </summary>
public interface IStrDataExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IStrDataExtension>? StrDataExtensions { get ; set; }
  
}
