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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.AlignScripts>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.AlignScripts{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
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
