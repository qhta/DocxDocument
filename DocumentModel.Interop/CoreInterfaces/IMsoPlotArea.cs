
namespace DocumentModel.Interop.Core;

public interface IMsoPlotArea
{
  public string Name { get; }
  public object Select();
  public IMsoBorder Border { get; }
  public object ClearFormats();
  public double Height { get; set; }
  public IMsoInterior Interior { get; }
  public ChartFillFormat Fill { get; }
  public double Left { get; set; }
  public double Top { get; set; }
  public double Width { get; set; }
  public double InsideLeft { get; set; }
  public double InsideTop { get; set; }
  public double InsideWidth { get; set; }
  public double InsideHeight { get; set; }
  public XlChartElementPosition Position { get; set; }
  public IMsoChartFormat Format { get; }
}
