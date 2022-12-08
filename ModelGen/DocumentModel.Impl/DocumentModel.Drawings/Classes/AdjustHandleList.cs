namespace DocumentModel.Drawings;

/// <summary>
/// List of Shape Adjust Handles.
/// </summary>
public class AdjustHandleListImpl: ModelElementImpl, AdjustHandleList
{
  public DocumentFormat.OpenXml.Drawing.AdjustHandleList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.AdjustHandleList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<AdjustHandleXY>? AdjustHandleXYs
  {
    get;
    set;
  }
  
  public Collection<AdjustHandlePolar>? AdjustHandlePolars
  {
    get;
    set;
  }
  
}
