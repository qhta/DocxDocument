namespace DocumentModel.Wordprocessing;

public interface IPageMargin // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public int? Top { get ; set; }

  public uint? Right { get ; set; }

  public int? Bottom { get ; set; }

  public uint? Left { get ; set; }

  public uint? Header { get ; set; }

  public uint? Footer { get ; set; }

  public uint? Gutter { get ; set; }

}
