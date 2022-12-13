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
  public DocumentModel.Drawings.RunProperties? RunProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
