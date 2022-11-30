namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the ValAxExtensionList Class.
/// </summary>
public interface IValAxExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IValAxExtension>? ValAxExtensions { get ; set; }
  
}
