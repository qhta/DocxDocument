namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ExtendedChartPart
/// </summary>
public class ExtendedChartPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, ExtendedChartPart
{
  public new DocumentFormat.OpenXml.Packaging.ExtendedChartPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.ExtendedChartPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ExtendedChartPartImpl(): base() {}
  
  public ExtendedChartPartImpl(DocumentFormat.OpenXml.Packaging.ExtendedChartPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the ChartColorStyleParts of the ExtendedChartPart
  /// </summary>
  public ChartColorStylePart? ChartColorStyleParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.ChartSpace? ChartSpace
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the ChartStyleParts of the ExtendedChartPart
  /// </summary>
  public ChartStylePart? ChartStyleParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new String? ContentType
  {
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.ExtendedChartPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets the ImageParts of the ExtendedChartPart
  /// </summary>
  public ImagePart? ImageParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.ExtendedChartPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
