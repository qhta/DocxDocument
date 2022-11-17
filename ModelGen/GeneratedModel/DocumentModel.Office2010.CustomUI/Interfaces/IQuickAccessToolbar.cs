namespace DocumentModel.Office2010.CustomUI;

public interface IQuickAccessToolbar // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public ISharedControlsQatItems? SharedControlsQatItems { get ; set; }

  public IDocumentControlsQatItems? DocumentControlsQatItems { get ; set; }

}
