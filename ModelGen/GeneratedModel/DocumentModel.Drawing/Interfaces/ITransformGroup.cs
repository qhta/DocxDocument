namespace DocumentModel.Drawing;

public interface ITransformGroup // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public int? Rotation { get ; set; }

  public bool? HorizontalFlip { get ; set; }

  public bool? VerticalFlip { get ; set; }

  public IOffset? Offset { get ; set; }

  public IExtents? Extents { get ; set; }

  public IChildOffset? ChildOffset { get ; set; }

  public IChildExtents? ChildExtents { get ; set; }

}
