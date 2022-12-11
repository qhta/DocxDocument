namespace DocumentModel.Math;

/// <summary>
/// Argument Properties.
/// </summary>
public class ArgumentPropertiesImpl: ModelElementImpl, ArgumentProperties
{
  public DocumentFormat.OpenXml.Math.ArgumentProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.ArgumentProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ArgumentPropertiesImpl(): base() {}
  
  public ArgumentPropertiesImpl(DocumentFormat.OpenXml.Math.ArgumentProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Argument Size.
  /// </summary>
  public Int32? ArgumentSize
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ArgumentSize>();
        return (Int32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ArgumentSize>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Int32?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Math.ArgumentSize{ Val = (System.Int32?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
