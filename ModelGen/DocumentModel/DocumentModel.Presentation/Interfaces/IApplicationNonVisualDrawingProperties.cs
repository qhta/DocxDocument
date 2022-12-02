namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ApplicationNonVisualDrawingProperties Class.
/// </summary>
public interface IApplicationNonVisualDrawingProperties // : DocumentModel.ITypedOpenXmlCompositeElement
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
  public IPlaceholderShape? PlaceholderShape { get ; set; }
  
  public DocumentModel.Drawing.IAudioFromCD? AudioFromCD { get ; set; }
  
  public DocumentModel.Drawing.IEmbeddedWavAudioFileType? WaveAudioFile { get ; set; }
  
  public DocumentModel.Drawing.IAudioFromFile? AudioFromFile { get ; set; }
  
  public DocumentModel.Drawing.IVideoFromFile? VideoFromFile { get ; set; }
  
  public DocumentModel.Drawing.IQuickTimeFromFile? QuickTimeFromFile { get ; set; }
  
  public ICustomerDataList? CustomerDataList { get ; set; }
  
  public IApplicationNonVisualDrawingPropertiesExtensionList? ApplicationNonVisualDrawingPropertiesExtensionList { get ; set; }
  
}
