namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HiddenLineProperties Class.
/// </summary>
public class HiddenLinePropertiesImpl: ModelElementImpl, HiddenLineProperties
{
  public DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// line width
  /// </summary>
  public Int32? Width
  {
    get => (Int32?)OpenXmlElement?.Width?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Width = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// line cap
  /// </summary>
  public LineCapKind? CapType
  {
    get => (LineCapKind?)OpenXmlElement?.CapType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CapType = (DocumentFormat.OpenXml.Drawing.LineCapValues?)value;
    }
  }
  
  /// <summary>
  /// compound line type
  /// </summary>
  public CompoundLineKind? CompoundLineType
  {
    get => (CompoundLineKind?)OpenXmlElement?.CompoundLineType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CompoundLineType = (DocumentFormat.OpenXml.Drawing.CompoundLineValues?)value;
    }
  }
  
  /// <summary>
  /// pen alignment
  /// </summary>
  public PenAlignmentKind? Alignment
  {
    get => (PenAlignmentKind?)OpenXmlElement?.Alignment?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Alignment = (DocumentFormat.OpenXml.Drawing.PenAlignmentValues?)value;
    }
  }
  
  public Boolean? NoFill
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoFill>();
        return openXmlElement != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoFill>();
        if (openXmlElement != null)
        {
          if (value == false)
            openXmlElement.Remove();
        }
        else
        {
          if (value == true)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.NoFill();
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public SolidFill? SolidFill
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public GradientFill? GradientFill
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public PatternFill? PatternFill
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public PresetLineDashKind? PresetDash
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetDash>();
        return (PresetLineDashKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetDash>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.PresetLineDashValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.PresetDash{ Val = (DocumentFormat.OpenXml.Drawing.PresetLineDashValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public CustomDash? CustomDash
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Boolean? Round
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Round>();
        return openXmlElement != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Round>();
        if (openXmlElement != null)
        {
          if (value == false)
            openXmlElement.Remove();
        }
        else
        {
          if (value == true)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Round();
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public Boolean? LineJoinBevel
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineJoinBevel>();
        return openXmlElement != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineJoinBevel>();
        if (openXmlElement != null)
        {
          if (value == false)
            openXmlElement.Remove();
        }
        else
        {
          if (value == true)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.LineJoinBevel();
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public Miter? Miter
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public LineEndPropertiesType? HeadEnd
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public LineEndPropertiesType? TailEnd
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public LinePropertiesExtensionList? LinePropertiesExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
