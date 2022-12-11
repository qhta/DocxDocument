namespace DocumentModel.Drawings;

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
  public List<String>? Modifiers
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// LineReference.
  /// </summary>
  public virtual LineReference? LineReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// LineWidthScale.
  /// </summary>
  public virtual String? LineWidthScale
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale>();
        return openXmlElement?.Text;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale>();
        if (item != null)
        {
          if (value is not null)
            item.Text = value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale{ Text = value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// FillReference.
  /// </summary>
  public virtual FillReference? FillReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// EffectReference.
  /// </summary>
  public virtual EffectReference? EffectReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// FontReference.
  /// </summary>
  public virtual FontReference? FontReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public virtual ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TextCharacterPropertiesType.
  /// </summary>
  public virtual TextCharacterPropertiesType? TextCharacterPropertiesType
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TextBodyProperties.
  /// </summary>
  public virtual TextBodyProperties? TextBodyProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public virtual OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
