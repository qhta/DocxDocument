namespace DocumentModel.Math;

public interface IPhantomProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IShowPhantom? ShowPhantom { get ; set; }
  
  public IZeroWidth? ZeroWidth { get ; set; }
  
  public IZeroAscent? ZeroAscent { get ; set; }
  
  public IZeroDescent? ZeroDescent { get ; set; }
  
  public ITransparent? Transparent { get ; set; }
  
  public DocumentModel.Math.IControlProperties? ControlProperties { get ; set; }
  
}
