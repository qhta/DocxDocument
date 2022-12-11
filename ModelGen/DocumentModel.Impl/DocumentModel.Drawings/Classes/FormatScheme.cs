namespace DocumentModel.Drawings;

/// <summary>
/// Format Scheme.
/// </summary>
public class FormatSchemeImpl: ModelElementImpl, FormatScheme
{
  public DocumentFormat.OpenXml.Drawing.FormatScheme? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.FormatScheme?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FormatSchemeImpl(): base() {}
  
  public FormatSchemeImpl(DocumentFormat.OpenXml.Drawing.FormatScheme openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Name
  /// </summary>
  public String? Name
  {
    get => (String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Fill Style List.
  /// </summary>
  public FillStyleList? FillStyleList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Line Style List.
  /// </summary>
  public LineStyleList? LineStyleList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Effect Style List.
  /// </summary>
  public EffectStyleList? EffectStyleList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Background Fill Style List.
  /// </summary>
  public BackgroundFillStyleList? BackgroundFillStyleList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
