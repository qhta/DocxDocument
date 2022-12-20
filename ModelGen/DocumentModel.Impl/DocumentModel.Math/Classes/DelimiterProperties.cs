namespace DocumentModel.Math;

/// <summary>
/// Delimiter Properties.
/// </summary>
public partial class DelimiterPropertiesImpl: ModelElementImpl, DelimiterProperties
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Math.DelimiterProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.DelimiterProperties?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public DelimiterPropertiesImpl(): base() {}
  
  public DelimiterPropertiesImpl(DocumentFormat.OpenXml.Math.DelimiterProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Delimiter Beginning Character.
  /// </summary>
  public String? BeginChar
  {
    get => (System.String?)OpenXmlElement?.BeginChar?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.BeginChar != null)
        {
          if (value is not null)
            OpenXmlElement.BeginChar.Val = (System.String?)value;
          else
            OpenXmlElement.BeginChar = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.BeginChar = new DocumentFormat.OpenXml.Math.BeginChar{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Delimiter Separator Character.
  /// </summary>
  public String? SeparatorChar
  {
    get => (System.String?)OpenXmlElement?.SeparatorChar?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.SeparatorChar != null)
        {
          if (value is not null)
            OpenXmlElement.SeparatorChar.Val = (System.String?)value;
          else
            OpenXmlElement.SeparatorChar = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.SeparatorChar = new DocumentFormat.OpenXml.Math.SeparatorChar{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Delimiter Ending Character.
  /// </summary>
  public String? EndChar
  {
    get => (System.String?)OpenXmlElement?.EndChar?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.EndChar != null)
        {
          if (value is not null)
            OpenXmlElement.EndChar.Val = (System.String?)value;
          else
            OpenXmlElement.EndChar = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.EndChar = new DocumentFormat.OpenXml.Math.EndChar{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Delimiter Grow.
  /// </summary>
  public DocumentModel.Math.BooleanKind? GrowOperators
  {
    get => (DocumentModel.Math.BooleanKind?)OpenXmlElement?.GrowOperators?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.GrowOperators != null)
        {
          if (value is not null)
            OpenXmlElement.GrowOperators.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            OpenXmlElement.GrowOperators = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.GrowOperators = new DocumentFormat.OpenXml.Math.GrowOperators{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Shape (Delimiters).
  /// </summary>
  public DocumentModel.Math.ShapeDelimiterKind? Shape
  {
    get => (DocumentModel.Math.ShapeDelimiterKind?)OpenXmlElement?.Shape?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Shape != null)
        {
          if (value is not null)
            OpenXmlElement.Shape.Val = (DocumentFormat.OpenXml.Math.ShapeDelimiterValues?)value;
          else
            OpenXmlElement.Shape = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Shape = new DocumentFormat.OpenXml.Math.Shape{ Val = (DocumentFormat.OpenXml.Math.ShapeDelimiterValues?)value };
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
