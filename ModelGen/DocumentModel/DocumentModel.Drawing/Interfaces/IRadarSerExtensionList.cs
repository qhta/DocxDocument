namespace DocumentModel.Drawing;

/// <summary>
/// Defines the RadarSerExtensionList Class.
/// </summary>
public interface IRadarSerExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IRadarSerExtension>? RadarSerExtensions { get ; set; }
  
}
