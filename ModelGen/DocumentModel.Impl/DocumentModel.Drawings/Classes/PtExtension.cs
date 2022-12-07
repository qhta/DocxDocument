namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PtExtension Class.
/// </summary>
public class PtExtensionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.PtExtension>, PtExtension
{
  public NonVisualDrawingProperties4? NonVisualDrawingProperties
  {
    get;
    set;
  }
  
}
