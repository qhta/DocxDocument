namespace DocumentModel.Spreadsheet;

public interface IChartSheetProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? Published { get ; set; }

  public string? CodeName { get ; set; }

  public ITabColor? TabColor { get ; set; }

}
