namespace DocumentModel.Drawings;

/// <summary>
/// Text Run.
/// </summary>
public partial class RunImpl: ModelElementImpl, Run
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Run? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Run?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public RunImpl(): base() {}
  
  public RunImpl(DocumentFormat.OpenXml.Drawing.Run openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
  /// Text String.
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
