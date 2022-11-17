namespace DocumentModel.Drawing;

public interface ILightRig // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public LightRig? Rig { get ; set; }

  public DocumentModel.Drawing.LightRigDirection? Direction { get ; set; }

  public IRotation? Rotation { get ; set; }

}
