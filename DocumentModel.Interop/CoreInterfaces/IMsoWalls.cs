
namespace DocumentModel.Interop.Core;

public interface IMsoWalls
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
  object PictureUnit { get; set; }
  int Thickness { get; set; }
  IMsoChartFormat Format { get; }
  object Application { get; }
  int Creator { get; }
}