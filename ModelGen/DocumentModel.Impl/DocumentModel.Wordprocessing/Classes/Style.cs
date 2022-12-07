namespace DocumentModel.Wordprocessing;

/// <summary>
/// Style Definition.
/// </summary>
public class StyleImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.Style>, Style
{
  /// <summary>
  /// Style Type
  /// </summary>
  public StyleKind? Type
  {
    get => (StyleKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Wordprocessing.StyleValues?)value;
    }
  }
  
  /// <summary>
  /// Automatically Merge User Formatting Into Style Definition.
  /// </summary>
  public OnOffOnlyKind? AutoRedefine
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoRedefine>();
        return (OnOffOnlyKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoRedefine>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.AutoRedefine{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Hide Style From User Interface.
  /// </summary>
  public OnOffOnlyKind? StyleHidden
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleHidden>();
        return (OnOffOnlyKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleHidden>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.StyleHidden{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Hide Style From Main User Interface.
  /// </summary>
  public OnOffOnlyKind? SemiHidden
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SemiHidden>();
        return (OnOffOnlyKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SemiHidden>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.SemiHidden{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Remove Semi-Hidden Property When Style Is Used.
  /// </summary>
  public OnOffOnlyKind? UnhideWhenUsed
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UnhideWhenUsed>();
        return (OnOffOnlyKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UnhideWhenUsed>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.UnhideWhenUsed{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Primary Style.
  /// </summary>
  public OnOffOnlyKind? PrimaryStyle
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrimaryStyle>();
        return (OnOffOnlyKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrimaryStyle>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.PrimaryStyle{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Style Cannot Be Applied.
  /// </summary>
  public OnOffOnlyKind? Locked
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Locked>();
        return (OnOffOnlyKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Locked>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.Locked{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// E-Mail Message Text Style.
  /// </summary>
  public OnOffOnlyKind? Personal
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Personal>();
        return (OnOffOnlyKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Personal>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.Personal{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// E-Mail Message Composition Style.
  /// </summary>
  public OnOffOnlyKind? PersonalCompose
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PersonalCompose>();
        return (OnOffOnlyKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PersonalCompose>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.PersonalCompose{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// E-Mail Message Reply Style.
  /// </summary>
  public OnOffOnlyKind? PersonalReply
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PersonalReply>();
        return (OnOffOnlyKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PersonalReply>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.PersonalReply{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Revision Identifier for Style Definition.
  /// </summary>
  public DocumentModel.HexWord? Rsid
  {
    get;
    set;
  }
  
  /// <summary>
  /// Style Paragraph Properties.
  /// </summary>
  public StyleParagraphProperties? StyleParagraphProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Run Properties.
  /// </summary>
  public StyleRunProperties? StyleRunProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Style Table Properties.
  /// </summary>
  public StyleTableProperties? StyleTableProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Style Table Row Properties.
  /// </summary>
  public TableStyleConditionalFormattingTableRowProperties? TableStyleConditionalFormattingTableRowProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Style Table Cell Properties.
  /// </summary>
  public StyleTableCellProperties? StyleTableCellProperties
  {
    get;
    set;
  }
  
}
