namespace DocumentModel.Drawing;

public interface IEffectList // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IBlur? Blur { get ; set; }
  
  public IFillOverlay? FillOverlay { get ; set; }
  
  public DocumentModel.Drawing.IGlow? Glow { get ; set; }
  
  public IInnerShadow? InnerShadow { get ; set; }
  
  public IOuterShadow? OuterShadow { get ; set; }
  
  public IPresetShadow? PresetShadow { get ; set; }
  
  public DocumentModel.Drawing.IReflection? Reflection { get ; set; }
  
  public ISoftEdge? SoftEdge { get ; set; }
  
}
