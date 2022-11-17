namespace DocumentModel.Wordprocessing;

public interface IFramesetSplitbar // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Wordprocessing.IWidth? Width { get ; set; }

  public DocumentModel.Wordprocessing.IColor? Color { get ; set; }

  public INoBorder? NoBorder { get ; set; }

  public IFlatBorders? FlatBorders { get ; set; }

}
