namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the RadarSerExtensionList Class.
/// </summary>
public interface IRadarSerExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IRadarSerExtension>? RadarSerExtensions { get ; set; }
  
}
