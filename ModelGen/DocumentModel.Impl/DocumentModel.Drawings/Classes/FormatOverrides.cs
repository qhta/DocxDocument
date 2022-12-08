namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FormatOverrides Class.
/// </summary>
public class FormatOverridesImpl: ModelElementImpl, FormatOverrides
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverrides? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverrides?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<FormatOverride>? Items
  {
    get;
    set;
  }
  
}
