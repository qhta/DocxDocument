
namespace DocumentModel.Interop.Core;

public interface IMsoFloor
{
  public string Name { get; }
  public object Select();
  public IMsoBorder Border { get; }
  public object ClearFormats();
  public IMsoInterior Interior { get; }
  public ChartFillFormat Fill { get; }
  public object PictureType { get; set; }
  public void Paste();
  public int Thickness { get; set; }
  public IMsoChartFormat Format { get; }
}
