namespace DocumentModel.Spreadsheet;

public interface IBorder // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? DiagonalUp { get ; set; }

  public bool? DiagonalDown { get ; set; }

  public bool? Outline { get ; set; }

  public DocumentModel.Spreadsheet.IStartBorder? StartBorder { get ; set; }

  public DocumentModel.Spreadsheet.IEndBorder? EndBorder { get ; set; }

  public DocumentModel.Spreadsheet.ILeftBorder? LeftBorder { get ; set; }

  public DocumentModel.Spreadsheet.IRightBorder? RightBorder { get ; set; }

  public DocumentModel.Spreadsheet.ITopBorder? TopBorder { get ; set; }

  public DocumentModel.Spreadsheet.IBottomBorder? BottomBorder { get ; set; }

  public IDiagonalBorder? DiagonalBorder { get ; set; }

  public IVerticalBorder? VerticalBorder { get ; set; }

  public IHorizontalBorder? HorizontalBorder { get ; set; }

}
