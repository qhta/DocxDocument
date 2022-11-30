namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the SerAxExtensionList Class.
/// </summary>
public interface ISerAxExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.ISerAxExtension>? SerAxExtensions { get ; set; }
  
}
