namespace DocumentModel.Presentation;

public interface ICommonMediaNode // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public int? Volume { get ; set; }
  
  public bool? Mute { get ; set; }
  
  public uint? SlideCount { get ; set; }
  
  public bool? ShowWhenStopped { get ; set; }
  
  public ICommonTimeNode? CommonTimeNode { get ; set; }
  
  public ITargetElement? TargetElement { get ; set; }
  
}
