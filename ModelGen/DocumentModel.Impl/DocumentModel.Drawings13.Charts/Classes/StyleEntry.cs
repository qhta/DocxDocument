namespace DocumentModel.Drawings13.Charts;

/// <summary>
/// Defines the StyleEntry Class.
/// </summary>
public class StyleEntryImpl: ModelElementImpl, StyleEntry
{
  public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleEntry? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleEntry?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public StyleEntryImpl(): base() {}
  
  public StyleEntryImpl(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleEntry openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  public List<System.String>? Modifiers
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// LineReference.
  /// </summary>
  public virtual DocumentModel.Drawings13.Charts.LineReference? LineReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// LineWidthScale.
  /// </summary>
  public virtual String? LineWidthScale
  {
    get => (System.String?)OpenXmlElement?.LineWidthScale?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.LineWidthScale != null)
        {
          if (value is not null)
            OpenXmlElement.LineWidthScale.Text = value;
          else
            OpenXmlElement.LineWidthScale = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.LineWidthScale = new DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// FillReference.
  /// </summary>
  public virtual DocumentModel.Drawings13.Charts.FillReference? FillReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// EffectReference.
  /// </summary>
  public virtual DocumentModel.Drawings13.Charts.EffectReference? EffectReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// FontReference.
  /// </summary>
  public virtual DocumentModel.Drawings13.Charts.FontReference? FontReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public virtual DocumentModel.Drawings13.Charts.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TextCharacterPropertiesType.
  /// </summary>
  public virtual DocumentModel.Drawings13.Charts.TextCharacterPropertiesType? TextCharacterPropertiesType
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TextBodyProperties.
  /// </summary>
  public virtual DocumentModel.Drawings13.Charts.TextBodyProperties? TextBodyProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public virtual DocumentModel.Drawings13.Charts.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
