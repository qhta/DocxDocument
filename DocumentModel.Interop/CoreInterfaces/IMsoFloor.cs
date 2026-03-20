
namespace DocumentModel.Interop.Core;

public interface IMsoFloor
{
  string Name { get; }
  object Select();
  IMsoBorder Border { get; }
  object ClearFormats();
  IMsoInterior Interior { get; }
  ChartFillFormat Fill { get; }
  object PictureType { get; set; }
  void Paste();
  int Thickness { get; set; }
  IMsoChartFormat Format { get; }
}