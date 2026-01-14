namespace DocumentModel;

/// <summary>
///   This set of properties is evaluated on document change.
/// </summary>
public class StatisticProperties: ModelElement
{
  ///<summary>
  /// Documents that owns the core properties.
  /// </summary>
#pragma warning disable OOXML0001
  internal DXEP.Properties? ExtendedFileProperties { get; private set; }
#pragma warning restore OOXML0001

  /// <summary>
  /// Default constructor.
  /// </summary>
  public StatisticProperties()
  {
  }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="document">Wordprocessing document model</param>
  public StatisticProperties(Wordprocessing.Document document)
  {
    ExtendedFileProperties = document.WordprocessingDocument?.GetExtendedFileProperties();
    document.PropertyChanged += Document_PropertyChanged;
  }

  /// <summary>
  /// Triggered when the underlying document's WordprocessingDocument changes.
  /// </summary>
  /// <param name="sender">Should be the Wordprocessing.Document instance</param>
  /// <param name="e">PropertyChangedEventArgs with propertyName = "WordprocessingDocument"</param>
  /// <remarks>
  /// If new value is null then ExtendedFileProperties are set to null to avoid errors on properties access.
  /// If new value is not null then ExtendedFileProperties are updated to the new document's PackageProperties.
  /// </remarks>
  private void Document_PropertyChanged(object? sender, PropertyChangedEventArgs e)
  {
    if (sender is Wordprocessing.Document document)
      if (e.PropertyName == nameof(Wordprocessing.Document.WordprocessingDocument))
      {
        if (document.WordprocessingDocument == null)
        {
          ExtendedFileProperties = null;
        }
        else
        {
          ExtendedFileProperties = document.WordprocessingDocument?.GetExtendedFileProperties();
          SetValuesToExtendedFileProperties();
        }
      }
  }

  /// <summary>
  /// Gets values from ExtendedFileProperties to this instance.
  /// </summary>
  private void GetValuesFromExtendedFileProperties()
  {
    foreach (var propertyInfo in typeof(StatisticProperties).GetProperties())
    {
      var value = propertyInfo.GetValue(ExtendedFileProperties);
      propertyInfo.SetValue(this, value);
    }
  }

  /// <summary>
  /// Sets values from this instance to ExtendedFileProperties.
  /// </summary>
  private void SetValuesToExtendedFileProperties()
  {
    foreach (var propertyInfo in typeof(StatisticProperties).GetProperties())
    {
      var value = propertyInfo.GetValue(this);
      propertyInfo.SetValue(ExtendedFileProperties, value);
    }
  }

  /// <summary>
  /// Known properties that can be set in StatisticProperties
  /// </summary>
  public static KnownProperties KnownProperties { get; } = new KnownProperties(typeof(StatisticProperties));

  /// <summary>
  ///   The total number of pages of a document if applicable.
  /// </summary>
  public int? Pages
  {
    get
    {
      var str = ExtendedFileProperties?.Pages?.InnerText ?? _Pages.ToString();
      int? value = null;
      if (int.TryParse(str, out int val))
        value = val;
      _Pages = value;
      return value;
    }
    set
    {
      if (value != _Pages)
      {
        _Pages = value;
        if (ExtendedFileProperties != null)
          ExtendedFileProperties.Pages = value != null ? new DXEP.Pages(value.ToString()!) : null;
        NotifyPropertyChanged(nameof(Pages));
      }
    }
  }
  private int? _Pages;

  /// <summary>
  ///   The total number of words of a document if applicable.
  /// </summary>
  public int? Words
  {
    get
    {
      var str = ExtendedFileProperties?.Words?.InnerText ?? _Words.ToString();
      int? value = null;
      if (int.TryParse(str, out int val))
        value = val;
      _Words = value;
      return value;
    }
    set
    {
      if (value != _Words)
      {
        _Words = value;
        if (ExtendedFileProperties != null)
          ExtendedFileProperties.Words = value != null ? new DXEP.Words(value.ToString()!) : null;
        NotifyPropertyChanged(nameof(Words));
      }
    }
  }
  private int? _Words;

  /// <summary>
  ///   The total number of characters in a document.
  /// </summary>
  public int? Characters
  {
    get
    {
      var str = ExtendedFileProperties?.Characters?.InnerText ?? _Characters.ToString();
      int? value = null;
      if (int.TryParse(str, out int val))
        value = val;
      _Characters = value;
      return value;
    }
    set
    {
      if (value != _Characters)
      {
        _Characters = value;
        if (ExtendedFileProperties != null)
          ExtendedFileProperties.Characters = value != null ? new DXEP.Characters(value.ToString()!) : null;
        NotifyPropertyChanged(nameof(Characters));
      }
    }
  }
  private int? _Characters;

  /// <summary>
  ///   The total number of lines in a document when last saved by a conforming producer if applicable.
  /// </summary>
  public int? Lines
  {
    get
    {
      var str = ExtendedFileProperties?.Lines?.InnerText ?? _Lines.ToString();
      int? value = null;
      if (int.TryParse(str, out int val))
        value = val;
      _Lines = value;
      return value;
    }
    set
    {
      if (value != _Lines)
      {
        _Lines = value;
        if (ExtendedFileProperties != null)
          ExtendedFileProperties.Lines = value != null ? new DXEP.Lines(value.ToString()!) : null;
        NotifyPropertyChanged(nameof(Lines));
      }
    }
  }
  private int? _Lines;

