using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;



namespace DocumentModel;

/// <summary>Represents the list value attributes (xsd:list).</summary>
[DebuggerDisplay("{InnerText}")]
public class ListOf<T>: IEnumerable<T>, IEnumerable
  where T : IConvertible
{
  private string? TextValue;
  private const string _listSeparator = " ";
  private ObservableCollection<T>? _list;


  /// <summary>
  /// Initializes a new instance of the <see cref="T:DocumentFormat.OpenXml.ListValue`1" /> class using the supplied list of values.
  /// </summary>
  /// <param name="list">The list of the values.</param>
  public ListOf(IEnumerable<T> list)
  {
    _list = new ObservableCollection<T>();
    _list.CollectionChanged += new NotifyCollectionChangedEventHandler(CollectionChanged);
    foreach (T obj in list)
      _list.Add(obj);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="T:DocumentFormat.OpenXml.ListValue`1" /> class by deep copying the supplied <see cref="T:DocumentFormat.OpenXml.ListValue`1" /> class.
  /// </summary>
  /// <param name="list">The source <see cref="T:DocumentFormat.OpenXml.ListValue`1" /> class.</param>
  public ListOf(ListOf<T> list)
    : this(list.Items)
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="T:DocumentFormat.OpenXml.ListValue`1" /> class by deep copying the supplied <see cref="T:DocumentFormat.OpenXml.ListValue`1" /> class.
  /// </summary>
  /// <param name="list">The source <see cref="T:DocumentFormat.OpenXml.ListValue`1" /> class.</param>
  public ListOf(string? str)
  {
    TextValue = str;
  }

  /// <summary>Gets the values.</summary>
  public ICollection<T> Items
  {
    get
    {
      if (_list == null)
      {
        if (!string.IsNullOrEmpty(TextValue))
        {
          Parse();
          if (_list==null)
            _list = new ObservableCollection<T>();
        }
        else
        {
          _list = new ObservableCollection<T>();
          _list.CollectionChanged += new NotifyCollectionChangedEventHandler(CollectionChanged);
        }
      }
      return _list;
    }
  }

  /// <summary>Convert the text to meaningful value.</summary>
  private void Parse()
  {
    _list = new ObservableCollection<T>();
    _list.CollectionChanged += new NotifyCollectionChangedEventHandler(CollectionChanged);
    if (TextValue==null || TextValue.Length==0)
      return;
    foreach (string str in TextValue.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries))
    {
      var obj = (T)Convert.ChangeType(str, typeof(T));
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
    ObservableCollection<T> observableCollection = new ObservableCollection<T>();
    foreach (string str in strArray)
    {
      var obj2 = (T)Convert.ChangeType(str, typeof(T));
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
        foreach (T obj in (Collection<T>)_list)
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
  public IEnumerator<T> GetEnumerator() => Items.GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator() => (IEnumerator)GetEnumerator();
}

