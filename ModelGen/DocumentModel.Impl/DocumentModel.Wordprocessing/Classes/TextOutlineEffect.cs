namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TextOutlineEffect Class.
/// </summary>
public partial class TextOutlineEffectImpl: ModelElementImpl, TextOutlineEffect
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public TextOutlineEffectImpl(): base() {}
  
  public TextOutlineEffectImpl(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// w, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? LineWidth
  {
    get => (System.Int32?)OpenXmlElement?.LineWidth?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LineWidth = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// cap, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.LineCapKind? CapType
  {
    get => (DocumentModel.Wordprocessing.LineCapKind?)OpenXmlElement?.CapType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CapType = (DocumentFormat.OpenXml.Office2010.Word.LineCapValues?)value;
    }
  }
  
  /// <summary>
  /// cmpd, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.CompoundLineKind? Compound
  {
    get => (DocumentModel.Wordprocessing.CompoundLineKind?)OpenXmlElement?.Compound?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Compound = (DocumentFormat.OpenXml.Office2010.Word.CompoundLineValues?)value;
    }
  }
  
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.PenAlignmentKind? Alignment
  {
    get => (DocumentModel.Wordprocessing.PenAlignmentKind?)OpenXmlElement?.Alignment?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Alignment = (DocumentFormat.OpenXml.Office2010.Word.PenAlignmentValues?)value;
    }
  }
  
  public Boolean? NoFillEmpty
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.NoFillEmpty>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.NoFillEmpty>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Office2010.Word.NoFillEmpty();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.SolidColorFillProperties? SolidColorFillProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SolidColorFillProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.SolidColorFillPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SolidColorFillProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.SolidColorFillPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.GradientFillProperties? GradientFillProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.GradientFillPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.GradientFillPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.PresetLineDashKind? PresetLineDashProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.PresetLineDashProperties>();
        return (DocumentModel.Wordprocessing.PresetLineDashKind?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.PresetLineDashProperties>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Office2010.Word.PresetLineDashValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office2010.Word.PresetLineDashProperties{ Val = (DocumentFormat.OpenXml.Office2010.Word.PresetLineDashValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? RoundEmpty
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RoundEmpty>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RoundEmpty>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Office2010.Word.RoundEmpty();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? BevelEmpty
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.BevelEmpty>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.BevelEmpty>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Office2010.Word.BevelEmpty();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.LineJoinMiterProperties? LineJoinMiterProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.LineJoinMiterProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.LineJoinMiterPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.LineJoinMiterProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.LineJoinMiterPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
