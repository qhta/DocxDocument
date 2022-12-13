namespace DocumentModel.Math;

/// <summary>
/// n-ary Properties.
/// </summary>
public class NaryPropertiesImpl: ModelElementImpl, NaryProperties
{
  public DocumentFormat.OpenXml.Math.NaryProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.NaryProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NaryPropertiesImpl(): base() {}
  
  public NaryPropertiesImpl(DocumentFormat.OpenXml.Math.NaryProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// n-ary Operator Character.
  /// </summary>
  public String? AccentChar
  {
    get => (System.String?)OpenXmlElement?.AccentChar?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.AccentChar != null)
        {
          if (value is not null)
            OpenXmlElement.AccentChar.Val = (System.String?)value;
          else
            OpenXmlElement.AccentChar = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.AccentChar = new DocumentFormat.OpenXml.Math.AccentChar{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// n-ary Limit Location.
  /// </summary>
  public DocumentModel.Math.LimitLocationKind? LimitLocation
  {
    get => (DocumentModel.Math.LimitLocationKind?)OpenXmlElement?.LimitLocation?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.LimitLocation != null)
        {
          if (value is not null)
            OpenXmlElement.LimitLocation.Val = (DocumentFormat.OpenXml.Math.LimitLocationValues?)value;
          else
            OpenXmlElement.LimitLocation = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.LimitLocation = new DocumentFormat.OpenXml.Math.LimitLocation{ Val = (DocumentFormat.OpenXml.Math.LimitLocationValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// n-ary Grow.
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
  /// Hide Subscript (n-ary).
  /// </summary>
  public DocumentModel.Math.BooleanKind? HideSubArgument
  {
    get => (DocumentModel.Math.BooleanKind?)OpenXmlElement?.HideSubArgument?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.HideSubArgument != null)
        {
          if (value is not null)
            OpenXmlElement.HideSubArgument.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            OpenXmlElement.HideSubArgument = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.HideSubArgument = new DocumentFormat.OpenXml.Math.HideSubArgument{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Hide Superscript (n-ary).
  /// </summary>
  public DocumentModel.Math.BooleanKind? HideSuperArgument
  {
    get => (DocumentModel.Math.BooleanKind?)OpenXmlElement?.HideSuperArgument?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.HideSuperArgument != null)
        {
          if (value is not null)
            OpenXmlElement.HideSuperArgument.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            OpenXmlElement.HideSuperArgument = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.HideSuperArgument = new DocumentFormat.OpenXml.Math.HideSuperArgument{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
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
