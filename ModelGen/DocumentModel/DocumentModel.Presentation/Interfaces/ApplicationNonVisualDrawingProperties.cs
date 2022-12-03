namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ApplicationNonVisualDrawingProperties Class.
/// </summary>
public interface ApplicationNonVisualDrawingProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Is a Photo Album
  /// </summary>
  public Boolean? IsPhoto { get ; set; }
  
  /// <summary>
  /// Is User Drawn
  /// </summary>
  public Boolean? UserDrawn { get ; set; }
  
  /// <summary>
  /// Placeholder Shape.
  /// </summary>
  public PlaceholderShape? PlaceholderShape { get ; set; }
  
  public DocumentModel.Drawings.AudioFromCD? AudioFromCD { get ; set; }
  
  public DocumentModel.Drawings.EmbeddedWavAudioFileType? WaveAudioFile { get ; set; }
  
  public DocumentModel.Drawings.AudioFromFile? AudioFromFile { get ; set; }
  
  public DocumentModel.Drawings.VideoFromFile? VideoFromFile { get ; set; }
  
  public DocumentModel.Drawings.QuickTimeFromFile? QuickTimeFromFile { get ; set; }
  
  public CustomerDataList? CustomerDataList { get ; set; }
  
  public ApplicationNonVisualDrawingPropertiesExtensionList? ApplicationNonVisualDrawingPropertiesExtensionList { get ; set; }
  
}
