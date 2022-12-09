namespace DocumentModel.Drawings;

/// <summary>
/// Custom Dash.
/// </summary>
public class CustomDashImpl: ModelElementImpl, CustomDash
{
  public DocumentFormat.OpenXml.Drawing.CustomDash? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.CustomDash?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<DashStop>? DashStops
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