  /// <summary>
  ///   The total number of paragraphs found in a document if applicable.
  /// </summary>
  public int? Paragraphs
  {
    get
    {
      var str = ExtendedFileProperties?.Paragraphs?.InnerText ?? _Paragraphs.ToString();
      int? value = null;
      if (int.TryParse(str, out int val))
        value = val;
      _Paragraphs = value;
      return value;
    }
    set
    {
      if (value != _Paragraphs)
      {
        _Paragraphs = value;
        if (ExtendedFileProperties != null)
          ExtendedFileProperties.Paragraphs = value != null ? new DXEP.Paragraphs(value.ToString()!) : null;
        NotifyPropertyChanged(nameof(Paragraphs));
      }
    }
  }
  private int? _Paragraphs;

  /// <summary>
  ///   The last count of the number of characters (including spaces) in this document.
  /// </summary>
  public int? CharactersWithSpaces
  {
    get
    {
      var str = ExtendedFileProperties?.CharactersWithSpaces?.InnerText ?? _CharactersWithSpaces.ToString();
      int? value = null;
      if (int.TryParse(str, out int val))
        value = val;
      _CharactersWithSpaces = value;
      return value;
    }
    set
    {
      if (value != _CharactersWithSpaces)
      {
        _CharactersWithSpaces = value;
        if (ExtendedFileProperties != null)
          ExtendedFileProperties.CharactersWithSpaces = value != null ? new DXEP.CharactersWithSpaces(value.ToString()!) : null;
        NotifyPropertyChanged(nameof(CharactersWithSpaces));
      }
    }
  }
  private int? _CharactersWithSpaces;

  /// <summary>
  ///  The total number of slides in a presentation document.
  /// </summary>
  public int? Slides
  {
    get
    {
      var str = ExtendedFileProperties?.Slides?.InnerText ?? _Slides.ToString();
      int? value = null;
      if (int.TryParse(str, out int val))
        value = val;
      _Slides = value;
      return value;
    }
    set
    {
      if (value != _Slides)
      {
        _Slides = value;
        if (ExtendedFileProperties != null)
          ExtendedFileProperties.Slides = value != null ? new DXEP.Slides(value.ToString()!) : null;
        NotifyPropertyChanged(nameof(Slides));
      }
    }
  }
  private int? _Slides;

  /// <summary>
  ///  The number of slides in a presentation containing notes.
  /// </summary>
  public int? Notes
  {
    get
    {
      var str = ExtendedFileProperties?.Notes?.InnerText ?? _Notes.ToString();
      int? value = null;
      if (int.TryParse(str, out int val))
        value = val;
      _Notes = value;
      return value;
    }
    set
    {
      if (value != _Notes)
      {
        _Notes = value;
        if (ExtendedFileProperties != null)
          ExtendedFileProperties.Notes = value != null ? new DXEP.Notes(value.ToString()!) : null;
        NotifyPropertyChanged(nameof(Notes));
      }
    }
  }
  private int? _Notes;

  /// <summary>
  ///   The number of hidden slides in a presentation document.
  /// </summary>
  public int? HiddenSlides
  {
    get
    {
      var str = ExtendedFileProperties?.HiddenSlides?.InnerText ?? _HiddenSlides.ToString();
      int? value = null;
      if (int.TryParse(str, out int val))
        value = val;
      _HiddenSlides = value;
      return value;
    }
    set
    {
      if (value != _HiddenSlides)
      {
        _HiddenSlides = value;
        if (ExtendedFileProperties != null)
          ExtendedFileProperties.HiddenSlides = value != null ? new DXEP.HiddenSlides(value.ToString()!) : null;
        NotifyPropertyChanged(nameof(HiddenSlides));
      }
    }
  }
  private int? _HiddenSlides;

  /// <summary>
  ///   The total number of sound or video clips that are present in the document.
  /// </summary>
  public int? MultimediaClips
  {
    get
    {
      var str = ExtendedFileProperties?.MultimediaClips?.InnerText ?? _MultimediaClips.ToString();
      int? value = null;
      if (int.TryParse(str, out int val))
        value = val;
      _MultimediaClips = value;
      return value;
    }
    set
    {
      if (value != _MultimediaClips)
      {
        _MultimediaClips = value;
        if (ExtendedFileProperties != null)
          ExtendedFileProperties.MultimediaClips = value != null ? new DXEP.MultimediaClips(value.ToString()!) : null;
        NotifyPropertyChanged(nameof(MultimediaClips));
      }
    }
  }
  private int? _MultimediaClips;

  /// <summary>
  ///   Total time that a document has been edited. The default time unit is minutes.
  /// </summary>
  public int? TotalTime
  {
    get
    {
      var str = ExtendedFileProperties?.TotalTime?.InnerText ?? _TotalTime.ToString();
      int? value = null;
      if (int.TryParse(str, out int val))
        value = val;
      _TotalTime = value;
      return value;
    }
    set
    {
      if (value != _TotalTime)
      {
        _TotalTime = value;
        if (ExtendedFileProperties != null)
          ExtendedFileProperties.TotalTime = value != null ? new DXEP.TotalTime(value.ToString()!) : null;
        NotifyPropertyChanged(nameof(TotalTime));
      }
    }
  }
  private int? _TotalTime;

}