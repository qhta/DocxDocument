namespace DocumentModel.Office2019.Drawing.Model3D;

public interface IModel3DRaster // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? RName { get ; set; }

  public string? RVer { get ; set; }

  public DocumentModel.Office2019.Drawing.Model3D.IBlip? Blip { get ; set; }

}
