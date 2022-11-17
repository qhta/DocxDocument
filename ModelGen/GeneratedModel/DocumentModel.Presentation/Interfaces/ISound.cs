namespace DocumentModel.Presentation;

public interface ISound // : DocumentFormat.OpenXml.Presentation.EmbeddedWavAudioFileType
{
  public string? Embed { get ; set; }
  
  public string? Name { get ; set; }
  
  public bool? BuiltIn { get ; set; }
  
}
