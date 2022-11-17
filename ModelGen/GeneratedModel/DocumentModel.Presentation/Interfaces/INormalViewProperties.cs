namespace DocumentModel.Presentation;

public interface INormalViewProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? ShowOutlineIcons { get ; set; }
  
  public bool? SnapVerticalSplitter { get ; set; }
  
  public SplitterBarState? VerticalBarState { get ; set; }
  
  public SplitterBarState? HorizontalBarState { get ; set; }
  
  public bool? PreferSingleView { get ; set; }
  
  public IRestoredLeft? RestoredLeft { get ; set; }
  
  public IRestoredTop? RestoredTop { get ; set; }
  
  public DocumentModel.Presentation.IExtensionList? ExtensionList { get ; set; }
  
}
