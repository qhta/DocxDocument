namespace DocumentModel;

/// <summary>
/// Defines the Gallery Class.
/// </summary>
public partial class GalleryImpl: ModelElementImpl, Gallery
{
  public DocumentFormat.OpenXml.Office2010.CustomUI.Gallery? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.CustomUI.Gallery?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GalleryImpl(): base() {}
  
  public GalleryImpl(DocumentFormat.OpenXml.Office2010.CustomUI.Gallery openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// size, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.SizeKind? Size
  {
    get => (DocumentModel.SizeKind?)OpenXmlElement?.Size?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Size = (DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues?)value;
    }
  }
  
  /// <summary>
  /// getSize, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetSize
  {
    get => (System.String?)OpenXmlElement?.GetSize?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetSize = (System.String?)value;
    }
  }
  
  /// <summary>
  /// description, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Description
  {
    get => (System.String?)OpenXmlElement?.Description?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Description = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getDescription, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetDescription
  {
    get => (System.String?)OpenXmlElement?.GetDescription?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetDescription = (System.String?)value;
    }
  }
  
  /// <summary>
  /// invalidateContentOnDrop, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? InvalidateContentOnDrop
  {
    get => (System.Boolean?)OpenXmlElement?.InvalidateContentOnDrop?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InvalidateContentOnDrop = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// columns, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Columns
  {
    get => (System.Int32?)OpenXmlElement?.Columns?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Columns = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// rows, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Rows
  {
    get => (System.Int32?)OpenXmlElement?.Rows?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Rows = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// itemWidth, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? ItemWidth
  {
    get => (System.Int32?)OpenXmlElement?.ItemWidth?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ItemWidth = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// itemHeight, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? ItemHeight
  {
    get => (System.Int32?)OpenXmlElement?.ItemHeight?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ItemHeight = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// getItemWidth, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetItemWidth
  {
    get => (System.String?)OpenXmlElement?.GetItemWidth?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetItemWidth = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getItemHeight, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetItemHeight
  {
    get => (System.String?)OpenXmlElement?.GetItemHeight?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetItemHeight = (System.String?)value;
    }
  }
  
  /// <summary>
  /// showItemLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? ShowItemLabel
  {
    get => (System.Boolean?)OpenXmlElement?.ShowItemLabel?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ShowItemLabel = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// showInRibbon, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.GalleryShowInRibbonKind? ShowInRibbon
  {
    get => (DocumentModel.GalleryShowInRibbonKind?)OpenXmlElement?.ShowInRibbon?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ShowInRibbon = (DocumentFormat.OpenXml.Office2010.CustomUI.GalleryShowInRibbonValues?)value;
    }
  }
  
  /// <summary>
  /// onAction, this property is only available in Office 2010 and later.
  /// </summary>
  public String? OnAction
  {
    get => (System.String?)OpenXmlElement?.OnAction?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.OnAction = (System.String?)value;
    }
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Enabled
  {
    get => (System.Boolean?)OpenXmlElement?.Enabled?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Enabled = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetEnabled
  {
    get => (System.String?)OpenXmlElement?.GetEnabled?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetEnabled = (System.String?)value;
    }
  }
  
  /// <summary>
  /// image, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Image
  {
    get => (System.String?)OpenXmlElement?.Image?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Image = (System.String?)value;
    }
  }
  
  /// <summary>
  /// imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  public String? ImageMso
  {
    get => (System.String?)OpenXmlElement?.ImageMso?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ImageMso = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getImage, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetImage
  {
    get => (System.String?)OpenXmlElement?.GetImage?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetImage = (System.String?)value;
    }
  }
  
  /// <summary>
  /// showItemImage, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? ShowItemImage
  {
    get => (System.Boolean?)OpenXmlElement?.ShowItemImage?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ShowItemImage = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// getItemCount, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetItemCount
  {
    get => (System.String?)OpenXmlElement?.GetItemCount?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetItemCount = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getItemLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetItemLabel
  {
    get => (System.String?)OpenXmlElement?.GetItemLabel?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetItemLabel = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getItemScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetItemScreentip
  {
    get => (System.String?)OpenXmlElement?.GetItemScreentip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetItemScreentip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getItemSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetItemSupertip
  {
    get => (System.String?)OpenXmlElement?.GetItemSupertip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetItemSupertip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getItemImage, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetItemImage
  {
    get => (System.String?)OpenXmlElement?.GetItemImage?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetItemImage = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getItemID, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetItemID
  {
    get => (System.String?)OpenXmlElement?.GetItemID?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetItemID = (System.String?)value;
    }
  }
  
  /// <summary>
  /// sizeString, this property is only available in Office 2010 and later.
  /// </summary>
  public String? SizeString
  {
    get => (System.String?)OpenXmlElement?.SizeString?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SizeString = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getSelectedItemID, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetSelectedItemID
  {
    get => (System.String?)OpenXmlElement?.GetSelectedItemID?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetSelectedItemID = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getSelectedItemIndex, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetSelectedItemIndex
  {
    get => (System.String?)OpenXmlElement?.GetSelectedItemIndex?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetSelectedItemIndex = (System.String?)value;
    }
  }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public String? QualifiedId
  {
    get => (System.String?)OpenXmlElement?.QualifiedId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.QualifiedId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Tag
  {
    get => (System.String?)OpenXmlElement?.Tag?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Tag = (System.String?)value;
    }
  }
  
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  public String? IdMso
  {
    get => (System.String?)OpenXmlElement?.IdMso?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.IdMso = (System.String?)value;
    }
  }
  
  /// <summary>
  /// screentip, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Screentip
  {
    get => (System.String?)OpenXmlElement?.Screentip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Screentip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetScreentip
  {
    get => (System.String?)OpenXmlElement?.GetScreentip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetScreentip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// supertip, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Supertip
  {
    get => (System.String?)OpenXmlElement?.Supertip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Supertip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetSupertip
  {
    get => (System.String?)OpenXmlElement?.GetSupertip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetSupertip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Label
  {
    get => (System.String?)OpenXmlElement?.Label?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Label = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetLabel
  {
    get => (System.String?)OpenXmlElement?.GetLabel?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetLabel = (System.String?)value;
    }
  }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  public String? InsertAfterMso
  {
    get => (System.String?)OpenXmlElement?.InsertAfterMso?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InsertAfterMso = (System.String?)value;
    }
  }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  public String? InsertBeforeMso
  {
    get => (System.String?)OpenXmlElement?.InsertBeforeMso?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InsertBeforeMso = (System.String?)value;
    }
  }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  public String? InsertAfterQulifiedId
  {
    get => (System.String?)OpenXmlElement?.InsertAfterQulifiedId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InsertAfterQulifiedId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  public String? InsertBeforeQulifiedId
  {
    get => (System.String?)OpenXmlElement?.InsertBeforeQulifiedId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InsertBeforeQulifiedId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Visible
  {
    get => (System.Boolean?)OpenXmlElement?.Visible?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Visible = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetVisible
  {
    get => (System.String?)OpenXmlElement?.GetVisible?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetVisible = (System.String?)value;
    }
  }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Keytip
  {
    get => (System.String?)OpenXmlElement?.Keytip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Keytip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetKeytip
  {
    get => (System.String?)OpenXmlElement?.GetKeytip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetKeytip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// showLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? ShowLabel
  {
    get => (System.Boolean?)OpenXmlElement?.ShowLabel?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ShowLabel = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// getShowLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetShowLabel
  {
    get => (System.String?)OpenXmlElement?.GetShowLabel?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetShowLabel = (System.String?)value;
    }
  }
  
  /// <summary>
  /// showImage, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? ShowImage
  {
    get => (System.Boolean?)OpenXmlElement?.ShowImage?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ShowImage = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// getShowImage, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetShowImage
  {
    get => (System.String?)OpenXmlElement?.GetShowImage?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetShowImage = (System.String?)value;
    }
  }
  
  public Collection<DocumentModel.Item>? Items
  {
    get
    {
      if (_Items != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.Item>()
            .Select(item => new DocumentModel.ItemImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.Item>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.Item>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.Item>();
        foreach (var val in value)
        {
          if (val is DocumentModel.ItemImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Item> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.Item>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.Item>? _Items;
  
  private void _Items_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.Item>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.ItemImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddChild(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.ItemImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.Item>()
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
  
  
  public Collection<DocumentModel.ButtonRegular>? ButtonRegulars
  {
    get
    {
      if (_ButtonRegulars != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>()
            .Select(item => new DocumentModel.ButtonRegularImpl(item)).ToList();
          _ButtonRegulars = new ObservableCollection<DocumentModel.ButtonRegular>(items);
        }
        else
          _ButtonRegulars = new ObservableCollection<DocumentModel.ButtonRegular>();
        _ButtonRegulars.CollectionChanged += _ButtonRegulars_CollectionChanged;
      }
      return _ButtonRegulars;
    }
    set
    {
      if (value != null && value != _ButtonRegulars && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>();
        foreach (var val in value)
        {
          if (val is DocumentModel.ButtonRegularImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.ButtonRegular> observableCollection)
        _ButtonRegulars = observableCollection;
      else if (value != null)
        _ButtonRegulars = new ObservableCollection<DocumentModel.ButtonRegular>(value);
      else
       _ButtonRegulars = null;
    }
  }
  private ObservableCollection<DocumentModel.ButtonRegular>? _ButtonRegulars;
  
  private void _ButtonRegulars_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.ButtonRegularImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddChild(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.ButtonRegularImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>()
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
