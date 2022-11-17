namespace DocumentModel.Office2010.Word;

public interface IUncheckedState // : DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType
{
  public string? Font { get ; set; }
  
  public IHexBinaryValue? Val { get ; set; }
  
}
