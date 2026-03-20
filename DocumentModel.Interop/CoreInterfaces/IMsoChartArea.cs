
namespace DocumentModel.Interop.Core;

public interface IMsoChartArea
{
  string Name { get; }
  object Select();
  IMsoBorder Border { get; }
  object Clear();
  object ClearContents();
  object Copy();
  ChartFont Font { get; }
  bool Shadow { get; set; }
  object ClearFormats();
  double Height { get; set; }
  IMsoInterior Interior { get; }
  ChartFillFormat Fill { get; }
  double Left { get; set; }
  double Top { get; set; }
  double Width { get; set; }
  object AutoScaleFont { get; set; }
  IMsoChartFormat Format { get; }
  bool RoundedCorners { get; set; }
}