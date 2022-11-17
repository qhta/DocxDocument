namespace DocumentModel.Spreadsheet;

public interface ICommentProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? Locked { get ; set; }

  public bool? DefaultSize { get ; set; }

  public bool? Print { get ; set; }

  public bool? Disabled { get ; set; }

  public bool? UiObject { get ; set; }

  public bool? AutoFill { get ; set; }

  public bool? AutoLine { get ; set; }

  public string? AltText { get ; set; }

  public DocumentModel.Spreadsheet.TextHorizontalAlignment? TextHAlign { get ; set; }

  public DocumentModel.Spreadsheet.TextVerticalAlignment? TextVAlign { get ; set; }

  public bool? LockText { get ; set; }

  public bool? JustLastX { get ; set; }

  public bool? AutoScale { get ; set; }

  public bool? RowHidden { get ; set; }

  public bool? ColHidden { get ; set; }

  public IObjectAnchor? ObjectAnchor { get ; set; }

}
