namespace DocumentModel.Vml;

public interface IBackground // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? Id { get ; set; }
  
  public ITrueFalseValue? Filled { get ; set; }
  
  public string? Fillcolor { get ; set; }
  
  public BlackAndWhiteMode? BlackWhiteMode { get ; set; }
  
  public BlackAndWhiteMode? PureBlackWhiteMode { get ; set; }
  
  public BlackAndWhiteMode? NormalBlackWhiteMode { get ; set; }
  
  public ScreenSize? TargetScreenSize { get ; set; }
  
  public DocumentModel.Vml.IFill? Fill { get ; set; }
  
}
