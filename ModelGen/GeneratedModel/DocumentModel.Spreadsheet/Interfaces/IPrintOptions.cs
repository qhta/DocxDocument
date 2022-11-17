namespace DocumentModel.Spreadsheet;

public interface IPrintOptions // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public bool? HorizontalCentered { get ; set; }

  public bool? VerticalCentered { get ; set; }

  public bool? Headings { get ; set; }

  public bool? GridLines { get ; set; }

  public bool? GridLinesSet { get ; set; }

}
