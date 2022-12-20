namespace DocumentModel.Math;

/// <summary>
/// Sub-Superscript Properties.
/// </summary>
public partial class SubSuperscriptPropertiesImpl: ModelElementImpl, SubSuperscriptProperties
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Math.SubSuperscriptProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.SubSuperscriptProperties?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
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
