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
  
  /// <summary>
  /// Delimiter Beginning Character.
  /// </summary>
  public String? BeginChar
  {
    get;
    set;
  }
  
  /// <summary>
  /// Delimiter Separator Character.
  /// </summary>
  public String? SeparatorChar
  {
    get;
    set;
  }
  
  /// <summary>
  /// Delimiter Ending Character.
  /// </summary>
  public String? EndChar
  {
    get;
    set;
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.GrowOperators>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.GrowOperators{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Shape>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Math.ShapeDelimiterValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.Shape{ Val = (DocumentFormat.OpenXml.Math.ShapeDelimiterValues?)value };
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
    get;
    set;
  }
  
}
