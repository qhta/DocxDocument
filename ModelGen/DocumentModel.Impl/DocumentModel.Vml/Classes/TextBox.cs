namespace DocumentModel.Vml;

/// <summary>
/// Defines the TextBox Class.
/// </summary>
public class TextBoxImpl: ModelElementImpl, TextBox
{
  public DocumentFormat.OpenXml.Vml.TextBox? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.TextBox?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
  /// Text Box Inset
  /// </summary>
  public String? Inset
  {
    get => (String?)OpenXmlElement?.Inset?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Inset = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Text Box Single-Click Selection Toggle
  /// </summary>
  public Boolean? SingleClick
  {
    get => (Boolean?)OpenXmlElement?.SingleClick?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SingleClick = (System.Boolean?)value;
    }
  }
  
  public DocumentModel.Wordprocessing.TextBoxContent? TextBoxContent
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
