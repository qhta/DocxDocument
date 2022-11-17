namespace DocumentModel.Wordprocessing;

public interface ILineNumberType // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public short? CountBy { get ; set; }

  public short? Start { get ; set; }

  public string? Distance { get ; set; }

  public LineNumberRestart? Restart { get ; set; }

}
