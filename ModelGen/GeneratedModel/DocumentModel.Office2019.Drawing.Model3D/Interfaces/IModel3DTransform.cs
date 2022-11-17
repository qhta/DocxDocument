namespace DocumentModel.Office2019.Drawing.Model3D;

public interface IModel3DTransform // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IMeterPerModelUnitPositiveRatio? MeterPerModelUnitPositiveRatio { get ; set; }
  
  public IPreTransVector3D? PreTransVector3D { get ; set; }
  
  public IScale3D? Scale3D { get ; set; }
  
  public IRotate3D? Rotate3D { get ; set; }
  
  public IPostTransVector3D? PostTransVector3D { get ; set; }
  
  public DocumentModel.Office2019.Drawing.Model3D.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
