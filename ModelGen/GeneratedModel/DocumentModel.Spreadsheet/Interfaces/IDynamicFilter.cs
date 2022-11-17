namespace DocumentModel.Spreadsheet;

public interface IDynamicFilter // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public DynamicFilter? Type { get ; set; }

  public double? Val { get ; set; }

  public double? MaxVal { get ; set; }

  public DateTime? ValIso { get ; set; }

  public DateTime? MaxValIso { get ; set; }

}
