namespace DocumentModel.Math;

/// <summary>
/// Function Properties.
/// </summary>
public partial class FunctionPropertiesImpl: ModelElementImpl, FunctionProperties
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Math.FunctionProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.FunctionProperties?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public FunctionPropertiesImpl(): base() {}
  
  public FunctionPropertiesImpl(DocumentFormat.OpenXml.Math.FunctionProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ControlProperties.
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
