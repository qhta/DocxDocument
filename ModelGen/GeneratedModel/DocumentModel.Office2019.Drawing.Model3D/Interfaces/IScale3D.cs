namespace DocumentModel.Office2019.Drawing.Model3D;

public interface IScale3D // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public ISxRatio? SxRatio { get ; set; }

  public ISyRatio? SyRatio { get ; set; }

  public ISzRatio? SzRatio { get ; set; }

}
