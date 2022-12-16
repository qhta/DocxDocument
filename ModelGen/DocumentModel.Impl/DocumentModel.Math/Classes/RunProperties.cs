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
  public DocumentModel.Math.BooleanKind? Literal
  {
    get => (DocumentModel.Math.BooleanKind?)OpenXmlElement?.Literal?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Literal != null)
        {
          if (value is not null)
            OpenXmlElement.Literal.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            OpenXmlElement.Literal = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Literal = new DocumentFormat.OpenXml.Math.Literal{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
        }
      }
    }
  }
  
  public DocumentModel.Math.BooleanKind? NormalText
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.NormalText>();
        return (DocumentModel.Math.BooleanKind?)item?.Val?.Value;
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
  
  public DocumentModel.Math.ScriptKind? Script
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Script>();
        return (DocumentModel.Math.ScriptKind?)item?.Val?.Value;
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
  
  public DocumentModel.Math.StyleKind? Style
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Style>();
        return (DocumentModel.Math.StyleKind?)item?.Val?.Value;
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
  
  public DocumentModel.Math.Break? Break
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Break>();
        if (item != null)
          return new DocumentModel.Math.BreakImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Break>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.BreakImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Math.BooleanKind? Alignment
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Alignment>();
        return (DocumentModel.Math.BooleanKind?)item?.Val?.Value;
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
