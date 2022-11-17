namespace DocumentModel.Wordprocessing;

public interface ILegacyNumbering // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public bool? Legacy { get ; set; }
  
  public string? LegacySpace { get ; set; }
  
  public string? LegacyIndent { get ; set; }
  
}
