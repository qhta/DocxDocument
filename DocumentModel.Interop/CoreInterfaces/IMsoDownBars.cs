
namespace DocumentModel.Interop.Core;

public interface IMsoDownBars
{
  string Name { get; }
  object Select();
  IMsoBorder Border { get; }
  object Delete();
  IMsoInterior Interior { get; }
  ChartFillFormat Fill { get; }
  IMsoChartFormat Format { get; }
}