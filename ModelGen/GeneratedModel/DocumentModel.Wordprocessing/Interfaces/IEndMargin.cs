namespace DocumentModel.Wordprocessing;

public interface IEndMargin // : DocumentFormat.OpenXml.Wordprocessing.TableWidthType
{
  public string? Width { get ; set; }
  
  public TableWidthUnit? Type { get ; set; }
  
}
