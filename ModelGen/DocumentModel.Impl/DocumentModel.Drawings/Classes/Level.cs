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
  
  public Collection<StringPoint>? StringPoints
  {
    get;
    set;
  }
  
}
