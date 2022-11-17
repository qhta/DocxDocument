namespace DocumentModel.Presentation;

public interface ICommonSlideViewProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? SnapToGrid { get ; set; }
  
  public bool? SnapToObjects { get ; set; }
  
  public bool? ShowGuides { get ; set; }
  
  public ICommonViewProperties? CommonViewProperties { get ; set; }
  
  public IGuideList? GuideList { get ; set; }
  
}
