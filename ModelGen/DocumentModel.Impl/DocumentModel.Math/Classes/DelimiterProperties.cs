namespace DocumentModel.Math;

/// <summary>
/// Delimiter Properties.
/// </summary>
public class DelimiterPropertiesImpl: ModelElementImpl, DelimiterProperties
{
  public DocumentFormat.OpenXml.Math.DelimiterProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.DelimiterProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BeginChar>();
        return (String?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BeginChar>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.String?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Math.BeginChar{ Val = (System.String?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Delimiter Separator Character.
  /// </summary>
  public String? SeparatorChar
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SeparatorChar>();
        return (String?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SeparatorChar>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.String?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Math.SeparatorChar{ Val = (System.String?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Delimiter Ending Character.
  /// </summary>
  public String? EndChar
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.EndChar>();
        return (String?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.EndChar>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.String?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Math.EndChar{ Val = (System.String?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Delimiter Grow.
  /// </summary>
  public BooleanKind? GrowOperators
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.GrowOperators>();
        return (BooleanKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.GrowOperators>();
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
            item = new DocumentFormat.OpenXml.Math.GrowOperators{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Shape (Delimiters).
  /// </summary>
  public ShapeDelimiterKind? Shape
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Shape>();
        return (ShapeDelimiterKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Shape>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Math.ShapeDelimiterValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Math.Shape{ Val = (DocumentFormat.OpenXml.Math.ShapeDelimiterValues?)value };
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
