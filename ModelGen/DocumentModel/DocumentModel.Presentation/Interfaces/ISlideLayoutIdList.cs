namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SlideLayoutIdList Class.
/// </summary>
public interface ISlideLayoutIdList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Presentation.ISlideLayoutId>? SlideLayoutIds { get ; set; }
  
}
