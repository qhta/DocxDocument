namespace DocumentModel.Math;

public interface IBoxProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IOperatorEmulator? OperatorEmulator { get ; set; }
  
  public INoBreak? NoBreak { get ; set; }
  
  public IDifferential? Differential { get ; set; }
  
  public DocumentModel.Math.IBreak? Break { get ; set; }
  
  public DocumentModel.Math.IAlignment? Alignment { get ; set; }
  
  public DocumentModel.Math.IControlProperties? ControlProperties { get ; set; }
  
}
