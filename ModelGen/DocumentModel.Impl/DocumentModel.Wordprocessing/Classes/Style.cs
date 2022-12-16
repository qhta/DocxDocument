namespace DocumentModel.Wordprocessing;

/// <summary>
/// Style Definition.
/// </summary>
public class StyleImpl: ModelElementImpl, Style
{
  public DocumentFormat.OpenXml.Wordprocessing.Style? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Style?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public StyleImpl(): base() {}
  
  public StyleImpl(DocumentFormat.OpenXml.Wordprocessing.Style openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Style Type
  /// </summary>
  public DocumentModel.Wordprocessing.StyleKind? Type
  {
    get => (DocumentModel.Wordprocessing.StyleKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Wordprocessing.StyleValues?)value;
    }
  }
  
  /// <summary>
  /// Style ID
  /// </summary>
  public String? StyleId
  {
    get => (System.String?)OpenXmlElement?.StyleId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StyleId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Default Style
  /// </summary>
  public Boolean? Default
  {
    get => (System.Boolean?)OpenXmlElement?.Default?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Default = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// User-Defined Style
  /// </summary>
  public Boolean? CustomStyle
  {
    get => (System.Boolean?)OpenXmlElement?.CustomStyle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CustomStyle = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Primary Style Name.
  /// </summary>
  public String? StyleName
  {
    get => (System.String?)OpenXmlElement?.StyleName?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.StyleName != null)
        {
          if (value is not null)
            OpenXmlElement.StyleName.Val = (System.String?)value;
          else
            OpenXmlElement.StyleName = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.StyleName = new DocumentFormat.OpenXml.Wordprocessing.StyleName{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Alternate Style Names.
  /// </summary>
  public String? Aliases
  {
    get => (System.String?)OpenXmlElement?.Aliases?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Aliases != null)
        {
          if (value is not null)
            OpenXmlElement.Aliases.Val = (System.String?)value;
          else
            OpenXmlElement.Aliases = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Aliases = new DocumentFormat.OpenXml.Wordprocessing.Aliases{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Parent Style ID.
  /// </summary>
  public String? BasedOn
  {
    get => (System.String?)OpenXmlElement?.BasedOn?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.BasedOn != null)
        {
          if (value is not null)
            OpenXmlElement.BasedOn.Val = (System.String?)value;
          else
            OpenXmlElement.BasedOn = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.BasedOn = new DocumentFormat.OpenXml.Wordprocessing.BasedOn{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Style For Next Paragraph.
  /// </summary>
  public String? NextParagraphStyle
  {
    get => (System.String?)OpenXmlElement?.NextParagraphStyle?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.NextParagraphStyle != null)
        {
          if (value is not null)
            OpenXmlElement.NextParagraphStyle.Val = (System.String?)value;
          else
            OpenXmlElement.NextParagraphStyle = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.NextParagraphStyle = new DocumentFormat.OpenXml.Wordprocessing.NextParagraphStyle{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Linked Style Reference.
  /// </summary>
  public String? LinkedStyle
  {
    get => (System.String?)OpenXmlElement?.LinkedStyle?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.LinkedStyle != null)
        {
          if (value is not null)
            OpenXmlElement.LinkedStyle.Val = (System.String?)value;
          else
            OpenXmlElement.LinkedStyle = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.LinkedStyle = new DocumentFormat.OpenXml.Wordprocessing.LinkedStyle{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Automatically Merge User Formatting Into Style Definition.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? AutoRedefine
  {
    get => (DocumentModel.Wordprocessing.OnOffOnlyKind?)OpenXmlElement?.AutoRedefine?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.AutoRedefine != null)
        {
          if (value is not null)
            OpenXmlElement.AutoRedefine.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            OpenXmlElement.AutoRedefine = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.AutoRedefine = new DocumentFormat.OpenXml.Wordprocessing.AutoRedefine{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Hide Style From User Interface.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? StyleHidden
  {
    get => (DocumentModel.Wordprocessing.OnOffOnlyKind?)OpenXmlElement?.StyleHidden?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.StyleHidden != null)
        {
          if (value is not null)
            OpenXmlElement.StyleHidden.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            OpenXmlElement.StyleHidden = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.StyleHidden = new DocumentFormat.OpenXml.Wordprocessing.StyleHidden{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Optional User Interface Sorting Order.
  /// </summary>
  public Int32? UIPriority
  {
    get => (System.Int32?)OpenXmlElement?.UIPriority?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.UIPriority != null)
        {
          if (value is not null)
            OpenXmlElement.UIPriority.Val = (System.Int32?)value;
          else
            OpenXmlElement.UIPriority = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.UIPriority = new DocumentFormat.OpenXml.Wordprocessing.UIPriority{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Hide Style From Main User Interface.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? SemiHidden
  {
    get => (DocumentModel.Wordprocessing.OnOffOnlyKind?)OpenXmlElement?.SemiHidden?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.SemiHidden != null)
        {
          if (value is not null)
            OpenXmlElement.SemiHidden.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            OpenXmlElement.SemiHidden = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.SemiHidden = new DocumentFormat.OpenXml.Wordprocessing.SemiHidden{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Remove Semi-Hidden Property When Style Is Used.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? UnhideWhenUsed
  {
    get => (DocumentModel.Wordprocessing.OnOffOnlyKind?)OpenXmlElement?.UnhideWhenUsed?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.UnhideWhenUsed != null)
        {
          if (value is not null)
            OpenXmlElement.UnhideWhenUsed.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            OpenXmlElement.UnhideWhenUsed = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.UnhideWhenUsed = new DocumentFormat.OpenXml.Wordprocessing.UnhideWhenUsed{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Primary Style.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? PrimaryStyle
  {
    get => (DocumentModel.Wordprocessing.OnOffOnlyKind?)OpenXmlElement?.PrimaryStyle?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.PrimaryStyle != null)
        {
          if (value is not null)
            OpenXmlElement.PrimaryStyle.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            OpenXmlElement.PrimaryStyle = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.PrimaryStyle = new DocumentFormat.OpenXml.Wordprocessing.PrimaryStyle{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Style Cannot Be Applied.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? Locked
  {
    get => (DocumentModel.Wordprocessing.OnOffOnlyKind?)OpenXmlElement?.Locked?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Locked != null)
        {
          if (value is not null)
            OpenXmlElement.Locked.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            OpenXmlElement.Locked = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Locked = new DocumentFormat.OpenXml.Wordprocessing.Locked{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// E-Mail Message Text Style.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? Personal
  {
    get => (DocumentModel.Wordprocessing.OnOffOnlyKind?)OpenXmlElement?.Personal?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Personal != null)
        {
          if (value is not null)
            OpenXmlElement.Personal.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            OpenXmlElement.Personal = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Personal = new DocumentFormat.OpenXml.Wordprocessing.Personal{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// E-Mail Message Composition Style.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? PersonalCompose
  {
    get => (DocumentModel.Wordprocessing.OnOffOnlyKind?)OpenXmlElement?.PersonalCompose?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.PersonalCompose != null)
        {
          if (value is not null)
            OpenXmlElement.PersonalCompose.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            OpenXmlElement.PersonalCompose = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.PersonalCompose = new DocumentFormat.OpenXml.Wordprocessing.PersonalCompose{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// E-Mail Message Reply Style.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? PersonalReply
  {
    get => (DocumentModel.Wordprocessing.OnOffOnlyKind?)OpenXmlElement?.PersonalReply?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.PersonalReply != null)
        {
          if (value is not null)
            OpenXmlElement.PersonalReply.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            OpenXmlElement.PersonalReply = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.PersonalReply = new DocumentFormat.OpenXml.Wordprocessing.PersonalReply{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Revision Identifier for Style Definition.
  /// </summary>
  public DocumentModel.HexWord? Rsid
  {
    get => (DocumentModel.HexWord?)OpenXmlElement?.Rsid?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Rsid != null)
        {
          if (value is not null)
            OpenXmlElement.Rsid.Val = (string?)value;
          else
            OpenXmlElement.Rsid = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Rsid = new DocumentFormat.OpenXml.Wordprocessing.Rsid{ Val = (string?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Style Paragraph Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.StyleParagraphProperties? StyleParagraphProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleParagraphProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.StyleParagraphPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleParagraphProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.StyleParagraphPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Run Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.StyleRunProperties? StyleRunProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.StyleRunPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.StyleRunPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Style Table Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.StyleTableProperties? StyleTableProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.StyleTablePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.StyleTablePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Style Table Row Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableRowProperties? TableStyleConditionalFormattingTableRowProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableRowPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableRowPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Style Table Cell Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.StyleTableCellProperties? StyleTableCellProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleTableCellProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.StyleTableCellPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleTableCellProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.StyleTableCellPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Collection<DocumentModel.Wordprocessing.TableStyleProperties>? TableStylePropertieses
  {
    get
    {
      if (_TableStylePropertieses != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties>()
            .Select(item => new DocumentModel.Wordprocessing.TableStylePropertiesImpl(item)).ToList();
          _TableStylePropertieses = new ObservableCollection<DocumentModel.Wordprocessing.TableStyleProperties>(items);
        }
        else
          _TableStylePropertieses = new ObservableCollection<DocumentModel.Wordprocessing.TableStyleProperties>();
        _TableStylePropertieses.CollectionChanged += _TableStylePropertieses_CollectionChanged;
      }
      return _TableStylePropertieses;
    }
    set
    {
      if (value != null && value != _TableStylePropertieses && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Wordprocessing.TableStylePropertiesImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.TableStyleProperties> observableCollection)
        _TableStylePropertieses = observableCollection;
      else if (value != null)
        _TableStylePropertieses = new ObservableCollection<DocumentModel.Wordprocessing.TableStyleProperties>(value);
      else
       _TableStylePropertieses = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.TableStyleProperties>? _TableStylePropertieses;
  
  private void _TableStylePropertieses_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Wordprocessing.TableStylePropertiesImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          foreach (var val in args.OldItems)
          {
        if (val is DocumentModel.Wordprocessing.TableStylePropertiesImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties>()
                          .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
            if (oldItem != null)
              oldItem.Remove();
        };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
}
