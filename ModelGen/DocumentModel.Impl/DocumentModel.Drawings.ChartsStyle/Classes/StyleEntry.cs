namespace DocumentModel.Drawings.ChartsStyle;

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
  public DocumentModel.ListOf<System.String>? Modifiers
  {
    get
    {
      if (OpenXmlElement?.Modifiers != null)
        return new DocumentModel.ListOf<System.String>(OpenXmlElement.Modifiers.InnerText);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value?.Items.Any() == true)
          OpenXmlElement.Modifiers = new DocumentFormat.OpenXml.ListValue<DocumentFormat.OpenXml.StringValue>(value.Items.Select(item => new DocumentFormat.OpenXml.StringValue(item)));
    else
      OpenXmlElement.Modifiers = null;
      }
    }
  }
  
  /// <summary>
  /// LineReference.
  /// </summary>
  public virtual DocumentModel.Drawings.ChartsStyle.LineReference? LineReference
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference>();
        if (item != null)
          return new DocumentModel.Drawings.ChartsStyle.LineReferenceImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartsStyle.LineReferenceImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
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
  public virtual DocumentModel.Drawings.ChartsStyle.FillReference? FillReference
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference>();
        if (item != null)
          return new DocumentModel.Drawings.ChartsStyle.FillReferenceImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartsStyle.FillReferenceImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// EffectReference.
  /// </summary>
  public virtual DocumentModel.Drawings.ChartsStyle.EffectReference? EffectReference
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference>();
        if (item != null)
          return new DocumentModel.Drawings.ChartsStyle.EffectReferenceImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartsStyle.EffectReferenceImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// FontReference.
  /// </summary>
  public virtual DocumentModel.Drawings.ChartsStyle.FontReference? FontReference
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference>();
        if (item != null)
          return new DocumentModel.Drawings.ChartsStyle.FontReferenceImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartsStyle.FontReferenceImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public virtual DocumentModel.Drawings.ChartsStyle.ShapeProperties? ShapeProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties>();
        if (item != null)
          return new DocumentModel.Drawings.ChartsStyle.ShapePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartsStyle.ShapePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// TextCharacterPropertiesType.
  /// </summary>
  public virtual DocumentModel.Drawings.ChartsStyle.TextCharacterPropertiesType? TextCharacterPropertiesType
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType>();
        if (item != null)
          return new DocumentModel.Drawings.ChartsStyle.TextCharacterPropertiesTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartsStyle.TextCharacterPropertiesTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// TextBodyProperties.
  /// </summary>
  public virtual DocumentModel.Drawings.ChartsStyle.TextBodyProperties? TextBodyProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties>();
        if (item != null)
          return new DocumentModel.Drawings.ChartsStyle.TextBodyPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartsStyle.TextBodyPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public virtual DocumentModel.Drawings.ChartsStyle.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.ChartsStyle.OfficeArtExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartsStyle.OfficeArtExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
