
namespace DocumentModel.Interop.Core;

public interface ChartPoint
{
  public object _ApplyDataLabels
  (XlDataLabelsType Type, object IMsoLegendKey, object AutoText,
    object HasLeaderLines);

  public IMsoBorder Border { get; }
  public object ClearFormats();
  public object Copy();
  public IMsoDataLabel DataLabel { get; }
  public object Delete();
  public int Explosion { get; set; }
  public bool HasDataLabel { get; set; }
  public IMsoInterior Interior { get; }
  public bool InvertIfNegative { get; set; }
  public int MarkerBackgroundColor { get; set; }
  public XlColorIndex MarkerBackgroundColorIndex { get; set; }
  public int MarkerForegroundColor { get; set; }
  public XlColorIndex MarkerForegroundColorIndex { get; set; }
  public int MarkerSize { get; set; }
  public XlMarkerStyle MarkerStyle { get; set; }
  public object Paste();
  public XlChartPictureType PictureType { get; set; }
  public double PictureUnit { get; set; }
  public object Select();
  public bool ApplyPictToSides { get; set; }
  public bool ApplyPictToFront { get; set; }
  public bool ApplyPictToEnd { get; set; }
  public bool Shadow { get; set; }
  public bool SecondaryPlot { get; set; }
  public ChartFillFormat Fill { get; }

  public object ApplyDataLabels
  (XlDataLabelsType Type, object IMsoLegendKey, object AutoText,
    object HasLeaderLines, object ShowSeriesName, object ShowCategoryName, object ShowValue, object ShowPercentage,
    object ShowBubbleSize, object Separator);

  public bool Has3DEffect { get; set; }
  public IMsoChartFormat Format { get; }
  public double PictureUnit2 { get; set; }
  public string Name { get; }
  public double Height { get; }
  public double Width { get; }
  public double Left { get; }
  public double Top { get; }
  public double PieSliceLocation(XlPieSliceLocation loc, XlPieSliceIndex Index);
}
