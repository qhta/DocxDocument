namespace DocumentModel.Wordprocessing;

public interface IConditionalFormatStyle // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? Val { get ; set; }
  
  public bool? FirstRow { get ; set; }
  
  public bool? LastRow { get ; set; }
  
  public bool? FirstColumn { get ; set; }
  
  public bool? LastColumn { get ; set; }
  
  public bool? OddVerticalBand { get ; set; }
  
  public bool? EvenVerticalBand { get ; set; }
  
  public bool? OddHorizontalBand { get ; set; }
  
  public bool? EvenHorizontalBand { get ; set; }
  
  public bool? FirstRowFirstColumn { get ; set; }
  
  public bool? FirstRowLastColumn { get ; set; }
  
  public bool? LastRowFirstColumn { get ; set; }
  
  public bool? LastRowLastColumn { get ; set; }
  
}
