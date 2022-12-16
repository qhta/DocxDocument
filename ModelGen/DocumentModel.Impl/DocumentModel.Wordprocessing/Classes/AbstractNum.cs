namespace DocumentModel.Wordprocessing;

/// <summary>
/// Abstract Numbering Definition.
/// </summary>
public class AbstractNumImpl: ModelElementImpl, AbstractNum
{
  public DocumentFormat.OpenXml.Wordprocessing.AbstractNum? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.AbstractNum?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AbstractNumImpl(): base() {}
  
  public AbstractNumImpl(DocumentFormat.OpenXml.Wordprocessing.AbstractNum openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Abstract Numbering Definition ID
  /// </summary>
  public Int32? AbstractNumberId
  {
    get => (System.Int32?)OpenXmlElement?.AbstractNumberId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AbstractNumberId = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Abstract Numbering Definition Identifier.
  /// </summary>
  public DocumentModel.HexWord? Nsid
  {
    get => (DocumentModel.HexWord?)OpenXmlElement?.Nsid?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Nsid != null)
        {
          if (value is not null)
            OpenXmlElement.Nsid.Val = (string?)value;
          else
            OpenXmlElement.Nsid = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Nsid = new DocumentFormat.OpenXml.Wordprocessing.Nsid{ Val = (string?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Abstract Numbering Definition Type.
  /// </summary>
  public DocumentModel.Wordprocessing.MultiLevelKind? MultiLevelType
  {
    get => (DocumentModel.Wordprocessing.MultiLevelKind?)OpenXmlElement?.MultiLevelType?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.MultiLevelType != null)
        {
          if (value is not null)
            OpenXmlElement.MultiLevelType.Val = (DocumentFormat.OpenXml.Wordprocessing.MultiLevelValues?)value;
          else
            OpenXmlElement.MultiLevelType = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.MultiLevelType = new DocumentFormat.OpenXml.Wordprocessing.MultiLevelType{ Val = (DocumentFormat.OpenXml.Wordprocessing.MultiLevelValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Numbering Template Code.
  /// </summary>
  public DocumentModel.HexWord? TemplateCode
  {
    get => (DocumentModel.HexWord?)OpenXmlElement?.TemplateCode?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.TemplateCode != null)
        {
          if (value is not null)
            OpenXmlElement.TemplateCode.Val = (string?)value;
          else
            OpenXmlElement.TemplateCode = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.TemplateCode = new DocumentFormat.OpenXml.Wordprocessing.TemplateCode{ Val = (string?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Abstract Numbering Definition Name.
  /// </summary>
  public String? AbstractNumDefinitionName
  {
    get => (System.String?)OpenXmlElement?.AbstractNumDefinitionName?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.AbstractNumDefinitionName != null)
        {
          if (value is not null)
            OpenXmlElement.AbstractNumDefinitionName.Val = (System.String?)value;
          else
            OpenXmlElement.AbstractNumDefinitionName = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.AbstractNumDefinitionName = new DocumentFormat.OpenXml.Wordprocessing.AbstractNumDefinitionName{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Numbering Style Definition.
  /// </summary>
  public String? StyleLink
  {
    get => (System.String?)OpenXmlElement?.StyleLink?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.StyleLink != null)
        {
          if (value is not null)
            OpenXmlElement.StyleLink.Val = (System.String?)value;
          else
            OpenXmlElement.StyleLink = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.StyleLink = new DocumentFormat.OpenXml.Wordprocessing.StyleLink{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Numbering Style Reference.
  /// </summary>
  public String? NumberingStyleLink
  {
    get => (System.String?)OpenXmlElement?.NumberingStyleLink?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.NumberingStyleLink != null)
        {
          if (value is not null)
            OpenXmlElement.NumberingStyleLink.Val = (System.String?)value;
          else
            OpenXmlElement.NumberingStyleLink = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.NumberingStyleLink = new DocumentFormat.OpenXml.Wordprocessing.NumberingStyleLink{ Val = (System.String?)value };
        }
      }
    }
  }
  
  public Collection<DocumentModel.Wordprocessing.Level>? Levels
  {
    get
    {
      if (_Levels != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Level>()
            .Select(item => new DocumentModel.Wordprocessing.LevelImpl(item)).ToList();
          _Levels = new ObservableCollection<DocumentModel.Wordprocessing.Level>(items);
        }
        else
          _Levels = new ObservableCollection<DocumentModel.Wordprocessing.Level>();
        _Levels.CollectionChanged += _Levels_CollectionChanged;
      }
      return _Levels;
    }
    set
    {
      if (value != null && value != _Levels && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Level>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Wordprocessing.LevelImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.Level> observableCollection)
        _Levels = observableCollection;
      else if (value != null)
        _Levels = new ObservableCollection<DocumentModel.Wordprocessing.Level>(value);
      else
       _Levels = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.Level>? _Levels;
  
  private void _Levels_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Level>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Wordprocessing.LevelImpl valImpl)
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
        if (val is DocumentModel.Wordprocessing.LevelImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Level>()
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
