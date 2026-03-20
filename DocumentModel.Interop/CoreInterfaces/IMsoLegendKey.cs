
namespace DocumentModel.Interop.Core;

public interface IMsoLegendKey
{
  public IMsoBorder Border { get; }
  public object ClearFormats();
  public object Delete();
  public IMsoInterior Interior { get; }
  public ChartFillFormat Fill { get; }
  public bool InvertIfNegative { get; set; }
  public int MarkerBackgroundColor { get; set; }
  public XlColorIndex MarkerBackgroundColorIndex { get; set; }
  public int MarkerForegroundColor { get; set; }
  public XlColorIndex MarkerForegroundColorIndex { get; set; }
  public int MarkerSize { get; set; }
  public XlMarkerStyle MarkerStyle { get; set; }
  public int PictureType { get; set; }
  public double PictureUnit { get; set; }
  public object Select();
  public bool Smooth { get; set; }
  public double Left { get; }
  public double Top { get; }
  public double Width { get; }
  public double Height { get; }
  public bool Shadow { get; set; }
  public IMsoChartFormat Format { get; }
  public double PictureUnit2 { get; set; }
}
