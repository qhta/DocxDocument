namespace DocumentModel.Office.CustomUI;

public interface IQuickAccessToolbar // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public ISharedQatControls? SharedQatControls { get ; set; }

  public IDocumentSpecificQuickAccessToolbarControls? DocumentSpecificQuickAccessToolbarControls { get ; set; }

}
