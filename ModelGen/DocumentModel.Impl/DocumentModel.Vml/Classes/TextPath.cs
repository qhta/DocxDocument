namespace DocumentModel.Vml;

/// <summary>
/// Defines the TextPath Class.
/// </summary>
public class TextPathImpl: ModelElementImpl, TextPath
{
  public DocumentFormat.OpenXml.Vml.TextPath? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.TextPath?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TextPathImpl(): base() {}
  
  public TextPathImpl(DocumentFormat.OpenXml.Vml.TextPath openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shape Styling Properties
  /// </summary>
  public String? Style
  {
    get => (System.String?)OpenXmlElement?.Style?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Style = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Text Path Toggle
  /// </summary>
  public Boolean? On
  {
    get => (System.Boolean?)OpenXmlElement?.On?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.On = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Shape Fit Toggle
  /// </summary>
  public Boolean? FitShape
  {
    get => (System.Boolean?)OpenXmlElement?.FitShape?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FitShape = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Path Fit Toggle
  /// </summary>
  public Boolean? FitPath
  {
    get => (System.Boolean?)OpenXmlElement?.FitPath?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FitPath = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Text Path Trim Toggle
  /// </summary>
  public Boolean? Trim
  {
    get => (System.Boolean?)OpenXmlElement?.Trim?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Trim = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Text X-Scaling
  /// </summary>
  public Boolean? XScale
  {
    get => (System.Boolean?)OpenXmlElement?.XScale?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.XScale = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Text Path Text
  /// </summary>
  public String? String
  {
    get => (System.String?)OpenXmlElement?.String?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.String = (System.String?)value;
    }
  }
  
}
