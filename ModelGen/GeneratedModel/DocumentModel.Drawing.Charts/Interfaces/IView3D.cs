namespace DocumentModel.Drawing.Charts;

public interface IView3D // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IRotateX? RotateX { get ; set; }
  
  public IHeightPercent? HeightPercent { get ; set; }
  
  public IRotateY? RotateY { get ; set; }
  
  public IDepthPercent? DepthPercent { get ; set; }
  
  public IRightAngleAxes? RightAngleAxes { get ; set; }
  
  public IPerspective? Perspective { get ; set; }
  
  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList { get ; set; }
  
}
