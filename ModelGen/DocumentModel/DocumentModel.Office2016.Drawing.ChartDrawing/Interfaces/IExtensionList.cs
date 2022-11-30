namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public interface IExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2016.Drawing.ChartDrawing.IExtension2>? Extension2s { get ; set; }
  
}
