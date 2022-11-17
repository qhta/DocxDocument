namespace DocumentModel.Wordprocessing;

public interface INumberingFormat // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public NumberFormat? Val { get ; set; }

  public string? Format { get ; set; }

}
