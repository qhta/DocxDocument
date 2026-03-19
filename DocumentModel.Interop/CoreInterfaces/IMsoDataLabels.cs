using System.Collections;

namespace DocumentModel.Interop.Core;

public interface IMsoDataLabels: IEnumerable
{
  object Parent { get; }
  string Name { get; }
  object Select();
  IMsoBorder Border { get; }
  object Delete();
  IMsoInterior Interior { get; }
  ChartFillFormat Fill { get; }
  IMsoCharacters Characters { get; }
  ChartFont Font { get; }
  object HorizontalAlignment { get; set; }
  object Orientation { get; set; }
  bool Shadow { get; set; }
  object VerticalAlignment { get; set; }
  int ReadingOrder { get; set; }
  object AutoScaleFont { get; set; }
  bool AutoText { get; set; }
  string NumberFormat { get; set; }
  bool NumberFormatLinked { get; set; }
  object NumberFormatLocal { get; set; }
  bool ShowLegendKey { get; set; }
  object Type { get; set; }
  XlDataLabelPosition Position { get; set; }
  bool ShowSeriesName { get; set; }
  bool ShowCategoryName { get; set; }
  bool ShowValue { get; set; }
  bool ShowPercentage { get; set; }
  bool ShowBubbleSize { get; set; }
  object Separator { get; set; }
  int Count { get; }
  new IEnumerator GetEnumerator();
  IMsoChartFormat Format { get; }
  object Application { get; }
  int Creator { get; }
  IMsoDataLabel this[object Index] { get; }
  void Propagate(object Index);
  bool ShowRange { get; set; }
}