namespace DocumentModel.Wordprocessing;

public interface IColumns // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? EqualWidth { get ; set; }
  
  public string? Space { get ; set; }
  
  public short? ColumnCount { get ; set; }
  
  public bool? Separator { get ; set; }
  
}
