namespace DocumentModel.Wordprocessing;

public interface IPageSize // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public uint? Width { get ; set; }
  
  public uint? Height { get ; set; }
  
  public PageOrientation? Orient { get ; set; }
  
  public ushort? Code { get ; set; }
  
}
