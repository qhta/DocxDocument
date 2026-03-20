using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface IMsoDataLabels: IEnumerable
{
  public string Name { get; }
  public IMsoBorder Border { get; }
  public IMsoInterior Interior { get; }
  public ChartFillFormat Fill { get; }
  public IMsoCharacters Characters { get; }
  public ChartFont Font { get; }
  public object HorizontalAlignment { get; set; }
  public object Orientation { get; set; }
  public bool Shadow { get; set; }
  public object VerticalAlignment { get; set; }
  public int ReadingOrder { get; set; }
  public object AutoScaleFont { get; set; }
  public bool AutoText { get; set; }
  public string NumberFormat { get; set; }
  public bool NumberFormatLinked { get; set; }
  public object NumberFormatLocal { get; set; }
  public bool ShowLegendKey { get; set; }
  public object Type { get; set; }
  public XlDataLabelPosition Position { get; set; }
  public bool ShowSeriesName { get; set; }
  public bool ShowCategoryName { get; set; }
  public bool ShowValue { get; set; }
  public bool ShowPercentage { get; set; }
  public bool ShowBubbleSize { get; set; }
  public object Separator { get; set; }
  public int Count { get; }
  public IMsoChartFormat Format { get; }
  public IMsoDataLabel this[object Index] { get; }
  public bool ShowRange { get; set; }
}
