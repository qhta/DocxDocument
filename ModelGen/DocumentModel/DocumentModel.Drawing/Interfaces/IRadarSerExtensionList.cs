namespace DocumentModel.Drawing;

/// <summary>
/// Defines the RadarSerExtensionList Class.
/// </summary>
public interface IRadarSerExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IRadarSerExtension>? RadarSerExtensions { get ; set; }
  
}
