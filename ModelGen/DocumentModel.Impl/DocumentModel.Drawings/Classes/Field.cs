namespace DocumentModel.Drawings;

/// <summary>
/// Text Field.
/// </summary>
public class FieldImpl: ModelElementImpl, Field
{
  public DocumentFormat.OpenXml.Drawing.Field? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Field?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FieldImpl(): base() {}
  
  public FieldImpl(DocumentFormat.OpenXml.Drawing.Field openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Field ID
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
  /// Field Type
  /// </summary>
  public String? Type
  {
    get => (System.String?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Text Character Properties.
  /// </summary>
  public DocumentModel.Drawings.RunProperties? RunProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Text Paragraph Properties.
  /// </summary>
  public DocumentModel.Drawings.ParagraphProperties? ParagraphProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Text.
  /// </summary>
  public String? Text
  {
    get => (System.String?)OpenXmlElement?.Text?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Text != null)
        {
          if (value is not null)
            OpenXmlElement.Text.Text = value;
          else
            OpenXmlElement.Text = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Text = new DocumentFormat.OpenXml.Drawing.Text{ Text = value };
        }
      }
    }
  }
  
}
