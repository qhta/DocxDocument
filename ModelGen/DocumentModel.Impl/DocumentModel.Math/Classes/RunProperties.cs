namespace DocumentModel.Math;

/// <summary>
/// Run Properties.
/// </summary>
public class RunPropertiesImpl: ModelElementImpl, RunProperties
{
  public DocumentFormat.OpenXml.Math.RunProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.RunProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RunPropertiesImpl(): base() {}
  
  public RunPropertiesImpl(DocumentFormat.OpenXml.Math.RunProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Literal.
  /// </summary>
  public BooleanKind? Literal
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Literal>();
        return (BooleanKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Literal>();
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
            item = new DocumentFormat.OpenXml.Math.Literal{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public BooleanKind? NormalText
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.NormalText>();
        return (BooleanKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.NormalText>();
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
            item = new DocumentFormat.OpenXml.Math.NormalText{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public ScriptKind? Script
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Script>();
        return (ScriptKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Script>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Math.ScriptValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Math.Script{ Val = (DocumentFormat.OpenXml.Math.ScriptValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public StyleKind? Style
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Style>();
        return (StyleKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Style>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Math.StyleValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Math.Style{ Val = (DocumentFormat.OpenXml.Math.StyleValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Break? Break
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public BooleanKind? Alignment
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Alignment>();
        return (BooleanKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Alignment>();
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
            item = new DocumentFormat.OpenXml.Math.Alignment{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
