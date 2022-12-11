namespace DocumentModel.Drawings;

/// <summary>
/// Text Run.
/// </summary>
public class RunImpl: ModelElementImpl, Run
{
  public DocumentFormat.OpenXml.Drawing.Run? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Run?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RunImpl(): base() {}
  
  public RunImpl(DocumentFormat.OpenXml.Drawing.Run openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
  /// Text String.
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
