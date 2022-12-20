namespace DocxDocument.Model;

/// <summary>
/// Assigns font spec to specific scripts. Three scripts are key ones: Latin, ComplexScript, EastAsia.
/// </summary>

public class FontCollection : IndexedCollection<string, FontSpec>
{
  private const string LatinFontKey = "Latin";
  private const string ComplexScriptFontKey = "ComplexScript";
  public const string EastAsianFontKey = "EastAsia";

  public FontCollection() : base("Script")
  {
  }

  /// <summary>
  /// Fast access to Latin font spec.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  public FontSpec? LatinFont
  {
    get
    {
      if (this.TryGetValue(LatinFontKey, out var font))
        return font;
      return null;
    }
    set
    {
      if (value == null)
        this.Remove(LatinFontKey);
      else
      {
        value.Script = LatinFontKey;
        if (this.ContainsKey(LatinFontKey))
          this[LatinFontKey] = value;
        else
          this.Add(LatinFontKey, value);
      }
    }
  }

  /// <summary>
  /// Fast access to ComplexScript font spec.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  public FontSpec? ComplexScriptFont
  {
    get
    {
      if (this.TryGetValue(ComplexScriptFontKey, out var font))
        return font;
      return null;
    }
    set
    {
      if (value == null)
        this.Remove(ComplexScriptFontKey);
      else
      {
        value.Script = ComplexScriptFontKey;
        if (this.ContainsKey(ComplexScriptFontKey))
          this[ComplexScriptFontKey] = value;
        else
          this.Add(ComplexScriptFontKey, value);
      }
    }
  }


  /// <summary>
  /// Fast access to EastAsia font spec.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  public FontSpec? EastAsianFont
  {
    get
    {
      if (this.TryGetValue(EastAsianFontKey, out var font))
        return font;
      return null;
    }
    set
    {
      if (value == null)
        this.Remove(EastAsianFontKey);
      else
      {
        value.Script = EastAsianFontKey;
        if (this.ContainsKey(EastAsianFontKey))
          this[EastAsianFontKey] = value;
        else
          this.Add(EastAsianFontKey, value);
      }
    }
  }

  //public void Add(FontSpec item)
  //{
  //  if (item.Script != null)
  //    this.Add(item.Script, item);
  //  else
  //    throw new InvalidOperationException("FontSpec must have Script specified");
  //}

  //public void Clear()
  //{
  //  this.Clear();
  //}

  //public bool Contains(FontSpec item)
  //{
  //  var key = item.Script;
  //  if (key != null)
  //    return this.ContainsKey(key);
  //  return false;
  //}

  //public void CopyTo(FontSpec[] array, int arrayIndex)
  //{
  //  this.Values.CopyTo(array, arrayIndex);
  //}

  //public bool Remove(FontSpec item)
  //{
  //  var key = item.Script;
  //  if (key != null)
  //    return this.Remove(key);
  //  return false;
  //}

  //public int Count => this.Count;

  //public bool IsReadOnly => false;

  //public IEnumerator<FontSpec> GetEnumerator()
  //{
  //  return this.Values.GetEnumerator();
  //}

  //IEnumerator IEnumerable.GetEnumerator()
  //{
  //  return GetEnumerator();
  //}
}