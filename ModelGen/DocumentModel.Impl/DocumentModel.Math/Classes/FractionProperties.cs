namespace DocumentModel.Math;

/// <summary>
/// Fraction Properties.
/// </summary>
public class FractionPropertiesImpl: ModelElementImpl, FractionProperties
{
  public DocumentFormat.OpenXml.Math.FractionProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.FractionProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FractionPropertiesImpl(): base() {}
  
  public FractionPropertiesImpl(DocumentFormat.OpenXml.Math.FractionProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Fraction type.
  /// </summary>
  public FractionKind? FractionType
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.FractionType>();
        return (FractionKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.FractionType>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Math.FractionTypeValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Math.FractionType{ Val = (DocumentFormat.OpenXml.Math.FractionTypeValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
