namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ValAxExtensionList Class.
/// </summary>
public interface IValAxExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IValAxExtension>? ValAxExtensions { get ; set; }
  
}
