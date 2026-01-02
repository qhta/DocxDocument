namespace DocumentModel;
using DocumentModel.Wordprocessing;


/// <summary>
/// Collection of all document properties that is divided to several parts: core properties, 
/// content properties, statistics properties, and custom properties. 
/// Document settings and web settings are also contained in this collection.
/// </summary>
public partial class AllDocumentProperties : ICollection<DocumentProperty>
{
  /// <summary>
  /// Document that owns these properties.
  /// </summary>
  public Document Document { get; }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="document"></param>
  public AllDocumentProperties(Document document)
  {
    Document = document;
    AllKnownProperties.Add("CoreProperties",new KnownProperties(typeof(CoreProperties)));
    AllKnownProperties.Add("ContentProperties", new KnownProperties(typeof(ContentProperties)));
    AllKnownProperties.Add("StatisticProperties", new KnownProperties(typeof(StatisticProperties)));
    AllKnownProperties.Add("DocumentSettings", new KnownProperties(typeof(DocumentSettings)));
    AllKnownProperties.Add("WebSettings", new KnownProperties(typeof(WebSettings)));
    CoreProperties = new CoreProperties(Document);
  }
  /// <summary>
  /// KnownProperties of CoreProperties.
  /// </summary>
  public Dictionary<string, KnownProperties> AllKnownProperties { get; } = new ();

  /// <summary>
  /// Gets or sets the title of the document.
  /// </summary>
  public string? Title
  {
    get => CoreProperties?.Title;
    set
    {
      CoreProperties ??= new CoreProperties(Document!);
      CoreProperties.Title = value;
    }
  }


  /// <summary>
  /// Collection of core properties, which represents document properties defined in Dublin Core standard
  /// and Open Packaging Conventions. 
  /// </summary>
  [XmlIgnore]
  public CoreProperties? CoreProperties { get; set; }

  /// <summary>
  /// Collection of content properties, which represents document properties defined in Microsoft Office standard.
  /// </summary>
  [XmlIgnore]
  public ContentProperties? ContentProperties { get; set; }

  /// <summary>
  /// Collection of statistic properties, which represents document metrics like characters count.
  /// </summary>
  [XmlIgnore]
  public StatisticProperties? StatisticProperties { get; set; }

  /// <summary>
  /// Collection of document settings, which represent Word document settings.
  /// </summary>
  [XmlIgnore]
  public DocumentSettings? DocumentSettings { get; set; }

  /// <summary>
  /// Collection of web settings, which affect HTML generation.
  /// </summary>
  [XmlIgnore]
  public WebSettings? WebSettings { get; set; }

  /// <summary>
  /// Collection of custom-defined document properties.
  /// </summary>
  [XmlIgnore]
  public CustomProperties? CustomProperties { get; set; }



#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public IEnumerator<DocumentProperty> GetEnumerator()
  {
    if (CoreProperties != null)
      foreach (var property in CoreProperties)
        yield return property;
    if (ContentProperties != null)
      foreach (var property in ContentProperties)
        yield return property;
    if (StatisticProperties != null)
      foreach (var property in StatisticProperties)
        yield return property;
    if (DocumentSettings != null)
      foreach (var property in DocumentSettings)
        yield return property;
    if (WebSettings != null)
      foreach (var property in WebSettings)
        yield return property;
    if (CustomProperties != null)
      foreach (var property in CustomProperties)
        yield return property;
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }

  public void Add(DocumentProperty item)
  {
    if (item.Name != null)
    {
      if (AllKnownProperties["CoreProperties"].ContainsKey(item.Name))
      {
        CoreProperties ??= new CoreProperties(Document);
        CoreProperties.Set(item.Name, item.Value);
      }
      else
      if (AllKnownProperties["ContentProperties"].ContainsKey(item.Name))
      {
        ContentProperties ??= new ContentProperties(Document);
        ContentProperties.Set(item.Name, item.Value);
      }
      if (AllKnownProperties["ContentProperties"].ContainsKey(item.Name))
      {
        StatisticProperties ??= new StatisticProperties(Document);
        StatisticProperties.Set(item.Name, item.Value);
      }
      if (AllKnownProperties["DocumentSettings"].ContainsKey(item.Name))
      {
        DocumentSettings ??= new DocumentSettings(Document);
        DocumentSettings.Set(item.Name, item.Value);
      }

      else if (WebSettings.GetKnownProperties(typeof(WebSettings)).ContainsKey(item.Name))
      {
        if (WebSettings == null)
          WebSettings = new WebSettings();
        WebSettings.Set(item.Name, item.Value);
      }
      else
      {
        if (CustomProperties == null)
          CustomProperties = new CustomProperties();
        CustomProperties.Add(item);
      }
    }
  }

  public void Clear()
  {
    if (CoreProperties != null)
      CoreProperties.Clear();
    if (ContentProperties != null)
      ContentProperties.Clear();
    if (StatisticProperties != null)
      StatisticProperties.Clear();
    if (DocumentSettings != null)
      DocumentSettings.Clear();
    if (WebSettings != null)
      WebSettings.Clear();
    if (CustomProperties != null)
      CustomProperties.Clear();
  }

