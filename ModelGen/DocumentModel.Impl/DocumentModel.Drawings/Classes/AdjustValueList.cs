namespace DocumentModel.Drawings;

/// <summary>
/// List of Shape Adjust Values.
/// </summary>
public class AdjustValueListImpl: ModelElementImpl, AdjustValueList
{
  public DocumentFormat.OpenXml.Drawing.AdjustValueList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.AdjustValueList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<ShapeGuide>? ShapeGuides
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
