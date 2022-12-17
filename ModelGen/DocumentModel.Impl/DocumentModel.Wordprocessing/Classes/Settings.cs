namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Settings.
/// </summary>
public class SettingsImpl: ModelElementImpl, Settings
{
  public DocumentFormat.OpenXml.Wordprocessing.Settings? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Settings?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SettingsImpl(): base() {}
  
  public SettingsImpl(DocumentFormat.OpenXml.Wordprocessing.Settings openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Write Protection.
  /// </summary>
  public DocumentModel.Wordprocessing.WriteProtection? WriteProtection
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WriteProtection>();
        if (item != null)
          return new DocumentModel.Wordprocessing.WriteProtectionImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WriteProtection>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.WriteProtectionImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Document View Setting.
  /// </summary>
  public DocumentModel.Wordprocessing.ViewKind? View
  {
    get => (DocumentModel.Wordprocessing.ViewKind?)OpenXmlElement?.View?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.View != null)
        {
          if (value is not null)
            OpenXmlElement.View.Val = (DocumentFormat.OpenXml.Wordprocessing.ViewValues?)value;
          else
            OpenXmlElement.View = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.View = new DocumentFormat.OpenXml.Wordprocessing.View{ Val = (DocumentFormat.OpenXml.Wordprocessing.ViewValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Magnification Setting.
  /// </summary>
  public DocumentModel.Wordprocessing.Zoom? Zoom
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Zoom>();
        if (item != null)
          return new DocumentModel.Wordprocessing.ZoomImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Zoom>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.ZoomImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Remove Personal Information from Document Properties.
  /// </summary>
  public Boolean? RemovePersonalInformation
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RemovePersonalInformation>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RemovePersonalInformation>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.RemovePersonalInformation();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Remove Date and Time from Annotations.
  /// </summary>
  public Boolean? RemoveDateAndTime
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RemoveDateAndTime>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RemoveDateAndTime>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.RemoveDateAndTime();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Do Not Display Visual Boundary For Header/Footer or Between Pages.
  /// </summary>
  public Boolean? DoNotDisplayPageBoundaries
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotDisplayPageBoundaries>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotDisplayPageBoundaries>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DoNotDisplayPageBoundaries();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Display Background Objects When Displaying Document.
  /// </summary>
  public Boolean? DisplayBackgroundShape
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DisplayBackgroundShape>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DisplayBackgroundShape>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DisplayBackgroundShape();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Print PostScript Codes With Document Text.
  /// </summary>
  public Boolean? PrintPostScriptOverText
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrintPostScriptOverText>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrintPostScriptOverText>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.PrintPostScriptOverText();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Print Fractional Character Widths.
  /// </summary>
  public Boolean? PrintFractionalCharacterWidth
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrintFractionalCharacterWidth>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrintFractionalCharacterWidth>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.PrintFractionalCharacterWidth();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Only Print Form Field Content.
  /// </summary>
  public Boolean? PrintFormsData
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrintFormsData>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrintFormsData>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.PrintFormsData();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Embed TrueType Fonts.
  /// </summary>
  public Boolean? EmbedTrueTypeFonts
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EmbedTrueTypeFonts>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EmbedTrueTypeFonts>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.EmbedTrueTypeFonts();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Embed Common System Fonts.
  /// </summary>
  public Boolean? EmbedSystemFonts
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EmbedSystemFonts>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EmbedSystemFonts>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.EmbedSystemFonts();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Subset Fonts When Embedding.
  /// </summary>
  public Boolean? SaveSubsetFonts
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SaveSubsetFonts>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SaveSubsetFonts>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.SaveSubsetFonts();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Only Save Form Field Content.
  /// </summary>
  public Boolean? SaveFormsData
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SaveFormsData>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SaveFormsData>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.SaveFormsData();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Mirror Page Margins.
  /// </summary>
  public Boolean? MirrorMargins
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MirrorMargins>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MirrorMargins>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.MirrorMargins();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Align Paragraph and Table Borders with Page Border.
  /// </summary>
  public Boolean? AlignBorderAndEdges
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AlignBorderAndEdges>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AlignBorderAndEdges>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.AlignBorderAndEdges();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Page Border Excludes Header.
  /// </summary>
  public Boolean? BordersDoNotSurroundHeader
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BordersDoNotSurroundHeader>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BordersDoNotSurroundHeader>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.BordersDoNotSurroundHeader();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Page Border Excludes Footer.
  /// </summary>
  public Boolean? BordersDoNotSurroundFooter
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BordersDoNotSurroundFooter>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BordersDoNotSurroundFooter>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.BordersDoNotSurroundFooter();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Position Gutter At Top of Page.
  /// </summary>
  public Boolean? GutterAtTop
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.GutterAtTop>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.GutterAtTop>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.GutterAtTop();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Do Not Display Visual Indication of Spelling Errors.
  /// </summary>
  public Boolean? HideSpellingErrors
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HideSpellingErrors>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HideSpellingErrors>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.HideSpellingErrors();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Do Not Display Visual Indication of Grammatical Errors.
  /// </summary>
  public Boolean? HideGrammaticalErrors
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HideGrammaticalErrors>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HideGrammaticalErrors>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.HideGrammaticalErrors();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Collection<DocumentModel.Wordprocessing.ActiveWritingStyle>? ActiveWritingStyles
  {
    get
    {
      if (_ActiveWritingStyles != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.ActiveWritingStyle>()
            .Select(item => new DocumentModel.Wordprocessing.ActiveWritingStyleImpl(item)).ToList();
          _ActiveWritingStyles = new ObservableCollection<DocumentModel.Wordprocessing.ActiveWritingStyle>(items);
        }
        else
          _ActiveWritingStyles = new ObservableCollection<DocumentModel.Wordprocessing.ActiveWritingStyle>();
        _ActiveWritingStyles.CollectionChanged += _ActiveWritingStyles_CollectionChanged;
      }
      return _ActiveWritingStyles;
    }
    set
    {
      if (value != null && value != _ActiveWritingStyles && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.ActiveWritingStyle>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Wordprocessing.ActiveWritingStyleImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.ActiveWritingStyle> observableCollection)
        _ActiveWritingStyles = observableCollection;
      else if (value != null)
        _ActiveWritingStyles = new ObservableCollection<DocumentModel.Wordprocessing.ActiveWritingStyle>(value);
      else
       _ActiveWritingStyles = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.ActiveWritingStyle>? _ActiveWritingStyles;
  
  private void _ActiveWritingStyles_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.ActiveWritingStyle>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Wordprocessing.ActiveWritingStyleImpl valImpl)
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
              if (val is DocumentModel.Wordprocessing.ActiveWritingStyleImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.ActiveWritingStyle>()
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
  
  
  public DocumentModel.Wordprocessing.ProofState? ProofState
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ProofState>();
        if (item != null)
          return new DocumentModel.Wordprocessing.ProofStateImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ProofState>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.ProofStateImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Boolean? FormsDesign
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FormsDesign>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FormsDesign>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.FormsDesign{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.RelationshipType? AttachedTemplate
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RelationshipType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.RelationshipTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RelationshipType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.RelationshipTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Boolean? LinkStyles
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LinkStyles>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LinkStyles>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.LinkStyles{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.StylePaneFormatFilter? StylePaneFormatFilter
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter>();
        if (item != null)
          return new DocumentModel.Wordprocessing.StylePaneFormatFilterImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.StylePaneFormatFilterImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public String? StylePaneSortMethods
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StylePaneSortMethods>();
        return (System.String?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StylePaneSortMethods>();
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
            item = new DocumentFormat.OpenXml.Wordprocessing.StylePaneSortMethods{ Val = (System.String?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.DocumentKind? DocumentType
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentType>();
        return (DocumentModel.Wordprocessing.DocumentKind?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentType>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Wordprocessing.DocumentTypeValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DocumentType{ Val = (DocumentFormat.OpenXml.Wordprocessing.DocumentTypeValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.MailMerge? MailMerge
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MailMerge>();
        if (item != null)
          return new DocumentModel.Wordprocessing.MailMergeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MailMerge>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.MailMergeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.RevisionView? RevisionView
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RevisionView>();
        if (item != null)
          return new DocumentModel.Wordprocessing.RevisionViewImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RevisionView>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.RevisionViewImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Boolean? TrackRevisions
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TrackRevisions>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TrackRevisions>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.TrackRevisions{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? DoNotTrackMoves
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotTrackMoves>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotTrackMoves>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DoNotTrackMoves{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? DoNotTrackFormatting
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotTrackFormatting>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotTrackFormatting>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DoNotTrackFormatting{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.DocumentProtection? DocumentProtection
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentProtection>();
        if (item != null)
          return new DocumentModel.Wordprocessing.DocumentProtectionImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentProtection>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.DocumentProtectionImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Boolean? AutoFormatOverride
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoFormatOverride>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoFormatOverride>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.AutoFormatOverride{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Int16? DefaultTabStop
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DefaultTabStop>();
        return (System.Int16?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DefaultTabStop>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Int16?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DefaultTabStop{ Val = (System.Int16?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? AutoHyphenation
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoHyphenation>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoHyphenation>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.AutoHyphenation{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public UInt16? ConsecutiveHyphenLimit
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ConsecutiveHyphenLimit>();
        return (System.UInt16?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ConsecutiveHyphenLimit>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.UInt16?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.ConsecutiveHyphenLimit{ Val = (System.UInt16?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public String? HyphenationZone
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HyphenationZone>();
        return (System.String?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HyphenationZone>();
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
            item = new DocumentFormat.OpenXml.Wordprocessing.HyphenationZone{ Val = (System.String?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? DoNotHyphenateCaps
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotHyphenateCaps>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotHyphenateCaps>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DoNotHyphenateCaps{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? ShowEnvelope
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ShowEnvelope>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ShowEnvelope>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.ShowEnvelope{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Int32? SummaryLength
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SummaryLength>();
        return (System.Int32?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SummaryLength>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Int32?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.SummaryLength{ Val = (System.Int32?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public String? ClickAndTypeStyle
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ClickAndTypeStyle>();
        return (System.String?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ClickAndTypeStyle>();
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
            item = new DocumentFormat.OpenXml.Wordprocessing.ClickAndTypeStyle{ Val = (System.String?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public String? DefaultTableStyle
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DefaultTableStyle>();
        return (System.String?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DefaultTableStyle>();
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
            item = new DocumentFormat.OpenXml.Wordprocessing.DefaultTableStyle{ Val = (System.String?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? EvenAndOddHeaders
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EvenAndOddHeaders>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EvenAndOddHeaders>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.EvenAndOddHeaders{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? BookFoldReversePrinting
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookFoldReversePrinting>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookFoldReversePrinting>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.BookFoldReversePrinting{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? BookFoldPrinting
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookFoldPrinting>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookFoldPrinting>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.BookFoldPrinting{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Int16? BookFoldPrintingSheets
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookFoldPrintingSheets>();
        return (System.Int16?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookFoldPrintingSheets>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Int16?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.BookFoldPrintingSheets{ Val = (System.Int16?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public String? DrawingGridHorizontalSpacing
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DrawingGridHorizontalSpacing>();
        return (System.String?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DrawingGridHorizontalSpacing>();
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
            item = new DocumentFormat.OpenXml.Wordprocessing.DrawingGridHorizontalSpacing{ Val = (System.String?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public String? DrawingGridVerticalSpacing
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DrawingGridVerticalSpacing>();
        return (System.String?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DrawingGridVerticalSpacing>();
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
            item = new DocumentFormat.OpenXml.Wordprocessing.DrawingGridVerticalSpacing{ Val = (System.String?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Int32? DisplayHorizontalDrawingGrid
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DisplayHorizontalDrawingGrid>();
        return (System.Int32?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DisplayHorizontalDrawingGrid>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Int32?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DisplayHorizontalDrawingGrid{ Val = (System.Int32?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Int32? DisplayVerticalDrawingGrid
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DisplayVerticalDrawingGrid>();
        return (System.Int32?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DisplayVerticalDrawingGrid>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Int32?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DisplayVerticalDrawingGrid{ Val = (System.Int32?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? DoNotUseMarginsForDrawingGridOrigin
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotUseMarginsForDrawingGridOrigin>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotUseMarginsForDrawingGridOrigin>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DoNotUseMarginsForDrawingGridOrigin{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public String? DrawingGridHorizontalOrigin
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DrawingGridHorizontalOrigin>();
        return (System.String?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DrawingGridHorizontalOrigin>();
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
            item = new DocumentFormat.OpenXml.Wordprocessing.DrawingGridHorizontalOrigin{ Val = (System.String?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public String? DrawingGridVerticalOrigin
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DrawingGridVerticalOrigin>();
        return (System.String?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DrawingGridVerticalOrigin>();
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
            item = new DocumentFormat.OpenXml.Wordprocessing.DrawingGridVerticalOrigin{ Val = (System.String?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? DoNotShadeFormData
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotShadeFormData>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotShadeFormData>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DoNotShadeFormData{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? NoPunctuationKerning
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoPunctuationKerning>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoPunctuationKerning>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.NoPunctuationKerning{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.CharacterSpacingKind? CharacterSpacingControl
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingControl>();
        return (DocumentModel.Wordprocessing.CharacterSpacingKind?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingControl>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingControl{ Val = (DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? PrintTwoOnOne
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrintTwoOnOne>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PrintTwoOnOne>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.PrintTwoOnOne{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? StrictFirstAndLastChars
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StrictFirstAndLastChars>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StrictFirstAndLastChars>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.StrictFirstAndLastChars{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.NoLineBreaksAfterKinsoku? NoLineBreaksAfterKinsoku
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksAfterKinsoku>();
        if (item != null)
          return new DocumentModel.Wordprocessing.NoLineBreaksAfterKinsokuImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksAfterKinsoku>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.NoLineBreaksAfterKinsokuImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.NoLineBreaksBeforeKinsoku? NoLineBreaksBeforeKinsoku
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksBeforeKinsoku>();
        if (item != null)
          return new DocumentModel.Wordprocessing.NoLineBreaksBeforeKinsokuImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksBeforeKinsoku>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.NoLineBreaksBeforeKinsokuImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Boolean? SavePreviewPicture
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SavePreviewPicture>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SavePreviewPicture>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.SavePreviewPicture{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? DoNotValidateAgainstSchema
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotValidateAgainstSchema>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotValidateAgainstSchema>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DoNotValidateAgainstSchema{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? SaveInvalidXml
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SaveInvalidXml>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SaveInvalidXml>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.SaveInvalidXml{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? IgnoreMixedContent
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.IgnoreMixedContent>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.IgnoreMixedContent>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.IgnoreMixedContent{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? AlwaysShowPlaceholderText
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AlwaysShowPlaceholderText>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AlwaysShowPlaceholderText>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.AlwaysShowPlaceholderText{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? DoNotDemarcateInvalidXml
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotDemarcateInvalidXml>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotDemarcateInvalidXml>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DoNotDemarcateInvalidXml{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? SaveXmlDataOnly
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SaveXmlDataOnly>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SaveXmlDataOnly>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.SaveXmlDataOnly{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? UseXsltWhenSaving
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseXsltWhenSaving>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UseXsltWhenSaving>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.UseXsltWhenSaving{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.SaveThroughXslt? SaveThroughXslt
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SaveThroughXslt>();
        if (item != null)
          return new DocumentModel.Wordprocessing.SaveThroughXsltImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SaveThroughXslt>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.SaveThroughXsltImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Boolean? ShowXmlTags
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ShowXmlTags>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ShowXmlTags>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.ShowXmlTags{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? AlwaysMergeEmptyNamespace
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AlwaysMergeEmptyNamespace>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AlwaysMergeEmptyNamespace>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.AlwaysMergeEmptyNamespace{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? UpdateFieldsOnOpen
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UpdateFieldsOnOpen>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UpdateFieldsOnOpen>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.UpdateFieldsOnOpen{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.HeaderShapeDefaults? HeaderShapeDefaults
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HeaderShapeDefaults>();
        if (item != null)
          return new DocumentModel.Wordprocessing.HeaderShapeDefaultsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HeaderShapeDefaults>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.HeaderShapeDefaultsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.FootnoteDocumentWideProperties? FootnoteDocumentWideProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FootnoteDocumentWideProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.FootnoteDocumentWidePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FootnoteDocumentWideProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.FootnoteDocumentWidePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.EndnoteDocumentWideProperties? EndnoteDocumentWideProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EndnoteDocumentWideProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.EndnoteDocumentWidePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EndnoteDocumentWideProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.EndnoteDocumentWidePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.Compatibility? Compatibility
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Compatibility>();
        if (item != null)
          return new DocumentModel.Wordprocessing.CompatibilityImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Compatibility>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.CompatibilityImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.DocumentVariables? DocumentVariables
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentVariables>();
        if (item != null)
          return new DocumentModel.Wordprocessing.DocumentVariablesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentVariables>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.DocumentVariablesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.Rsids? Rsids
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Rsids>();
        if (item != null)
          return new DocumentModel.Wordprocessing.RsidsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Rsids>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.RsidsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Math.MathProperties? MathProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MathProperties>();
        if (item != null)
          return new DocumentModel.Math.MathPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MathProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.MathPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Boolean? UICompatibleWith97To2003
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UICompatibleWith97To2003>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UICompatibleWith97To2003>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.UICompatibleWith97To2003{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Collection<System.String>? AttachedSchemas
  {
    get
    {
      if (_AttachedSchemas != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.AttachedSchema>()
            .Select(item => item.Val?.Value ?? "").ToList();
          _AttachedSchemas = new ObservableCollection<System.String>(items);
        }
        else
          _AttachedSchemas = new ObservableCollection<System.String>();
        _AttachedSchemas.CollectionChanged += _AttachedSchemas_CollectionChanged;
      }
      return _AttachedSchemas;
    }
    set
    {
      if (value != null && value != _AttachedSchemas && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.AttachedSchema>();
        foreach (var val in value)
        {
        if (val is string str)
        {
          var item = new DocumentFormat.OpenXml.Wordprocessing.AttachedSchema{ Val = str };
          OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<System.String> observableCollection)
        _AttachedSchemas = observableCollection;
      else if (value != null)
        _AttachedSchemas = new ObservableCollection<System.String>(value);
      else
       _AttachedSchemas = null;
    }
  }
  private ObservableCollection<System.String>? _AttachedSchemas;
  
  private void _AttachedSchemas_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.AttachedSchema>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is string str)
          {
            var newItem = new DocumentFormat.OpenXml.Wordprocessing.AttachedSchema{ Val = str };
            OpenXmlElement.AddChild(newItem);
          };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          foreach (var val in args.OldItems)
          {
        if (val is string str)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.AttachedSchema>()
                          .FirstOrDefault(anItem => anItem.Val == str);
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
  
  
  public DocumentModel.Wordprocessing.LanguageType? ThemeFontLanguages
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LanguageType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.LanguageTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LanguageType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.LanguageTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.ColorSchemeMapping? ColorSchemeMapping
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping>();
        if (item != null)
          return new DocumentModel.Wordprocessing.ColorSchemeMappingImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.ColorSchemeMappingImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Boolean? DoNotIncludeSubdocsInStats
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotIncludeSubdocsInStats>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotIncludeSubdocsInStats>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DoNotIncludeSubdocsInStats{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? DoNotAutoCompressPictures
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotAutoCompressPictures>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotAutoCompressPictures>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DoNotAutoCompressPictures{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? ForceUpgrade
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ForceUpgrade>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ForceUpgrade>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.ForceUpgrade();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.Captions? Captions
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Captions>();
        if (item != null)
          return new DocumentModel.Wordprocessing.CaptionsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Captions>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.CaptionsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.ReadModeInkLockDown? ReadModeInkLockDown
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ReadModeInkLockDown>();
        if (item != null)
          return new DocumentModel.Wordprocessing.ReadModeInkLockDownImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ReadModeInkLockDown>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.ReadModeInkLockDownImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.CustomXml.SchemaLibrary? SchemaLibrary
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.CustomXmlSchemaReferences.SchemaLibrary>();
        if (item != null)
          return new DocumentModel.CustomXml.SchemaLibraryImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.CustomXmlSchemaReferences.SchemaLibrary>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.CustomXml.SchemaLibraryImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.ShapeDefaults? ShapeDefaults
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ShapeDefaults>();
        if (item != null)
          return new DocumentModel.Wordprocessing.ShapeDefaultsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ShapeDefaults>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.ShapeDefaultsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public String? DecimalSymbol
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DecimalSymbol>();
        return (System.String?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DecimalSymbol>();
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
            item = new DocumentFormat.OpenXml.Wordprocessing.DecimalSymbol{ Val = (System.String?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public String? ListSeparator
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ListSeparator>();
        return (System.String?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ListSeparator>();
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
            item = new DocumentFormat.OpenXml.Wordprocessing.ListSeparator{ Val = (System.String?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.HexBinary? DocumentId
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DocumentId>();
        if (item?.Val?.Value != null)
          return (DocumentModel.HexBinary)(string)(item.Val.Value);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DocumentId>();
        if (item != null)
          item.Remove();
        if (value != null)
        {
          item = new DocumentFormat.OpenXml.Office2010.Word.DocumentId { Val = value.ToString() };
          OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.OnOffKind? DiscardImageEditingData
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DiscardImageEditingData>();
        return (DocumentModel.Wordprocessing.OnOffKind?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DiscardImageEditingData>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Office2010.Word.OnOffValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office2010.Word.DiscardImageEditingData{ Val = (DocumentFormat.OpenXml.Office2010.Word.OnOffValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Int32? DefaultImageDpi
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DefaultImageDpi>();
        return (System.Int32?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DefaultImageDpi>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Int32?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office2010.Word.DefaultImageDpi{ Val = (System.Int32?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.OnOffKind? ConflictMode
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ConflictMode>();
        return (DocumentModel.Wordprocessing.OnOffKind?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ConflictMode>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Office2010.Word.OnOffValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office2010.Word.ConflictMode{ Val = (DocumentFormat.OpenXml.Office2010.Word.OnOffValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? ChartTrackingRefBased
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.ChartTrackingRefBased>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.ChartTrackingRefBased>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office2013.Word.ChartTrackingRefBased{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public String? PersistentDocumentId
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.PersistentDocumentId>();
        return (System.String?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.PersistentDocumentId>();
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
            item = new DocumentFormat.OpenXml.Office2013.Word.PersistentDocumentId{ Val = (System.String?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
