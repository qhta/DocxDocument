
namespace DocumentModel.Interop.Core;

public interface IMsoDownBars
{
  string Name { get; }
  object Select();
  object Parent { get; }
  IMsoBorder Border { get; }
  object Delete();
  IMsoInterior Interior { get; }
  ChartFillFormat Fill { get; }
  IMsoChartFormat Format { get; }
  object Application { get; }
  int Creator { get; }
}