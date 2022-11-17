namespace DocumentModel.Office2019.Drawing.Model3D;

public interface IModel3DCamera // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IPosPoint3D? PosPoint3D { get ; set; }
  
  public IUpVector3D? UpVector3D { get ; set; }
  
  public ILookAtPoint3D? LookAtPoint3D { get ; set; }
  
}
