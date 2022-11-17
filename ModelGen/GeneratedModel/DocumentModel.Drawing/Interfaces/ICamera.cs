namespace DocumentModel.Drawing;

public interface ICamera // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public PresetCamera? Preset { get ; set; }
  
  public int? FieldOfView { get ; set; }
  
  public int? Zoom { get ; set; }
  
  public IRotation? Rotation { get ; set; }
  
}
