using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines Styles.
/// </summary>
public partial class Styles : ICollection<Style>, IDictionary<string, Style>
{
  private readonly ObservableCollection<Style> _Items = null!;
  private readonly NCollection<Style> _AllStyles = null!;
  private readonly SortedDictionary<string, Style> _StyleIds = null!;

  public Styles()
  {
    _StyleIds = new SortedDictionary<string, Style>();
    _AllStyles = new NCollection<Style>(StringComparer.InvariantCultureIgnoreCase);
    _AllStyles.CollectionChanged += Styles_CollectionChanged;
    _Items = new();
    _Items.CollectionChanged += Styles_CollectionChanged;
    foreach (var item in BuiltInStyleStubs)
      _AllStyles.Add(new Style { Name = item.name, Type = item.kind, Aliases = item.alias });
  }

  /// <summary>
  /// Defines Styles.
  /// </summary>
  public Collection<Style> Items
  {
    get => _Items;
    set
    {
      foreach (var item in value)
      {
        _Items.Add(item);
      }
    }
  }

  public ICollection<Style> AllStyles
  {
    get => _AllStyles;
    set
    {
      foreach (var item in value)
      {
        _AllStyles.AddOrReplace(item);
      }
    }
  }

  public IDictionary<string, Style> StyleIndex => _StyleIds;

  public IEnumerable<Style> DefinedStyles => AllStyles.Where(item => item.IsDefined);
  public IEnumerable<Style> ParagraphStyles => AllStyles.Where(item => item.Type==StyleKind.Paragraph);
  public IEnumerable<Style> CharacterStyles => AllStyles.Where(item => item.Type==StyleKind.Character);
  public IEnumerable<Style> TableStyles => AllStyles.Where(item => item.Type==StyleKind.Table);
  public IEnumerable<Style> NumberingStyles => AllStyles.Where(item => item.Type==StyleKind.Numbering);

  public void Add(Style item)
  {
    ((ICollection<Style>)AllStyles).Add(item);
  }

  public void Clear()
  {
    ((ICollection<Style>)AllStyles).Clear();
  }

  public bool Contains(Style item)
  {
    return ((ICollection<Style>)AllStyles).Contains(item);
  }

  public void CopyTo(Style[] array, int arrayIndex)
  {
    ((ICollection<Style>)AllStyles).CopyTo(array, arrayIndex);
  }

  public bool Remove(Style item)
  {
    return ((ICollection<Style>)AllStyles).Remove(item);
  }

  public int Count => ((ICollection<Style>)AllStyles).Count;

  public bool IsReadOnly => ((ICollection<Style>)AllStyles).IsReadOnly;

  public IEnumerator<Style> GetEnumerator()
  {
    return ((IEnumerable<Style>)AllStyles).GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return ((IEnumerable)AllStyles).GetEnumerator();
  }

  public void Add(string key, Style value)
  {
    _AllStyles.TryAdd(key, value);
  }

  public bool ContainsKey(string key)
  {
    return _AllStyles.ContainsKey(key);
  }

  public bool Remove(string key)
  {
    return _AllStyles.Remove(key);
  }

  public bool TryGetValue(string key, [MaybeNullWhen(false)] out Style value)
  {
    return _AllStyles.TryGetValue(key, out value);
  }

  public Style this[string key]
  {
    get => _AllStyles[key];
    set => _AllStyles[key] = value;
  }

  public ICollection<string> Keys => _AllStyles.Keys;

  public ICollection<Style> Values => _AllStyles.Values;

  public void Add(KeyValuePair<string, Style> item)
  {
    ((ICollection<KeyValuePair<string, Style>>)_AllStyles).Add(item);
  }

  public bool Contains(KeyValuePair<string, Style> item)
  {
    return ((ICollection<KeyValuePair<string, Style>>)_AllStyles).Contains(item);
  }

  public void CopyTo(KeyValuePair<string, Style>[] array, int arrayIndex)
  {
    ((ICollection<KeyValuePair<string, Style>>)_AllStyles).CopyTo(array, arrayIndex);
  }

  public bool Remove(KeyValuePair<string, Style> item)
  {
    return ((ICollection<KeyValuePair<string, Style>>)_AllStyles).Remove(item);
  }

