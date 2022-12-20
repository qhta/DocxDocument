namespace DocumentModel.Vml;

/// <summary>
/// Defines the TextBox Class.
/// </summary>
public partial class TextBoxImpl: ModelElementImpl, TextBox
{
  public DocumentFormat.OpenXml.Vml.TextBox? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.TextBox?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TextBoxImpl(): base() {}
  
  public TextBoxImpl(DocumentFormat.OpenXml.Vml.TextBox openXmlElement): base(openXmlElement)
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
  /// Text Box Inset
  /// </summary>
  public String? Inset
  {
    get => (System.String?)OpenXmlElement?.Inset?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.SingleClick?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SingleClick = (System.Boolean?)value;
    }
  }
  
  public DocumentModel.Wordprocessing.TextBoxContent? TextBoxContent
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextBoxContent>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TextBoxContentImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextBoxContent>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TextBoxContentImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
