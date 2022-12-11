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
    get => (String?)OpenXmlElement?.Id?.Value;
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
    get => (String?)OpenXmlElement?.Style?.Value;
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
    get => (Boolean?)OpenXmlElement?.On?.Value;
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
    get => (Boolean?)OpenXmlElement?.FitShape?.Value;
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
    get => (Boolean?)OpenXmlElement?.FitPath?.Value;
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
    get => (Boolean?)OpenXmlElement?.Trim?.Value;
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
    get => (Boolean?)OpenXmlElement?.XScale?.Value;
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
    get => (String?)OpenXmlElement?.String?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.String = (System.String?)value;
    }
  }
  
}
