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
  public DocumentModel.Math.BooleanKind? AlignScripts
  {
    get => (DocumentModel.Math.BooleanKind?)OpenXmlElement?.AlignScripts?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.AlignScripts != null)
        {
          if (value is not null)
            OpenXmlElement.AlignScripts.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            OpenXmlElement.AlignScripts = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.AlignScripts = new DocumentFormat.OpenXml.Math.AlignScripts{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
