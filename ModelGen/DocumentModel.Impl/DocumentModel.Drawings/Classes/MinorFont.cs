namespace DocumentModel.Drawings;

/// <summary>
/// Minor fonts.
/// </summary>
public partial class MinorFontImpl: DocumentModel.Drawings.FontCollectionTypeImpl, MinorFont
{
  public new DocumentFormat.OpenXml.Drawing.MinorFont? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.MinorFont?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MinorFontImpl(): base() {}
  
  public MinorFontImpl(DocumentFormat.OpenXml.Drawing.MinorFont openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Drawings.TextFontType? LatinFont
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TextFontType>();
        if (item != null)
          return new DocumentModel.Drawings.TextFontTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TextFontType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.TextFontTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public new DocumentModel.Drawings.TextFontType? EastAsianFont
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TextFontType>();
        if (item != null)
          return new DocumentModel.Drawings.TextFontTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TextFontType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.TextFontTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public new DocumentModel.Drawings.TextFontType? ComplexScriptFont
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TextFontType>();
        if (item != null)
          return new DocumentModel.Drawings.TextFontTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TextFontType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.TextFontTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Collection<DocumentModel.Drawings.SupplementalFont>? SupplementalFonts
  {
    get
    {
      if (_SupplementalFonts != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.SupplementalFont>()
            .Select(item => new DocumentModel.Drawings.SupplementalFontImpl(item)).ToList();
          _SupplementalFonts = new ObservableCollection<DocumentModel.Drawings.SupplementalFont>(items);
        }
        else
          _SupplementalFonts = new ObservableCollection<DocumentModel.Drawings.SupplementalFont>();
        _SupplementalFonts.CollectionChanged += _SupplementalFonts_CollectionChanged;
      }
      return _SupplementalFonts;
    }
    set
    {
      if (value != null && value != _SupplementalFonts && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.SupplementalFont>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.SupplementalFontImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.SupplementalFont> observableCollection)
        _SupplementalFonts = observableCollection;
      else if (value != null)
        _SupplementalFonts = new ObservableCollection<DocumentModel.Drawings.SupplementalFont>(value);
      else
       _SupplementalFonts = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.SupplementalFont>? _SupplementalFonts;
  
  private void _SupplementalFonts_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.SupplementalFont>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.SupplementalFontImpl valImpl)
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
              if (val is DocumentModel.Drawings.SupplementalFontImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.SupplementalFont>()
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
  
  
  public DocumentModel.Drawings.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
