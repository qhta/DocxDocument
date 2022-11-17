namespace DocumentModel.Wordprocessing;

public interface IFrameset // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IFrameSize? FrameSize { get ; set; }
  
  public IFramesetSplitbar? FramesetSplitbar { get ; set; }
  
  public IFrameLayout? FrameLayout { get ; set; }
  
}
