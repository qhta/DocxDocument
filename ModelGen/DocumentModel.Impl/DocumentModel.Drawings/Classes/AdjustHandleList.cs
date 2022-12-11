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
  
  public AdjustHandleListImpl(): base() {}
  
  public AdjustHandleListImpl(DocumentFormat.OpenXml.Drawing.AdjustHandleList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public AdjustHandleXY? AdjustHandleXY
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public AdjustHandlePolar? AdjustHandlePolar
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
