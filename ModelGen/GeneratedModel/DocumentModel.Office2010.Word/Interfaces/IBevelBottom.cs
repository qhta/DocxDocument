namespace DocumentModel.Office2010.Word;

public interface IBevelBottom // : DocumentFormat.OpenXml.Office2010.Word.BevelType
{
  public long? Width { get ; set; }
  
  public long? Height { get ; set; }
  
  public BevelPresetType? PresetProfileType { get ; set; }
  
}
