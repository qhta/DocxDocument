namespace DocumentModel.Office2010.Word;

public interface IBevelTop // : DocumentFormat.OpenXml.Office2010.Word.BevelType
{
  public long? Width { get ; set; }
  
  public long? Height { get ; set; }
  
  public BevelPresetType? PresetProfileType { get ; set; }
  
}
