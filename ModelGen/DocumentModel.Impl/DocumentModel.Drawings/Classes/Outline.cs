namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Outline Class.
/// </summary>
public class OutlineImpl: DocumentModel.Drawings.LinePropertiesTypeImpl, Outline
{
  public new DocumentFormat.OpenXml.Drawing.Outline? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Outline?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public OutlineImpl(): base() {}
  
  public OutlineImpl(DocumentFormat.OpenXml.Drawing.Outline openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Boolean? NoFill
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoFill>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoFill>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.NoFill();
            OpenXmlElement.AddChild(item);
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
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetDash>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Drawing.PresetLineDashValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.PresetDash{ Val = (DocumentFormat.OpenXml.Drawing.PresetLineDashValues?)value };
            OpenXmlElement.AddChild(item);
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
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Round>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Round>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.Round();
            OpenXmlElement.AddChild(item);
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
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineJoinBevel>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineJoinBevel>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.LineJoinBevel();
            OpenXmlElement.AddChild(item);
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
