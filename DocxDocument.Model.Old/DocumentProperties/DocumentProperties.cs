using System.Linq.Expressions;

using DocumentFormat.OpenXml.Packaging;

namespace DocxDocument.Model;

public class DocumentProperties : IDocumentProperties, ICoreDocumentProperties, IContentDocumentProperties,
  IStatisticDocumentProperties, IExtraDocumentProperties, ICustomDocumentProperties
{
  public DocumentProperties()
  {
    throw new InvalidOperationException("You must not use parameterless constructor of DocumentProperties");
  }

  public DocumentProperties(WPK.WordprocessingDocument wordprocessingDocument)
  {
    DocxDocument = wordprocessingDocument;
  }

  public WPK.WordprocessingDocument DocxDocument { get; set; }

  public DM.CoreDocumentProperties? CoreDocumentProperties
  {
    get
    {
      if (_CoreDocumentProperties == null)
      {
        try
        {
          var coreFilePropertiesPart = DocxDocument.CoreFilePropertiesPart;
          if (coreFilePropertiesPart == null)
            coreFilePropertiesPart = DocxDocument.AddCoreFilePropertiesPart();
          var coreFileProperties = DocxDocument.PackageProperties;
          _CoreDocumentProperties = new CoreDocumentProperties(coreFileProperties);
        }
        catch { }
      }
      return _CoreDocumentProperties;
    }
  }
  private DM.CoreDocumentProperties? _CoreDocumentProperties;

  public DM.ContentDocumentProperties? ContentDocumentProperties
  {
    get
    {
      if (_ContentDocumentProperties == null)
      {
        try
        {
          var extFilePropertiesPart = DocxDocument.ExtendedFilePropertiesPart;
          if (extFilePropertiesPart == null)
            extFilePropertiesPart = DocxDocument.AddExtendedFilePropertiesPart();
          var extFileProperties = extFilePropertiesPart.Properties;
          if (extFileProperties is null)
          {
            extFileProperties = new EP.Properties();
            extFilePropertiesPart.Properties = extFileProperties;
          }
          _ContentDocumentProperties = new ContentDocumentProperties(extFileProperties);
        }
        catch { }
      }
      return _ContentDocumentProperties;
    }
  }
  private DM.ContentDocumentProperties? _ContentDocumentProperties;

  public DM.StatisticDocumentProperties? StatisticDocumentProperties
  {
    get
    {
      if (_StatisticDocumentProperties == null)
      {
        try
        {
          var extFilePropertiesPart = DocxDocument.ExtendedFilePropertiesPart;
          if (extFilePropertiesPart == null)
            extFilePropertiesPart = DocxDocument.AddExtendedFilePropertiesPart();
          var extFileProperties = extFilePropertiesPart.Properties;
          if (extFileProperties is null)
          {
            extFileProperties = new EP.Properties();
            extFilePropertiesPart.Properties = extFileProperties;
          }
          _StatisticDocumentProperties = new StatisticDocumentProperties(extFileProperties);
        }
        catch { }
      }
      return _StatisticDocumentProperties;
    }
  }
  private DM.StatisticDocumentProperties? _StatisticDocumentProperties;

  public DM.CustomDocumentProperties? CustomDocumentProperties
  {
    get
    {
      if (_CustomDocumentProperties == null)
      {
        try
        {
          var customFilePropertiesPart = DocxDocument.CustomFilePropertiesPart;
          if (customFilePropertiesPart == null)
            customFilePropertiesPart = DocxDocument.AddCustomFilePropertiesPart();
          var customFileProperties = customFilePropertiesPart.Properties;
          if (customFileProperties == null)
            customFileProperties = customFilePropertiesPart.Properties = new CP.Properties();
          _CustomDocumentProperties = new DM.CustomDocumentProperties(customFileProperties);
        }
        catch { }
      }
      return _CustomDocumentProperties;
    }
  }
  private DM.CustomDocumentProperties? _CustomDocumentProperties;

  public DM.ExtraDocumentProperties? ExtraDocumentProperties
  {
    get
    {
      if (_ExtraDocumentProperties == null)
      {
        try
        {
          var mainDocumentPart = DocxDocument.MainDocumentPart;
          if (mainDocumentPart == null)
            mainDocumentPart = DocxDocument.AddMainDocumentPart();
          var documentSettingsPart = mainDocumentPart.DocumentSettingsPart;
          if (documentSettingsPart == null)
            documentSettingsPart = mainDocumentPart.AddNewPart<WPK.DocumentSettingsPart>();
          var settings = documentSettingsPart.Settings;
          if (settings == null)
            settings = documentSettingsPart.Settings = new WD.Settings();
          _ExtraDocumentProperties = new DM.ExtraDocumentProperties(settings);
        }
        catch { }
      }
      return _ExtraDocumentProperties;
    }
  }
  private DM.ExtraDocumentProperties? _ExtraDocumentProperties;


  public DM.Revisions? Revisions
  {
    get
    {
      if (_Revisions == null)
      {
        var mainDocumentPart = DocxDocument.MainDocumentPart;
        if (mainDocumentPart == null)
          mainDocumentPart = DocxDocument.AddMainDocumentPart();
        var documentSettingsPart = mainDocumentPart.DocumentSettingsPart;
        if (documentSettingsPart == null)
          documentSettingsPart = mainDocumentPart.AddNewPart<WPK.DocumentSettingsPart>();
        var settings = documentSettingsPart.Settings;
        if (settings == null)
          settings = documentSettingsPart.Settings = new WD.Settings();
        var revisions = settings.Elements<WD.Rsids>().FirstOrDefault();
        if (revisions == null)
        {
          revisions = new WD.Rsids();
          settings.AddChild(revisions);
        }
        _Revisions = new DM.Revisions(revisions);
      }
      return _Revisions;
    }
    set
    {
      var mainDocumentPart = DocxDocument.MainDocumentPart;
      if (mainDocumentPart == null)
        mainDocumentPart = DocxDocument.AddMainDocumentPart();
      var documentSettingsPart = mainDocumentPart.DocumentSettingsPart;
      if (documentSettingsPart == null)
        documentSettingsPart = mainDocumentPart.AddNewPart<WPK.DocumentSettingsPart>();
      var settings = documentSettingsPart.Settings;
      if (settings == null)
        settings = documentSettingsPart.Settings = new WD.Settings();
      var revisions = settings.Elements<WD.Rsids>().FirstOrDefault();
      if (revisions != null)
        revisions.Remove();
      if (value != null)
        settings.AddChild(value.DocxElement);
    }
  }
  private DM.Revisions? _Revisions;

  #region IDocumentProperties implementation
  static DocumentProperties()
  {
    var coreProperties = typeof(ICoreDocumentProperties).GetProperties();
    foreach (var prop in coreProperties)
      BuiltInProperties.Add(prop.Name, prop);
    var contentProperties = typeof(IContentDocumentProperties).GetProperties();
    foreach (var prop in contentProperties)
      BuiltInProperties.Add(prop.Name, prop);
    var statisticProperties = typeof(IStatisticDocumentProperties).GetProperties();
    foreach (var prop in statisticProperties)
      BuiltInProperties.Add(prop.Name, prop);
    var extraProperties = typeof(IExtraDocumentProperties).GetProperties();
    foreach (var prop in extraProperties)
      BuiltInProperties.Add(prop.Name, prop);
  }

  private static Dictionary<string, PropertyInfo> BuiltInProperties = new();

  public object? Get(string propName)
  {
    if (BuiltInProperties.TryGetValue(propName, out var prop))
      return prop.GetValue(this);
    return CustomDocumentProperties.FirstOrDefault(item => item.Name == propName);
  }

  int ICustomDocumentProperties.Count => CustomDocumentProperties?.Count ?? 0;

  public bool IsEmpty() => Count==0 && (CustomDocumentProperties?.Count ?? 0) == 0 ;

  public void Add(ICustomDocumentProperty property)
  {
    CustomDocumentProperties?.Add(property);
  }

  public bool Remove(ICustomDocumentProperty property)
  {
    return CustomDocumentProperties?.Remove(property) ?? false;
  }

  IEnumerator<ICustomDocumentProperty> IEnumerable<ICustomDocumentProperty>.GetEnumerator()
  {
    if (CustomDocumentProperties!=null)
      foreach (var item in CustomDocumentProperties)
        yield return item;
    else
      yield break;
  }

  public int Count => BuiltInProperties.Values.Where(prop => prop.GetValue(this) != null).Count();

  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }

  public IEnumerator<KeyValuePair<string, object?>> GetEnumerator()
  {
    foreach (var item in BuiltInProperties)
    {
      var prop = item.Value;
      var value = prop.GetValue(this);
      if (value != null)
        yield return new KeyValuePair<string, object?>(prop.Name, value);
    }
  }

  //public object? this[string name] => Items[name];
  //public object? Get(string name) => Items.ContainsKey(name) ? Items[name] : null;

  #endregion

  public string? Title
  {
    get => CoreDocumentProperties?.Title;
    set
    {
      if (CoreDocumentProperties != null) CoreDocumentProperties.Title = value;
    }
  }

  public string? Subject
  {
    get => CoreDocumentProperties?.Subject;
    set { if (CoreDocumentProperties!= null) CoreDocumentProperties.Subject = value; }
  }

  public string? Creator
  {
    get => CoreDocumentProperties?.Creator;
    set { if (CoreDocumentProperties!= null) CoreDocumentProperties.Creator = value; }
  }

  public string? Keywords
  {
    get => CoreDocumentProperties?.Keywords;
    set { if (CoreDocumentProperties!= null) CoreDocumentProperties.Keywords = value; }
  }

  public string? Description
  {
    get => CoreDocumentProperties?.Description;
    set { if (CoreDocumentProperties!= null) CoreDocumentProperties.Description = value; }
  }

  public string? LastModifiedBy
  {
    get => CoreDocumentProperties?.LastModifiedBy;
    set { if (CoreDocumentProperties!= null) CoreDocumentProperties.LastModifiedBy = value; }
  }

  public string? Revision
  {
    get => CoreDocumentProperties?.Revision;
    set { if (CoreDocumentProperties!= null) CoreDocumentProperties.Revision = value; }
  }

  public DateTime? LastPrinted
  {
    get => CoreDocumentProperties?.LastPrinted;
    set { if (CoreDocumentProperties!= null) CoreDocumentProperties.LastPrinted = value; }
  }

  public DateTime? Created
  {
    get => CoreDocumentProperties?.Created;
    set { if (CoreDocumentProperties!= null) CoreDocumentProperties.Created = value; }
  }

  public DateTime? LastModified
  {
    get => CoreDocumentProperties?.LastModified;
    set { if (CoreDocumentProperties!= null) CoreDocumentProperties.LastModified = value; }
  }

  public string? Category
  {
    get => CoreDocumentProperties?.Category;
    set { if (CoreDocumentProperties!= null) CoreDocumentProperties.Category = value; }
  }

  public string? ContentStatus
  {
    get => CoreDocumentProperties?.ContentStatus;
    set { if (CoreDocumentProperties!= null) CoreDocumentProperties.ContentStatus = value; }
  }

  public string? Identifier
  {
    get => CoreDocumentProperties?.Identifier;
    set { if (CoreDocumentProperties!= null) CoreDocumentProperties.Identifier = value; }
  }

  public string? ContentType
  {
    get => CoreDocumentProperties?.ContentType;
    set { if (CoreDocumentProperties!= null) CoreDocumentProperties.ContentType = value; }
  }

  public string? Version
  {
    get => CoreDocumentProperties?.Version;
    set { if (CoreDocumentProperties!= null) CoreDocumentProperties.Version = value; }
  }

  public string? Language
  {
    get => CoreDocumentProperties?.Language;
    set { if (CoreDocumentProperties!= null) CoreDocumentProperties.Language = value; }
  }

  public string? Application
  {
    get => ContentDocumentProperties?.Application;
    set { if (ContentDocumentProperties!= null) ContentDocumentProperties.Application = value; }
  }

  public string? ApplicationVersion
  {
    get => ContentDocumentProperties?.ApplicationVersion;
    set { if (ContentDocumentProperties!= null) ContentDocumentProperties.ApplicationVersion = value; }
  }

  public string? Company
  {
    get => ContentDocumentProperties?.Company;
    set { if (ContentDocumentProperties!= null) ContentDocumentProperties.Company = value; }
  }

  public byte[]? DigitalSignature
  {
    get => ContentDocumentProperties?.DigitalSignature;
    set { if (ContentDocumentProperties!= null) ContentDocumentProperties.DigitalSignature = value; }
  }

  public DocSecurity? DocumentSecurity
  {
    get => ContentDocumentProperties?.DocumentSecurity;
    set { if (ContentDocumentProperties!= null) ContentDocumentProperties.DocumentSecurity = value; }
  }

  public HeadingPairs? HeadingPairs
  {
    get => ContentDocumentProperties?.HeadingPairs;
    set { if (ContentDocumentProperties!= null) ContentDocumentProperties.HeadingPairs = value; }
  }

  public HyperlinkList? HyperlinkList
  {
    get => ContentDocumentProperties?.HyperlinkList;
    set { if (ContentDocumentProperties!= null) ContentDocumentProperties.HyperlinkList = value; }
  }

  public string? HyperlinkBase
  {
    get => ContentDocumentProperties?.HyperlinkBase;
    set { if (ContentDocumentProperties!= null) ContentDocumentProperties.HyperlinkBase = value; }
  }

  public bool? HyperlinksChanged
  {
    get => ContentDocumentProperties?.HyperlinksChanged;
    set { if (ContentDocumentProperties!= null) ContentDocumentProperties.HyperlinksChanged = value; }
  }

  public bool? LinksUpToDate
  {
    get => ContentDocumentProperties?.LinksUpToDate;
    set { if (ContentDocumentProperties!= null) ContentDocumentProperties.LinksUpToDate = value; }
  }

  public string? Manager
  {
    get => ContentDocumentProperties?.Manager;
    set { if (ContentDocumentProperties!= null) ContentDocumentProperties.Manager = value; }
  }

  public string? PresentationFormat
  {
    get => ContentDocumentProperties?.PresentationFormat;
    set { if (ContentDocumentProperties!= null) ContentDocumentProperties.PresentationFormat = value; }
  }

  public bool? ScaleCrop
  {
    get => ContentDocumentProperties?.ScaleCrop;
    set { if (ContentDocumentProperties!= null) ContentDocumentProperties.ScaleCrop = value; }
  }

  public bool? SharedDocument
  {
    get => ContentDocumentProperties?.SharedDocument;
    set { if (ContentDocumentProperties!= null) ContentDocumentProperties.SharedDocument = value; }
  }

  public string? Template
  {
    get => ContentDocumentProperties?.Template;
    set { if (ContentDocumentProperties!= null) ContentDocumentProperties.Template = value; }
  }

  public Strings? TitlesOfParts
  {
    get => ContentDocumentProperties?.TitlesOfParts;
    set { if (ContentDocumentProperties!= null) ContentDocumentProperties.TitlesOfParts = value; }
  }

  public int? TotalTime
  {
    get => StatisticDocumentProperties?.TotalTime;
    set { if (StatisticDocumentProperties!= null) StatisticDocumentProperties.TotalTime = value; }
  }

  public int? Characters
  {
    get => StatisticDocumentProperties?.Characters;
    set { if (StatisticDocumentProperties!= null) StatisticDocumentProperties.Characters = value; }
  }

  public int? CharactersWithSpaces
  {
    get => StatisticDocumentProperties?.CharactersWithSpaces;
    set { if (StatisticDocumentProperties!= null) StatisticDocumentProperties.CharactersWithSpaces = value; }
  }

  public int? Lines
  {
    get => StatisticDocumentProperties?.Lines;
    set { if (StatisticDocumentProperties!= null) StatisticDocumentProperties.Lines = value; }
  }

  public int? Pages
  {
    get => StatisticDocumentProperties?.Pages;
    set { if (StatisticDocumentProperties!= null) StatisticDocumentProperties.Pages = value; }
  }

  public int? Paragraphs
  {
    get => StatisticDocumentProperties?.Paragraphs;
    set { if (StatisticDocumentProperties!= null) StatisticDocumentProperties.Paragraphs = value; }
  }

  public int? Words
  {
    get => StatisticDocumentProperties?.Words;
    set { if (StatisticDocumentProperties!= null) StatisticDocumentProperties.Words = value; }
  }

  public int? Slides
  {
    get => StatisticDocumentProperties?.Slides;
    set { if (StatisticDocumentProperties!= null) StatisticDocumentProperties.Slides = value; }
  }

  public int? HiddenSlides
  {
    get => StatisticDocumentProperties?.HiddenSlides;
    set { if (StatisticDocumentProperties!= null) StatisticDocumentProperties.HiddenSlides = value; }
  }

  public int? MultimediaClips
  {
    get => StatisticDocumentProperties?.MultimediaClips;
    set { if (StatisticDocumentProperties!= null) StatisticDocumentProperties.MultimediaClips = value; }
  }

  public int? Notes
  {
    get => StatisticDocumentProperties?.Notes;
    set { if (StatisticDocumentProperties!= null) StatisticDocumentProperties.Notes = value; }
  }

  public HexInt? DocumentId
  {
    get => ExtraDocumentProperties?.DocumentId;
    set { if (ExtraDocumentProperties!= null) ExtraDocumentProperties.DocumentId = value; }
  }

  public Guid? PersistentDocumentId
  {
    get => ExtraDocumentProperties?.PersistentDocumentId;
    set { if (ExtraDocumentProperties!= null) ExtraDocumentProperties.PersistentDocumentId = value; }
  }

  public bool? ConflictMode
  {
    get => ExtraDocumentProperties?.ConflictMode;
    set { if (ExtraDocumentProperties!= null) ExtraDocumentProperties.ConflictMode = value; }
  }
}