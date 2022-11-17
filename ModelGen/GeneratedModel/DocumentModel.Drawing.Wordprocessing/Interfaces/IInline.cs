namespace DocumentModel.Drawing.Wordprocessing;

public interface IInline // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public uint? DistanceFromTop { get ; set; }

  public uint? DistanceFromBottom { get ; set; }

  public uint? DistanceFromLeft { get ; set; }

  public uint? DistanceFromRight { get ; set; }

  public IHexBinaryValue? AnchorId { get ; set; }

  public IHexBinaryValue? EditId { get ; set; }

  public DocumentModel.Drawing.Wordprocessing.IExtent? Extent { get ; set; }

  public IEffectExtent? EffectExtent { get ; set; }

  public IDocProperties? DocProperties { get ; set; }

  public DocumentModel.Drawing.Wordprocessing.INonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties { get ; set; }

  public IGraphic? Graphic { get ; set; }

}
