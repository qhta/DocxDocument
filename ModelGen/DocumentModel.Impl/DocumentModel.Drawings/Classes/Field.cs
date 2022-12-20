namespace DocumentModel.Drawings;

/// <summary>
/// Text Field.
/// </summary>
public partial class FieldImpl: ModelElementImpl, Field
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
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RunProperties>();
        if (item != null)
          return new DocumentModel.Drawings.RunPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RunProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.RunPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Text Paragraph Properties.
  /// </summary>
  public DocumentModel.Drawings.ParagraphProperties? ParagraphProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ParagraphProperties>();
        if (item != null)
          return new DocumentModel.Drawings.ParagraphPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ParagraphProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ParagraphPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
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
