
namespace DocumentModel.Interop.Core;

public interface IMsoWalls
{
  public string Name { get; }
  public object Select();
  public IMsoBorder Border { get; }
  public object ClearFormats();
  public IMsoInterior Interior { get; }
  public ChartFillFormat Fill { get; }
  public object PictureType { get; set; }
  public void Paste();
  public object PictureUnit { get; set; }
  public int Thickness { get; set; }
  public IMsoChartFormat Format { get; }
}
