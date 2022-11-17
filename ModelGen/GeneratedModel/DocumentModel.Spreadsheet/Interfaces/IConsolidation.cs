namespace DocumentModel.Spreadsheet;

public interface IConsolidation // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? AutoPage { get ; set; }

  public DocumentModel.Spreadsheet.IPages? Pages { get ; set; }

  public IRangeSets? RangeSets { get ; set; }

}
