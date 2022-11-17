namespace DocumentModel.Drawing.Wordprocessing;

public interface IAnchor // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public uint? DistanceFromTop { get ; set; }
  
  public uint? DistanceFromBottom { get ; set; }
  
  public uint? DistanceFromLeft { get ; set; }
  
  public uint? DistanceFromRight { get ; set; }
  
  public bool? SimplePos { get ; set; }
  
  public uint? RelativeHeight { get ; set; }
  
  public bool? BehindDoc { get ; set; }
  
  public bool? Locked { get ; set; }
  
  public bool? LayoutInCell { get ; set; }
  
  public bool? Hidden { get ; set; }
  
  public bool? AllowOverlap { get ; set; }
  
  public IHexBinaryValue? EditId { get ; set; }
  
  public IHexBinaryValue? AnchorId { get ; set; }
  
  public ISimplePosition? SimplePosition { get ; set; }
  
  public IHorizontalPosition? HorizontalPosition { get ; set; }
  
  public IVerticalPosition? VerticalPosition { get ; set; }
  
  public DocumentModel.Drawing.Wordprocessing.IExtent? Extent { get ; set; }
  
  public IEffectExtent? EffectExtent { get ; set; }
  
}
