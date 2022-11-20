namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the ApplicationNonVisualDrawingProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IAudioFromCD))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IAudioFromFile))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IWaveAudioFile))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IQuickTimeFromFile))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IVideoFromFile))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IApplicationNonVisualDrawingPropertiesExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ICustomerDataList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IPlaceholderShape))]
public interface IApplicationNonVisualDrawingProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Is a Photo Album
  /// </summary>
  public bool? IsPhoto { get ; set; }
  
  /// <summary>
  /// Is User Drawn
  /// </summary>
  public bool? UserDrawn { get ; set; }
  
  /// <summary>
  /// Placeholder Shape.
  /// </summary>
  public IPlaceholderShape? PlaceholderShape { get ; set; }
  
}
