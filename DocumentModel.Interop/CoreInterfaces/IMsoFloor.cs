
namespace DocumentModel.Interop.Core;

public interface IMsoFloor
{
  string Name { get; }
  object Select();
  object Parent { get; }
  IMsoBorder Border { get; }
  object ClearFormats();
  IMsoInterior Interior { get; }
  ChartFillFormat Fill { get; }
  object PictureType { get; set; }
  void Paste();
  int Thickness { get; set; }
  IMsoChartFormat Format { get; }
  object Application { get; }
  int Creator { get; }
}