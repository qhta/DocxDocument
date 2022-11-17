namespace DocumentModel.Wordprocessing;

public interface IFontCharSet // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? Val { get ; set; }

  public StrictCharacterSet? StrictCharacterSet { get ; set; }

}
