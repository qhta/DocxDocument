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
    get => (String?)OpenXmlElement?.Id?.Value;
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
    get => (String?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Text Character Properties.
  /// </summary>
  public RunProperties? RunProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Text Paragraph Properties.
  /// </summary>
  public ParagraphProperties? ParagraphProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Text.
  /// </summary>
  public String? Text
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Text>();
        return openXmlElement?.Text;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Text>();
        if (item != null)
        {
          if (value is not null)
            item.Text = value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Text{ Text = value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
