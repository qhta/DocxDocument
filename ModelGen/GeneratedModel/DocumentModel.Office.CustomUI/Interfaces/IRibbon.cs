namespace DocumentModel.Office.CustomUI;

public interface IRibbon // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? StartFromScratch { get ; set; }

  public IOfficeMenu? OfficeMenu { get ; set; }

  public DocumentModel.Office.CustomUI.IQuickAccessToolbar? QuickAccessToolbar { get ; set; }

  public DocumentModel.Office.CustomUI.ITabs? Tabs { get ; set; }

  public IContextualTabSets? ContextualTabSets { get ; set; }

}
