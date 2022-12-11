namespace DocumentModel.Math;

/// <summary>
/// Accent Properties.
/// </summary>
public class AccentPropertiesImpl: ModelElementImpl, AccentProperties
{
  public DocumentFormat.OpenXml.Math.AccentProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.AccentProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AccentPropertiesImpl(): base() {}
  
  public AccentPropertiesImpl(DocumentFormat.OpenXml.Math.AccentProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Accent Character.
  /// </summary>
  public String? AccentChar
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.AccentChar>();
        return (String?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.AccentChar>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.String?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Math.AccentChar{ Val = (System.String?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Control Properties.
  /// </summary>
  public ControlProperties? ControlProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
