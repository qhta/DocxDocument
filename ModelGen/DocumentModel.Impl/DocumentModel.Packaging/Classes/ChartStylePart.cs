namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ChartStylePart
/// </summary>
public class ChartStylePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, ChartStylePart
{
  public new DocumentFormat.OpenXml.Packaging.ChartStylePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.ChartStylePart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ChartStylePartImpl(): base() {}
  
  public ChartStylePartImpl(DocumentFormat.OpenXml.Packaging.ChartStylePart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.ChartStyle? ChartStyle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.ChartStylePart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.ChartStylePart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
