namespace DocumentModel.Presentation;

public interface ITargetElement // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public ISlideTarget? SlideTarget { get ; set; }

  public ISoundTarget? SoundTarget { get ; set; }

  public IShapeTarget? ShapeTarget { get ; set; }

  public IInkTarget? InkTarget { get ; set; }

  public IBookmarkTarget? BookmarkTarget { get ; set; }

}
