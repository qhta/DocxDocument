namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ChartPart
/// </summary>
public class ChartPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, ChartPart
{
  public new DocumentFormat.OpenXml.Packaging.ChartPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.ChartPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ChartPartImpl(): base() {}
  
  public ChartPartImpl(DocumentFormat.OpenXml.Packaging.ChartPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the ChartColorStyleParts of the ChartPart
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
  /// Gets the ChartStyleParts of the ChartPart
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
        typeof(DocumentFormat.OpenXml.Packaging.ChartPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets the ImageParts of the ChartPart
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
        typeof(DocumentFormat.OpenXml.Packaging.ChartPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
