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
    get => (System.String?)OpenXmlElement?.AccentChar?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.AccentChar != null)
        {
          if (value is not null)
            OpenXmlElement.AccentChar.Val = (System.String?)value;
          else
            OpenXmlElement.AccentChar = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.AccentChar = new DocumentFormat.OpenXml.Math.AccentChar{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Control Properties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
        if (item != null)
          return new DocumentModel.Math.ControlPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.ControlPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
