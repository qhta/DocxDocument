namespace DocumentModel.Wordprocessing;

public interface IPageNumberType // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public NumberFormat? Format { get ; set; }
  
  public int? Start { get ; set; }
  
  public byte? ChapterStyle { get ; set; }
  
  public ChapterSeparator? ChapterSeparator { get ; set; }
  
}
