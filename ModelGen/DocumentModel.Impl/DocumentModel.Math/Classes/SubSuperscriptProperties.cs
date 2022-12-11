namespace DocumentModel.Math;

/// <summary>
/// Sub-Superscript Properties.
/// </summary>
public class SubSuperscriptPropertiesImpl: ModelElementImpl, SubSuperscriptProperties
{
  public DocumentFormat.OpenXml.Math.SubSuperscriptProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.SubSuperscriptProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SubSuperscriptPropertiesImpl(): base() {}
  
  public SubSuperscriptPropertiesImpl(DocumentFormat.OpenXml.Math.SubSuperscriptProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Align Scripts.
  /// </summary>
  public BooleanKind? AlignScripts
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.AlignScripts>();
        return (BooleanKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.AlignScripts>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Math.AlignScripts{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
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
