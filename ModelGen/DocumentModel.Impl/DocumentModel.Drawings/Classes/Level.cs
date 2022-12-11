namespace DocumentModel.Drawings;

/// <summary>
/// Level.
/// </summary>
public class LevelImpl: ModelElementImpl, Level
{
  public DocumentFormat.OpenXml.Drawing.Charts.Level? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Level?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LevelImpl(): base() {}
  
  public LevelImpl(DocumentFormat.OpenXml.Drawing.Charts.Level openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<StringPoint>? StringPoints
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
