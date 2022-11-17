namespace DocumentModel.Drawing;

public interface ITableCellBorders // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.ILeftBorder? LeftBorder { get ; set; }

  public DocumentModel.Drawing.IRightBorder? RightBorder { get ; set; }

  public DocumentModel.Drawing.ITopBorder? TopBorder { get ; set; }

  public DocumentModel.Drawing.IBottomBorder? BottomBorder { get ; set; }

  public DocumentModel.Drawing.IInsideHorizontalBorder? InsideHorizontalBorder { get ; set; }

  public DocumentModel.Drawing.IInsideVerticalBorder? InsideVerticalBorder { get ; set; }

  public ITopLeftToBottomRightBorder? TopLeftToBottomRightBorder { get ; set; }

  public ITopRightToBottomLeftBorder? TopRightToBottomLeftBorder { get ; set; }

  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }

}
