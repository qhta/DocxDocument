namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SlideLayoutIdList Class.
/// </summary>
public interface ISlideLayoutIdList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ISlideLayoutId>? SlideLayoutIds { get ; set; }
  
}
