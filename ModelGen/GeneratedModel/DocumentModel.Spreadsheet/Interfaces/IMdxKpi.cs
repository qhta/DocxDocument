namespace DocumentModel.Spreadsheet;

public interface IMdxKpi // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public uint? NameIndex { get ; set; }

  public uint? KpiIndex { get ; set; }

  public MdxKPIProperty? KpiProperty { get ; set; }

}
