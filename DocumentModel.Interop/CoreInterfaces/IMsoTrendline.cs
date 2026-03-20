
namespace DocumentModel.Interop.Core;

public interface IMsoTrendline
{
  public double Backward { get; set; }
  public IMsoBorder Border { get; }
  public object ClearFormats();
  public IMsoDataLabel DataLabel { get; }
  public object Delete();
  public bool DisplayEquation { get; set; }
  public bool DisplayRSquared { get; set; }
  public double Forward { get; set; }
  public int Index { get; }
  public double Intercept { get; set; }
  public bool InterceptIsAuto { get; set; }
  public string Name { get; set; }
  public bool NameIsAuto { get; set; }
  public int Order { get; set; }
  public int Period { get; set; }
  public object Select();
  public XlTrendlineType Type { get; set; }
  public IMsoChartFormat Format { get; }
  public double Backward2 { get; set; }
  public double Forward2 { get; set; }
}
