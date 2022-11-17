namespace DocumentModel.Drawing;

public interface ITableCellProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public int? LeftMargin { get ; set; }

  public int? RightMargin { get ; set; }

  public int? TopMargin { get ; set; }

  public int? BottomMargin { get ; set; }

  public TextVertical? Vertical { get ; set; }

  public TextAnchoringType? Anchor { get ; set; }

  public bool? AnchorCenter { get ; set; }

  public TextHorizontalOverflow? HorizontalOverflow { get ; set; }

  public ILeftBorderLineProperties? LeftBorderLineProperties { get ; set; }

  public IRightBorderLineProperties? RightBorderLineProperties { get ; set; }

  public ITopBorderLineProperties? TopBorderLineProperties { get ; set; }

  public IBottomBorderLineProperties? BottomBorderLineProperties { get ; set; }

  public ITopLeftToBottomRightBorderLineProperties? TopLeftToBottomRightBorderLineProperties { get ; set; }

  public IBottomLeftToTopRightBorderLineProperties? BottomLeftToTopRightBorderLineProperties { get ; set; }

  public ICell3DProperties? Cell3DProperties { get ; set; }

}