  IEnumerator<KeyValuePair<string, Style>> IEnumerable<KeyValuePair<string, Style>>.GetEnumerator()
  {
    return ((IEnumerable<KeyValuePair<string, Style>>)_AllStyles).GetEnumerator();
  }

  private void _StyleIdsAdd(string id, Style value)
  {
    if (_StyleIds.ContainsKey(id))
      _StyleIds[id] = value;
    else
      _StyleIds.Add(id, value);
  }

  private void Styles_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    switch (args.Action)
    {
      case NotifyCollectionChangedAction.Reset:
        foreach (var item in _AllStyles)
        {
          var style = item;
          style.PropertyChanging -= Item_PropertyChanging;
          style.PropertyChanged -= Item_PropertyChanged;
        }
        _AllStyles.Clear();
        break;
      case NotifyCollectionChangedAction.Add:
        if (args.NewItems != null)
          foreach (var newStyle in args.NewItems.Cast<Style>())
          {
            if (sender == _Items)
              _AllStyles.AddOrReplace(newStyle);
            var id = newStyle.StyleId;
            if (id != null)
              _StyleIdsAdd(id, newStyle);
            //else if (newStyle.Name != null)
            //  _StyleIdsAdd(Style.CreateStyleId(newStyle.Name), newStyle);
            newStyle.PropertyChanging += Item_PropertyChanging;
            newStyle.PropertyChanged += Item_PropertyChanged;
          }
        break;
      case NotifyCollectionChangedAction.Replace:
        if (args.OldItems != null)
          foreach (var oldStyle in args.OldItems.Cast<Style>())
          {
            var id = oldStyle.StyleId;
            if (id != null)
              _StyleIds.Remove(id);
            oldStyle.PropertyChanging -= Item_PropertyChanging;
            oldStyle.PropertyChanged -= Item_PropertyChanged;
          }
        if (args.NewItems != null)
          foreach (var newStyle in args.NewItems.Cast<Style>())
          {
            var id = newStyle.StyleId;
            if (id != null)
              _StyleIdsAdd(id, newStyle);
            //else if (newStyle.Name != null)
            //  _StyleIdsAdd(Style.CreateStyleId(newStyle.Name), newStyle);
            newStyle.PropertyChanging += Item_PropertyChanging;
            newStyle.PropertyChanged += Item_PropertyChanged;
          }
        break;
      case NotifyCollectionChangedAction.Remove:
        if (args.OldItems != null)
          foreach (var oldStyle in args.OldItems.Cast<Style>())
          {
            var id = oldStyle.StyleId;
            if (id != null)
              _StyleIds.Remove(id);
            oldStyle.PropertyChanging -= Item_PropertyChanging;
            oldStyle.PropertyChanged -= Item_PropertyChanged;
          }
        break;
    }
  }

  private void Item_PropertyChanging(object? sender, PropertyChangingEventArgs args)
  {
    //if (sender is Style aStyle)
    //  if (args.PropertyName == nameof(Style.StyleId))
    //  {
    //    var styleName = aStyle.Name;
    //    if (styleName != null)
    //      _StyleList.Remove(styleName);
    //  }
  }

  private void Item_PropertyChanged(object? sender, PropertyChangedEventArgs args)
  {
    //if (sender is Style aStyle)
    //  if (args.PropertyName == nameof(Style.Name))
    //  {
    //    var styleName = aStyle.Name;
    //    if (styleName != null)
    //      _StyleList.Add(styleName, aStyle);
    //  }
  }

  public static List<(string name, StyleKind kind, string? alias)> BuiltInStyleStubs = new()
  {
    ( "Normal", StyleKind.Paragraph, null ),
    ( "Heading 1", StyleKind.Paragraph, null ),
    ( "Heading 2", StyleKind.Paragraph, null ),
    ( "Heading 3", StyleKind.Paragraph, null ),
    ( "Heading 4", StyleKind.Paragraph, null ),
    ( "Heading 5", StyleKind.Paragraph, null ),
    ( "Heading 6", StyleKind.Paragraph, null ),
    ( "Heading 7", StyleKind.Paragraph, null ),
    ( "Heading 8", StyleKind.Paragraph, null ),
    ( "Heading 9", StyleKind.Paragraph, null ),
    ( "Index 1", StyleKind.Paragraph, null ),
    ( "Index 2", StyleKind.Paragraph, null ),
    ( "Index 3", StyleKind.Paragraph, null ),
    ( "Index 4", StyleKind.Paragraph, null ),
    ( "Index 5", StyleKind.Paragraph, null ),
    ( "Index 6", StyleKind.Paragraph, null ),
    ( "Index 7", StyleKind.Paragraph, null ),
    ( "Index 8", StyleKind.Paragraph, null ),
    ( "Index 9", StyleKind.Paragraph, null ),
    ( "TOC 1", StyleKind.Paragraph, null ),
    ( "TOC 2", StyleKind.Paragraph, null ),
    ( "TOC 3", StyleKind.Paragraph, null ),
    ( "TOC 4", StyleKind.Paragraph, null ),
    ( "TOC 5", StyleKind.Paragraph, null ),
    ( "TOC 6", StyleKind.Paragraph, null ),
    ( "TOC 7", StyleKind.Paragraph, null ),
    ( "TOC 8", StyleKind.Paragraph, null ),
    ( "TOC 9", StyleKind.Paragraph, null ),
    ( "Normal Indent", StyleKind.Paragraph, null ),
    ( "Footnote Text", StyleKind.Paragraph, null ),
    ( "Comment Text", StyleKind.Paragraph, null ),
    ( "Header", StyleKind.Paragraph, null ),
    ( "Footer", StyleKind.Paragraph, null ),
    ( "Index Heading", StyleKind.Paragraph, null ),
    ( "Caption", StyleKind.Paragraph, null ),
    ( "Table of Figures", StyleKind.Paragraph, null ),
    ( "Envelope Address", StyleKind.Paragraph, null ),
    ( "Envelope Return", StyleKind.Paragraph, null ),
    ( "Footnote Reference", StyleKind.Character, null ),
    ( "Comment Reference", StyleKind.Character, null ),
    ( "Line Number", StyleKind.Character, null ),
    ( "Page Number", StyleKind.Character, null ),
    ( "Endnote Reference", StyleKind.Character, null ),
    ( "Endnote Text", StyleKind.Paragraph, null ),
    ( "Table of Authorities", StyleKind.Paragraph, null ),
    ( "Macro Text", StyleKind.Paragraph, null ),
    ( "TOA Heading", StyleKind.Paragraph, null ),
    ( "List", StyleKind.Paragraph, null ),
    ( "List Bullet", StyleKind.Paragraph, null ),
    ( "List Number", StyleKind.Paragraph, null ),
    ( "List 2", StyleKind.Paragraph, null ),
    ( "List 3", StyleKind.Paragraph, null ),
    ( "List 4", StyleKind.Paragraph, null ),
    ( "List 5", StyleKind.Paragraph, null ),
    ( "List Bullet 2", StyleKind.Paragraph, null ),
    ( "List Bullet 3", StyleKind.Paragraph, null ),
    ( "List Bullet 4", StyleKind.Paragraph, null ),
    ( "List Bullet 5", StyleKind.Paragraph, null ),
    ( "List Number 2", StyleKind.Paragraph, null ),
    ( "List Number 3", StyleKind.Paragraph, null ),
    ( "List Number 4", StyleKind.Paragraph, null ),
    ( "List Number 5", StyleKind.Paragraph, null ),
    ( "Title", StyleKind.Paragraph, null ),
    ( "Closing", StyleKind.Paragraph, null ),
    ( "Signature", StyleKind.Paragraph, null ),
    ( "Default Paragraph Font", StyleKind.Character, null ),
    ( "Body Text", StyleKind.Paragraph, null ),
    ( "Body Text Indent", StyleKind.Paragraph, null ),
    ( "List Continue", StyleKind.Paragraph, null ),
    ( "List Continue 2", StyleKind.Paragraph, null ),
    ( "List Continue 3", StyleKind.Paragraph, null ),
    ( "List Continue 4", StyleKind.Paragraph, null ),
    ( "List Continue 5", StyleKind.Paragraph, null ),
    ( "Message Header", StyleKind.Paragraph, null ),
    ( "Subtitle", StyleKind.Paragraph, null ),
    ( "Salutation", StyleKind.Paragraph, null ),
    ( "Date", StyleKind.Paragraph, null ),
    ( "Body Text First Indent", StyleKind.Paragraph, null ),
    ( "Body Text First Indent 2", StyleKind.Paragraph, null ),
    ( "Note Heading", StyleKind.Paragraph, null ),
    ( "Body Text 2", StyleKind.Paragraph, null ),
    ( "Body Text 3", StyleKind.Paragraph, null ),
    ( "Body Text Indent 2", StyleKind.Paragraph, null ),
    ( "Body Text Indent 3", StyleKind.Paragraph, null ),
    ( "Block Text", StyleKind.Paragraph, null ),
    ( "Hyperlink", StyleKind.Character, null ),
    ( "FollowedHyperlink", StyleKind.Character, null ),
    ( "Strong", StyleKind.Character, null ),
    ( "Emphasis", StyleKind.Character, null ),
    ( "Document Map", StyleKind.Paragraph, "Nav Pane" ),
    ( "Plain Text", StyleKind.Paragraph, null ),
    ( "E-mail Signature", StyleKind.Paragraph, null ),
    ( "z-Top of Form", StyleKind.Paragraph, null ),
    ( "z-Bottom of Form", StyleKind.Paragraph, null ),
    ( "Html Normal", StyleKind.Paragraph, "Normal (Web)" ),
    ( "HTML Acronym", StyleKind.Character, null ),
    ( "HTML Address", StyleKind.Paragraph, null ),
    ( "HTML Cite", StyleKind.Character, null ),
    ( "HTML Code", StyleKind.Character, null ),
    ( "HTML Definition", StyleKind.Character, null ),
    ( "HTML Keyboard", StyleKind.Character, null ),
    ( "HTML Preformatted", StyleKind.Paragraph, null ),
    ( "HTML Sample", StyleKind.Character, null ),
    ( "HTML Typewriter", StyleKind.Character, null ),
    ( "HTML Variable", StyleKind.Character, null ),
    ( "Table Normal", StyleKind.Table, "Normal Table" ),
    ( "Comment Subject", StyleKind.Paragraph, null ),
    ( "No List", StyleKind.Numbering, null ),
    ( "Outline List 2", StyleKind.Numbering, null ),
    ( "Outline List 1", StyleKind.Numbering, null ),
    ( "Outline List 3", StyleKind.Numbering, null ),
    ( "Table Simple 1", StyleKind.Table, null ),
    ( "Table Simple 2", StyleKind.Table, null ),
    ( "Table Simple 3", StyleKind.Table, null ),
    ( "Table Classic 1", StyleKind.Table, null ),
    ( "Table Classic 2", StyleKind.Table, null ),
    ( "Table Classic 3", StyleKind.Table, null ),
    ( "Table Classic 4", StyleKind.Table, null ),
    ( "Table Colorful 1", StyleKind.Table, null ),
    ( "Table Colorful 2", StyleKind.Table, null ),
    ( "Table Colorful 3", StyleKind.Table, null ),
    ( "Table Columns 1", StyleKind.Table, null ),
    ( "Table Columns 2", StyleKind.Table, null ),
    ( "Table Columns 3", StyleKind.Table, null ),
    ( "Table Columns 4", StyleKind.Table, null ),
    ( "Table Columns 5", StyleKind.Table, null ),
    ( "Table Grid 1", StyleKind.Table, null ),
    ( "Table Grid 2", StyleKind.Table, null ),
    ( "Table Grid 3", StyleKind.Table, null ),
    ( "Table Grid 4", StyleKind.Table, null ),
    ( "Table Grid 5", StyleKind.Table, null ),
    ( "Table Grid 6", StyleKind.Table, null ),
    ( "Table Grid 7", StyleKind.Table, null ),
    ( "Table Grid 8", StyleKind.Table, null ),
    ( "Table List 1", StyleKind.Table, null ),
    ( "Table List 2", StyleKind.Table, null ),
    ( "Table List 3", StyleKind.Table, null ),
    ( "Table List 4", StyleKind.Table, null ),
    ( "Table List 5", StyleKind.Table, null ),
    ( "Table List 6", StyleKind.Table, null ),
    ( "Table List 7", StyleKind.Table, null ),
    ( "Table List 8", StyleKind.Table, null ),
    ( "Table 3D effects 1", StyleKind.Table, null ),
    ( "Table 3D effects 2", StyleKind.Table, null ),
    ( "Table 3D effects 3", StyleKind.Table, null ),
    ( "Table Contemporary", StyleKind.Table, null ),
    ( "Table Elegant", StyleKind.Table, null ),
    ( "Table Professional", StyleKind.Table, null ),
    ( "Table Subtle 1", StyleKind.Table, null ),
    ( "Table Subtle 2", StyleKind.Table, null ),
    ( "Table Web 1", StyleKind.Table, null ),
    ( "Table Web 2", StyleKind.Table, null ),
    ( "Table Web 3", StyleKind.Table, null ),
    ( "Balloon Text", StyleKind.Paragraph, null ),
    ( "Table Grid", StyleKind.Table, null ),
    ( "Table Theme", StyleKind.Table, null ),
    ( "Placeholder Text", StyleKind.Character, null ),
    ( "No Spacing", StyleKind.Paragraph, null ),
    ( "Light Shading", StyleKind.Table, null ),
    ( "Light List", StyleKind.Table, null ),
    ( "Light Grid", StyleKind.Table, null ),
    ( "Medium Shading 1", StyleKind.Table, null ),
    ( "Medium Shading 2", StyleKind.Table, null ),
    ( "Medium List 1", StyleKind.Table, null ),
    ( "Medium List 2", StyleKind.Table, null ),
    ( "Medium Grid 1", StyleKind.Table, null ),
    ( "Medium Grid 2", StyleKind.Table, null ),
    ( "Medium Grid 3", StyleKind.Table, null ),
    ( "Dark List", StyleKind.Table, null ),
    ( "Colorful Shading", StyleKind.Table, null ),
    ( "Colorful List", StyleKind.Table, null ),
    ( "Colorful Grid", StyleKind.Table, null ),
    ( "Light Shading - Accent 1", StyleKind.Table, null ),
    ( "Light List - Accent 1", StyleKind.Table, null ),
    ( "Light Grid - Accent 1", StyleKind.Table, null ),
    ( "Medium Shading 1 - Accent 1", StyleKind.Table, null ),
    ( "Medium Shading 2 - Accent 1", StyleKind.Table, null ),
    ( "Medium List 1 - Accent 1", StyleKind.Table, null ),
    ( "Revision", StyleKind.Paragraph, null ),
    ( "List Paragraph", StyleKind.Paragraph, null ),
    ( "Quote", StyleKind.Paragraph, null ),
    ( "Intense Quote", StyleKind.Paragraph, null ),
    ( "Medium List 2 - Accent 1", StyleKind.Table, null ),
    ( "Medium Grid 1 - Accent 1", StyleKind.Table, null ),
    ( "Medium Grid 2 - Accent 1", StyleKind.Table, null ),
    ( "Medium Grid 3 - Accent 1", StyleKind.Table, null ),
    ( "Dark List - Accent 1", StyleKind.Table, null ),
    ( "Colorful Shading - Accent 1", StyleKind.Table, null ),
    ( "Colorful List - Accent 1", StyleKind.Table, null ),
    ( "Colorful Grid - Accent 1", StyleKind.Table, null ),
    ( "Light Shading - Accent 2", StyleKind.Table, null ),
    ( "Light List - Accent 2", StyleKind.Table, null ),
    ( "Light Grid - Accent 2", StyleKind.Table, null ),
    ( "Medium Shading 1 - Accent 2", StyleKind.Table, null ),
    ( "Medium Shading 2 - Accent 2", StyleKind.Table, null ),
    ( "Medium List 1 - Accent 2", StyleKind.Table, null ),
    ( "Medium List 2 - Accent 2", StyleKind.Table, null ),
    ( "Medium Grid 1 - Accent 2", StyleKind.Table, null ),
    ( "Medium Grid 2 - Accent 2", StyleKind.Table, null ),
    ( "Medium Grid 3 - Accent 2", StyleKind.Table, null ),
    ( "Dark List - Accent 2", StyleKind.Table, null ),
    ( "Colorful Shading - Accent 2", StyleKind.Table, null ),
    ( "Colorful List - Accent 2", StyleKind.Table, null ),
    ( "Colorful Grid - Accent 2", StyleKind.Table, null ),
    ( "Light Shading - Accent 3", StyleKind.Table, null ),
    ( "Light List - Accent 3", StyleKind.Table, null ),
    ( "Light Grid - Accent 3", StyleKind.Table, null ),
    ( "Medium Shading 1 - Accent 3", StyleKind.Table, null ),
    ( "Medium Shading 2 - Accent 3", StyleKind.Table, null ),
    ( "Medium List 1 - Accent 3", StyleKind.Table, null ),
    ( "Medium List 2 - Accent 3", StyleKind.Table, null ),
    ( "Medium Grid 1 - Accent 3", StyleKind.Table, null ),
    ( "Medium Grid 2 - Accent 3", StyleKind.Table, null ),
    ( "Medium Grid 3 - Accent 3", StyleKind.Table, null ),
    ( "Dark List - Accent 3", StyleKind.Table, null ),
    ( "Colorful Shading - Accent 3", StyleKind.Table, null ),
    ( "Colorful List - Accent 3", StyleKind.Table, null ),
    ( "Colorful Grid - Accent 3", StyleKind.Table, null ),
    ( "Light Shading - Accent 4", StyleKind.Table, null ),
    ( "Light List - Accent 4", StyleKind.Table, null ),
    ( "Light Grid - Accent 4", StyleKind.Table, null ),
    ( "Medium Shading 1 - Accent 4", StyleKind.Table, null ),
    ( "Medium Shading 2 - Accent 4", StyleKind.Table, null ),
    ( "Medium List 1 - Accent 4", StyleKind.Table, null ),
    ( "Medium List 2 - Accent 4", StyleKind.Table, null ),
    ( "Medium Grid 1 - Accent 4", StyleKind.Table, null ),
    ( "Medium Grid 2 - Accent 4", StyleKind.Table, null ),
    ( "Medium Grid 3 - Accent 4", StyleKind.Table, null ),
    ( "Dark List - Accent 4", StyleKind.Table, null ),
    ( "Colorful Shading - Accent 4", StyleKind.Table, null ),
    ( "Colorful List - Accent 4", StyleKind.Table, null ),
    ( "Colorful Grid - Accent 4", StyleKind.Table, null ),
    ( "Light Shading - Accent 5", StyleKind.Table, null ),
    ( "Light List - Accent 5", StyleKind.Table, null ),
    ( "Light Grid - Accent 5", StyleKind.Table, null ),
    ( "Medium Shading 1 - Accent 5", StyleKind.Table, null ),
    ( "Medium Shading 2 - Accent 5", StyleKind.Table, null ),
    ( "Medium List 1 - Accent 5", StyleKind.Table, null ),
    ( "Medium List 2 - Accent 5", StyleKind.Table, null ),
    ( "Medium Grid 1 - Accent 5", StyleKind.Table, null ),
    ( "Medium Grid 2 - Accent 5", StyleKind.Table, null ),
    ( "Medium Grid 3 - Accent 5", StyleKind.Table, null ),
    ( "Dark List - Accent 5", StyleKind.Table, null ),
    ( "Colorful Shading - Accent 5", StyleKind.Table, null ),
    ( "Colorful List - Accent 5", StyleKind.Table, null ),
    ( "Colorful Grid - Accent 5", StyleKind.Table, null ),
    ( "Light Shading - Accent 6", StyleKind.Table, null ),
    ( "Light List - Accent 6", StyleKind.Table, null ),
    ( "Light Grid - Accent 6", StyleKind.Table, null ),
    ( "Medium Shading 1 - Accent 6", StyleKind.Table, null ),
    ( "Medium Shading 2 - Accent 6", StyleKind.Table, null ),
    ( "Medium List 1 - Accent 6", StyleKind.Table, null ),
    ( "Medium List 2 - Accent 6", StyleKind.Table, null ),
    ( "Medium Grid 1 - Accent 6", StyleKind.Table, null ),
    ( "Medium Grid 2 - Accent 6", StyleKind.Table, null ),
    ( "Medium Grid 3 - Accent 6", StyleKind.Table, null ),
    ( "Dark List - Accent 6", StyleKind.Table, null ),
    ( "Colorful Shading - Accent 6", StyleKind.Table, null ),
    ( "Colorful List - Accent 6", StyleKind.Table, null ),
    ( "Colorful Grid - Accent 6", StyleKind.Table, null ),
    ( "Subtle Emphasis", StyleKind.Character, null ),
    ( "Intense Emphasis", StyleKind.Character, null ),
    ( "Subtle Reference", StyleKind.Character, null ),
    ( "Intense Reference", StyleKind.Character, null ),
    ( "Book Title", StyleKind.Character, null ),
    ( "Bibliography", StyleKind.Paragraph, null ),
    ( "TOC Heading", StyleKind.Paragraph, null ),
    ( "Plain Table 1", StyleKind.Table, null ),
    ( "Plain Table 2", StyleKind.Table, null ),
    ( "Plain Table 3", StyleKind.Table, null ),
    ( "Plain Table 4", StyleKind.Table, null ),
    ( "Plain Table 5", StyleKind.Table, null ),
    ( "Table Grid Light", StyleKind.Table, "Grid Table Light" ),
    ( "Grid Table 1 Light", StyleKind.Table, null ),
    ( "Grid Table 2", StyleKind.Table, null ),
    ( "Grid Table 3", StyleKind.Table, null ),
    ( "Grid Table 4", StyleKind.Table, null ),
    ( "Grid Table 5 Dark", StyleKind.Table, null ),
    ( "Grid Table 6 Colorful", StyleKind.Table, null ),
    ( "Grid Table 7 Colorful", StyleKind.Table, null ),
    ( "Grid Table 1 Light - Accent 1", StyleKind.Table, null ),
    ( "Grid Table 2 - Accent 1", StyleKind.Table, null ),
    ( "Grid Table 3 - Accent 1", StyleKind.Table, null ),
    ( "Grid Table 4 - Accent 1", StyleKind.Table, null ),
    ( "Grid Table 5 Dark - Accent 1", StyleKind.Table, null ),
    ( "Grid Table 6 Colorful - Accent 1", StyleKind.Table, null ),
    ( "Grid Table 7 Colorful - Accent 1", StyleKind.Table, null ),
    ( "Grid Table 1 Light - Accent 2", StyleKind.Table, null ),
    ( "Grid Table 2 - Accent 2", StyleKind.Table, null ),
    ( "Grid Table 3 - Accent 2", StyleKind.Table, null ),
    ( "Grid Table 4 - Accent 2", StyleKind.Table, null ),
    ( "Grid Table 5 Dark - Accent 2", StyleKind.Table, null ),
    ( "Grid Table 6 Colorful - Accent 2", StyleKind.Table, null ),
    ( "Grid Table 7 Colorful - Accent 2", StyleKind.Table, null ),
    ( "Grid Table 1 Light - Accent 3", StyleKind.Table, null ),
    ( "Grid Table 2 - Accent 3", StyleKind.Table, null ),
    ( "Grid Table 3 - Accent 3", StyleKind.Table, null ),
    ( "Grid Table 4 - Accent 3", StyleKind.Table, null ),
    ( "Grid Table 5 Dark - Accent 3", StyleKind.Table, null ),
    ( "Grid Table 6 Colorful - Accent 3", StyleKind.Table, null ),
    ( "Grid Table 7 Colorful - Accent 3", StyleKind.Table, null ),
    ( "Grid Table 1 Light - Accent 4", StyleKind.Table, null ),
    ( "Grid Table 2 - Accent 4", StyleKind.Table, null ),
    ( "Grid Table 3 - Accent 4", StyleKind.Table, null ),
    ( "Grid Table 4 - Accent 4", StyleKind.Table, null ),
    ( "Grid Table 5 Dark - Accent 4", StyleKind.Table, null ),
    ( "Grid Table 6 Colorful - Accent 4", StyleKind.Table, null ),
    ( "Grid Table 7 Colorful - Accent 4", StyleKind.Table, null ),
    ( "Grid Table 1 Light - Accent 5", StyleKind.Table, null ),
    ( "Grid Table 2 - Accent 5", StyleKind.Table, null ),
    ( "Grid Table 3 - Accent 5", StyleKind.Table, null ),
    ( "Grid Table 4 - Accent 5", StyleKind.Table, null ),
    ( "Grid Table 5 Dark - Accent 5", StyleKind.Table, null ),
    ( "Grid Table 6 Colorful - Accent 5", StyleKind.Table, null ),
    ( "Grid Table 7 Colorful - Accent 5", StyleKind.Table, null ),
    ( "Grid Table 1 Light - Accent 6", StyleKind.Table, null ),
    ( "Grid Table 2 - Accent 6", StyleKind.Table, null ),
    ( "Grid Table 3 - Accent 6", StyleKind.Table, null ),
    ( "Grid Table 4 - Accent 6", StyleKind.Table, null ),
    ( "Grid Table 5 Dark - Accent 6", StyleKind.Table, null ),
    ( "Grid Table 6 Colorful - Accent 6", StyleKind.Table, null ),
    ( "Grid Table 7 Colorful - Accent 6", StyleKind.Table, null ),
    ( "List Table 1 Light", StyleKind.Table, null ),
    ( "List Table 2", StyleKind.Table, null ),
    ( "List Table 3", StyleKind.Table, null ),
    ( "List Table 4", StyleKind.Table, null ),
    ( "List Table 5 Dark", StyleKind.Table, null ),
    ( "List Table 6 Colorful", StyleKind.Table, null ),
    ( "List Table 7 Colorful", StyleKind.Table, null ),
    ( "List Table 1 Light - Accent 1", StyleKind.Table, null ),
    ( "List Table 2 - Accent 1", StyleKind.Table, null ),
    ( "List Table 3 - Accent 1", StyleKind.Table, null ),
    ( "List Table 4 - Accent 1", StyleKind.Table, null ),
    ( "List Table 5 Dark - Accent 1", StyleKind.Table, null ),
    ( "List Table 6 Colorful - Accent 1", StyleKind.Table, null ),
    ( "List Table 7 Colorful - Accent 1", StyleKind.Table, null ),
    ( "List Table 1 Light - Accent 2", StyleKind.Table, null ),
    ( "List Table 2 - Accent 2", StyleKind.Table, null ),
    ( "List Table 3 - Accent 2", StyleKind.Table, null ),
    ( "List Table 4 - Accent 2", StyleKind.Table, null ),
    ( "List Table 5 Dark - Accent 2", StyleKind.Table, null ),
    ( "List Table 6 Colorful - Accent 2", StyleKind.Table, null ),
    ( "List Table 7 Colorful - Accent 2", StyleKind.Table, null ),
    ( "List Table 1 Light - Accent 3", StyleKind.Table, null ),
    ( "List Table 2 - Accent 3", StyleKind.Table, null ),
    ( "List Table 3 - Accent 3", StyleKind.Table, null ),
    ( "List Table 4 - Accent 3", StyleKind.Table, null ),
    ( "List Table 5 Dark - Accent 3", StyleKind.Table, null ),
    ( "List Table 6 Colorful - Accent 3", StyleKind.Table, null ),
    ( "List Table 7 Colorful - Accent 3", StyleKind.Table, null ),
    ( "List Table 1 Light - Accent 4", StyleKind.Table, null ),
    ( "List Table 2 - Accent 4", StyleKind.Table, null ),
    ( "List Table 3 - Accent 4", StyleKind.Table, null ),
    ( "List Table 4 - Accent 4", StyleKind.Table, null ),
    ( "List Table 5 Dark - Accent 4", StyleKind.Table, null ),
    ( "List Table 6 Colorful - Accent 4", StyleKind.Table, null ),
    ( "List Table 7 Colorful - Accent 4", StyleKind.Table, null ),
    ( "List Table 1 Light - Accent 5", StyleKind.Table, null ),
    ( "List Table 2 - Accent 5", StyleKind.Table, null ),
    ( "List Table 3 - Accent 5", StyleKind.Table, null ),
    ( "List Table 4 - Accent 5", StyleKind.Table, null ),
    ( "List Table 5 Dark - Accent 5", StyleKind.Table, null ),
    ( "List Table 6 Colorful - Accent 5", StyleKind.Table, null ),
    ( "List Table 7 Colorful - Accent 5", StyleKind.Table, null ),
    ( "List Table 1 Light - Accent 6", StyleKind.Table, null ),
    ( "List Table 2 - Accent 6", StyleKind.Table, null ),
    ( "List Table 3 - Accent 6", StyleKind.Table, null ),
    ( "List Table 4 - Accent 6", StyleKind.Table, null ),
    ( "List Table 5 Dark - Accent 6", StyleKind.Table, null ),
    ( "List Table 6 Colorful - Accent 6", StyleKind.Table, null ),
    ( "List Table 7 Colorful - Accent 6", StyleKind.Table, null ),
    ( "Mention", StyleKind.Character, null ),
    ( "Smart Hyperlink", StyleKind.Character, null ),
    ( "Hashtag", StyleKind.Character, null ),
    ( "Unresolved Mention", StyleKind.Character, null ),
    ( "Smart Link", StyleKind.Character, "SmartLink" ),
  };
}