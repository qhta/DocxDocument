namespace DocumentModel.Wordprocessing;

public interface IDocGrid // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public DocGrid? Type { get ; set; }
  
  public int? LinePitch { get ; set; }
  
  public int? CharacterSpace { get ; set; }
  
}
