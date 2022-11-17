namespace DocumentModel.Presentation;

public interface ICommonViewProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? VariableScale { get ; set; }
  
  public IScaleFactor? ScaleFactor { get ; set; }
  
  public IOrigin? Origin { get ; set; }
  
}
