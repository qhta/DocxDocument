namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ChartColorStylePart
/// </summary>
public class ChartColorStylePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, ChartColorStylePart
{
  public new DocumentFormat.OpenXml.Packaging.ChartColorStylePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.ChartColorStylePart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ChartColorStylePartImpl(): base() {}
  
  public ChartColorStylePartImpl(DocumentFormat.OpenXml.Packaging.ChartColorStylePart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.ColorStyle? ColorStyle
  {
    get
    {
      if (OpenXmlElement?.ColorStyle != null)
        return new DocumentModel.Drawings.ChartsStyle.ColorStyleImpl(OpenXmlElement.ColorStyle);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Drawings.ChartsStyle.ColorStyleImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.ColorStyle = valueImpl.OpenXmlElement;
    }
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.ChartColorStylePart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.ChartColorStylePart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
