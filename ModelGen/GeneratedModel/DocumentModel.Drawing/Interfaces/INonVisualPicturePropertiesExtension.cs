namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NonVisualPicturePropertiesExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.ICameraTool))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.IObjectProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ISignatureLine))]
[ChildElementInfo(typeof(DocumentModel.Office2021.Drawing.Livefeed.ILiveFeedProperties))]
public interface INonVisualPicturePropertiesExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri { get ; set; }
  
}
