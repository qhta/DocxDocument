using DocxDocument.Model.Drawing;

namespace DocxDocument.Model;

public class Styles
{

  [XmlIgnore]
  [JsonIgnore]
  public Document? Document
  {
    get => _Document;
    set
    {
      if (_Document != value)
      {
        _Document = value;
        if (DefaultRunProperties!=null)
          DefaultRunProperties.Document = value;
      }
    }
  }
  private Document? _Document;

  public void InitIndexes()
  {
    foreach (var spec in PredefinedStyles.Mapping)
    {
      var style = new Style { Type = spec.Type, Name = spec.LocalName, OrigName = spec.OrigName };
      BuiltInStyles.Add(style);
      var styleID = style.ID;
      if (styleID!=null)
        StylesIndex.Add(styleID, style);
      var origNameID = Style.NameToID(spec.OrigName);
      if (origNameID!=null)
        StylesMapping.Add(origNameID, style);
    }
  }

  /// <summary>
  /// Default character properties for document text.
  /// </summary>
  public RunProperties? DefaultRunProperties { get; set; }

  /// <summary>
  /// Font scheme taken from document theme.
  /// </summary>
  public FontScheme? FontScheme { get; set; }

  /// <summary>
  /// Built-in style definitions. Only used styles are fully specifed.
  /// </summary>
  public BuiltInStyles BuiltInStyles { get; set; } = new BuiltInStyles ();

  /// <summary>
  /// Custom style definitions and specifications.
  /// </summary>
  public Collection<Style> CustomStyles { get; set; } = new Collection<Style>();

  internal Dictionary<string, Style> StylesIndex { get; private set; } = 
    new Dictionary<string, Style>(StringComparer.OrdinalIgnoreCase);

  internal Dictionary<string, Style> StylesMapping { get; private set; } =
    new Dictionary<string, Style>(StringComparer.OrdinalIgnoreCase);

  public IEnumerator<Style> GetEnumerator()
  {
    foreach (var style in BuiltInStyles)
      yield return style;
    foreach (var style in CustomStyles)
      yield return style;
  }

  //IEnumerator IEnumerable.GetEnumerator()
  //{
  //  return GetEnumerator();
  //}


  public int Count => BuiltInStyles.Count + CustomStyles.Count;

  public void Add(Style? item)
  {
    if (item == null)
      return;
    CustomStyles.Add(item);
    var styleID = item.ID;
    if (styleID!=null)
      StylesIndex.Add(styleID, item);
  }

  public bool Remove(Style? item)
  {
    if (item == null)
      return false;
    var found = CustomStyles.Remove(item);
    if (found)
    {
      var styleID = item.ID;
      if (styleID != null)
        StylesIndex.Remove(styleID.ToLowerInvariant());
    }
    return found;
  }

  public void Clear()
  {
    BuiltInStyles.Clear();
    CustomStyles.Clear();
    StylesIndex.Clear();
  }

  public bool Contains(Style item)
  {
    return BuiltInStyles.Contains(item as Style) || CustomStyles.Contains(item as Style);
  }

  public void CopyTo(Style[] array, int arrayIndex)
  {
    BuiltInStyles.CopyTo(array, arrayIndex);
    CustomStyles.CopyTo(array, arrayIndex+BuiltInStyles.Count());
  }

  //public bool IsReadOnly => false;

  public Style this[int index]
  {
    get
    {
      if (index < 0)
        return BuiltInStyles[-index - 1];
      return CustomStyles[index];
    }
  }

  public Style? this[string str]
  {
    get
    {
      if (StylesIndex.TryGetValue(str, out var result))
        return result;
      var nameID = Style.NameToID(str);
      if (nameID == null)
        return null;
      if (StylesIndex.TryGetValue(nameID, out result))
        return result;
      if (StylesMapping.TryGetValue(nameID, out result))
        return result;
      return null;
    }
  }

}