  public bool Contains(DocumentProperty item)
  {
    if (CoreProperties != null && CoreProperties.Contains(item))
      return true;
    if (ContentProperties != null && ContentProperties.Contains(item))
      return true;
    if (StatisticProperties != null && StatisticProperties.Contains(item))
      return true;
    if (DocumentSettings != null && DocumentSettings.Contains(item))
      return true;
    if (WebSettings != null && WebSettings.Contains(item))
      return true;
    if (CustomProperties != null && CustomProperties.Contains(item))
      return true;
    return false;
  }

  public void CopyTo(DocumentProperty[] array, int arrayIndex)
  {
    if (CoreProperties != null)
    {
      CoreProperties.CopyTo(array, arrayIndex);
      arrayIndex += CoreProperties.Count();
    }
    if (ContentProperties != null)
    {
      ContentProperties.CopyTo(array, arrayIndex);
      arrayIndex += ContentProperties.Count();
    }
    if (StatisticProperties != null)
    {
      StatisticProperties.CopyTo(array, arrayIndex);
      arrayIndex += StatisticProperties.Count();
    }
    if (DocumentSettings != null)
    {
      DocumentSettings.CopyTo(array, arrayIndex);
      arrayIndex += DocumentSettings.Count();
    }
    if (WebSettings != null)
    {
      WebSettings.CopyTo(array, arrayIndex);
      arrayIndex += WebSettings.Count();
    }
    if (CustomProperties != null)
      CustomProperties.CopyTo(array, arrayIndex);
  }

  public bool Remove(DocumentProperty item)
  {
    if (CoreProperties != null)
      if (CoreProperties.Remove(item))
        return true;
    if (ContentProperties != null)
      if (ContentProperties.Remove(item))
        return true;
    if (StatisticProperties != null)
      if (StatisticProperties.Remove(item))
        return true;
    if (DocumentSettings != null)
      if (DocumentSettings.Remove(item))
        return true;
    if (WebSettings != null)
      if (WebSettings.Remove(item))
        return true;
    if (CustomProperties != null)
      if (CustomProperties.Remove(item))
        return true;
    return false;
  }

  int ICollection<DocumentProperty>.Count => Count();

  bool ICollection<DocumentProperty>.IsReadOnly => false;

  public int Count()
  {
    var count = 0;
    if (CoreProperties != null)
      count += CoreProperties.Count();
    if (ContentProperties != null)
      count += ContentProperties.Count();
    if (StatisticProperties != null)
      count += StatisticProperties.Count();
    if (DocumentSettings != null)
      count += DocumentSettings.Count();
    if (WebSettings != null)
      count += WebSettings.Count();
    if (CustomProperties != null)
      count += CustomProperties.Count();
    return count;
  }

  public IEnumerable<KeyValuePair<string, PropertyModel>> GetKnownProperties()
  {
      foreach (var prop in CoreProperties.GetKnownProperties(typeof(CoreProperties)))
      {
        prop.Value.Component = CoreProperties;
        yield return prop;
      }
    //if (ContentProperties != null)
    //  foreach (var prop in ContentProperties.GetKnownProperties())
    //    yield return prop;
    //if (StatisticProperties != null)
    //  foreach (var prop in StatisticProperties.GetKnownProperties())
    //    yield return prop;
    //if (DocumentSettings != null)
    //  foreach (var prop in DocumentSettings.GetKnownProperties())
    //    yield return prop;
    //if (WebSettings != null)
    //  foreach (var prop in WebSettings.GetKnownProperties())
    //    yield return prop;
  }

  public DocumentProperty? GetProperty(string propName)
  {
    DocumentProperty? result;
    if (CoreProperties != null && CoreProperties.GetKnownProperties().ContainsKey(propName))
      result = CoreProperties.GetProperty(propName);
    else
    if (ContentProperties != null && ContentProperties.GetKnownProperties().ContainsKey(propName))
      result = ContentProperties.GetProperty(propName);
    else
    if (StatisticProperties != null && StatisticProperties.GetKnownProperties().ContainsKey(propName))
      result = StatisticProperties.GetProperty(propName);
    else
    if (DocumentSettings != null && DocumentSettings.GetKnownProperties().ContainsKey(propName))
      result = DocumentSettings.GetProperty(propName);
    else
    if (WebSettings != null && WebSettings.GetKnownProperties().ContainsKey(propName))
      result = WebSettings.GetProperty(propName);
    else
      result = CustomProperties?.GetProperty(propName);
    return result;
  }

  public object? GetValue(string propName)
  {
    object? result;
    if (CoreProperties != null && CoreProperties.GetKnownProperties().ContainsKey(propName))
      result = CoreProperties.GetValue(propName);
    else
    if (ContentProperties != null && ContentProperties.GetKnownProperties().ContainsKey(propName))
      result = ContentProperties.GetValue(propName);
    else
    if (StatisticProperties != null && StatisticProperties.GetKnownProperties().ContainsKey(propName))
      result = StatisticProperties.GetValue(propName);
    else
    if (DocumentSettings != null && DocumentSettings.GetKnownProperties().ContainsKey(propName))
      result = DocumentSettings.GetValue(propName);
    else
    if (WebSettings != null && WebSettings.GetKnownProperties().ContainsKey(propName))
      result = WebSettings.GetValue(propName);
    else
      result = CustomProperties?.GetValue(propName);
    return result;
  }

  public void Add(object item)
  {
    if (item is DocumentProperty documentProperty)
      Add(documentProperty);
  }
}