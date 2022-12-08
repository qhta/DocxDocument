namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PtExtension Class.
/// </summary>
public class PtExtensionImpl: ModelElementImpl, PtExtension
{
  public DocumentFormat.OpenXml.Drawing.PtExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.PtExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get;
    set;
  }
  
  public NonVisualDrawingProperties4? NonVisualDrawingProperties
  {
    get;
    set;
  }
  
}
