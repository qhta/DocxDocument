namespace DocumentModel.Math;

/// <summary>
/// Argument Properties.
/// </summary>
public partial class ArgumentPropertiesImpl: ModelElementImpl, ArgumentProperties
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
    get => (System.Int32?)OpenXmlElement?.ArgumentSize?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.ArgumentSize != null)
        {
          if (value is not null)
            OpenXmlElement.ArgumentSize.Val = (System.Int32?)value;
          else
            OpenXmlElement.ArgumentSize = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.ArgumentSize = new DocumentFormat.OpenXml.Math.ArgumentSize{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
}
