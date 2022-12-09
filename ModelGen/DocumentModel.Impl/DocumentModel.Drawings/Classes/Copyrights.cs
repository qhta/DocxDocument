namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Copyrights Class.
/// </summary>
public class CopyrightsImpl: ModelElementImpl, Copyrights
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Copyrights? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Copyrights?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<String>? CopyrightXsdstrings
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
