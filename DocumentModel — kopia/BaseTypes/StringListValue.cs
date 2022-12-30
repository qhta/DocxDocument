using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Text;


#nullable enable
namespace DocumentModel;

/// <summary>Represents the list value attributes (xsd:list).</summary>
[DebuggerDisplay("{InnerText}")]
public class StringListValue: ICollection<string>, IEnumerable
{
  private string? TextValue;
  private const string _listSeparator = " ";
  private ObservableCollection<string>? _list;


  /// <summary>
  /// Initializes a new instance of the <see cref="string:DocumentFormat.OpenXml.ListValue`1" /> class using the supplied list of values.
  /// </summary>
  /// <param name="list">The list of the values.</param>
  public StringListValue(IEnumerable<string> list)
  {
    if (list == null)
      throw new ArgumentNullException(nameof(list));
    _list = new ObservableCollection<string>();
    _list.CollectionChanged += new NotifyCollectionChangedEventHandler(CollectionChanged);
    foreach (string obj in list)
      _list.Add(obj);
  }

  ///// <summary>
  ///// Initializes a new instance of the <see cref="string:DocumentFormat.OpenXml.ListValue`1" /> class by deep copying the supplied <see cref="string:DocumentFormat.OpenXml.ListValue`1" /> class.
  ///// </summary>
  ///// <param name="list">The source <see cref="string:DocumentFormat.OpenXml.ListValue`1" /> class.</param>
  //public StringListValue(ListValue<string> list)
  //  : this(list.Items)
  //{
  //}

  
  /// <summary>Gets the values.</summary>
  public ICollection<string> Items
  {
    get
    {
      if (_list == null)
      {
        if (!string.IsNullOrEmpty(TextValue))
        {
          Parse();
          if (_list==null)
            _list = new ObservableCollection<string>();
        }
        else
        {
          _list = new ObservableCollection<string>();
          _list.CollectionChanged += new NotifyCollectionChangedEventHandler(CollectionChanged);
        }
      }
      return _list;
    }
  }

  /// <summary>Convert the text to meaningful value.</summary>
  private void Parse()
  {
    _list = new ObservableCollection<string>();
    _list.CollectionChanged += new NotifyCollectionChangedEventHandler(CollectionChanged);
    if (TextValue==null || TextValue.Length==0)
      return;
    foreach (string str in TextValue.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries))
    {
      var obj = (string)Convert.ChangeType(str, typeof(string));
      _list.Add(obj);
    }
  }

  /// <summary>Convert the text to meaningful value.</summary>
  /// <returns></returns>
  private bool TryParse()
  {
    if (TextValue == null || TextValue.Length == 0)
      return false;
    string[] strArray = TextValue.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
    ObservableCollection<string> observableCollection = new ObservableCollection<string>();
    foreach (string str in strArray)
    {
      var obj2 = (string)Convert.ChangeType(str, typeof(string));
      observableCollection.Add(obj2);
    }
    _list = observableCollection;
    _list.CollectionChanged += new NotifyCollectionChangedEventHandler(CollectionChanged);
    return true;
  }

  /// <summary>Gets or sets the inner XML text.</summary>
  public string? InnerText
  {
    get
    {
      if (TextValue == null && _list != null)
      {
        StringBuilder stringBuilder = new StringBuilder();
        string str = string.Empty;
        foreach (string obj in (Collection<string>)_list)
        {
          if ((object)obj != null)
          {
            stringBuilder.Append(str);
            stringBuilder.Append(obj.ToString());
            str = " ";
          }
        }
        TextValue = stringBuilder.ToString();
      }
      return TextValue;
    }
    set
    {
      TextValue = value;
      _list = null;
    }
  }

  private void CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e) => TextValue = null;

  /// <inheritdoc />
  public IEnumerator<string> GetEnumerator() => Items.GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator() => (IEnumerator)GetEnumerator();
  public void Add(string item)
  {
    _list?.Add(item);
  }

  public void Clear()
  {
    _list?.Clear();
  }

  public bool Contains(string item)
  {
    return _list?.Contains(item) ?? false;
  }

  public void CopyTo(string[] array, int arrayIndex)
  {
    _list?.CopyTo(array, arrayIndex);
  }

  public bool Remove(string item)
  {
    return _list?.Remove(item) ?? false;
  }

  public int Count => _list?.Count ?? 0;

  public bool IsReadOnly => false;
}

