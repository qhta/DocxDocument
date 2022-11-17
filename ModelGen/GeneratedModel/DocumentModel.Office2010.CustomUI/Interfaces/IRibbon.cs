namespace DocumentModel.Office2010.CustomUI;

public interface IRibbon // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? StartFromScratch { get ; set; }
  
  public DocumentModel.Office2010.CustomUI.IQuickAccessToolbar? QuickAccessToolbar { get ; set; }
  
  public DocumentModel.Office2010.CustomUI.ITabs? Tabs { get ; set; }
  
  public IContextualTabs? ContextualTabs { get ; set; }
  
}
