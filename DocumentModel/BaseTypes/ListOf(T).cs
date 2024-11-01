﻿namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>Represents the list value attributes (xsd:list).</summary>
[DebuggerDisplay("{InnerText}")]
public class ListOf<T> : ICollection<T>, IEquatable<ListOf<T>>
  where T : IConvertible
{
  private char[] _listSeparators = new char[] {' '};
  private ObservableCollection<T> _list = null!;
  private string? TextValue;

  /// <summary>
  ///   Initializes a new instance of the <see cref="T:DocumentFormat.OpenXml.ListValue`1" /> class.
  /// </summary>
  public ListOf()
  {
    if (typeof(T)==typeof(string))
      _listSeparators = new char [] { ',', ';' };
    _list = new ObservableCollection<T>();
    _list.CollectionChanged += CollectionChanged;
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="T:DocumentFormat.OpenXml.ListValue`1" /> class using the supplied list
  ///   of values.
  /// </summary>
  /// <param name="list">The list of the values.</param>
  public ListOf(IEnumerable<T> list) : this()
  {
    foreach (var obj in list)
      _list.Add(obj);
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="T:DocumentFormat.OpenXml.ListValue`1" /> class by deep copying the
  ///   supplied <see cref="T:DocumentFormat.OpenXml.ListValue`1" /> class.
  /// </summary>
  /// <param name="list">The source <see cref="T:DocumentFormat.OpenXml.ListValue`1" /> class.</param>
  public ListOf(ListOf<T> list): this()
  {
    foreach (var obj in list)
      _list.Add(obj);
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="T:DocumentFormat.OpenXml.ListValue`1" /> class 
  ///   by separating str with comma or semicolon.
  /// </summary>
  public ListOf(string str)
  {
    if (typeof(T) == typeof(string))
      _listSeparators = new char[] { ',', ';' };
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
          if (_list == null)
            _list = new ObservableCollection<T>();
        }
        else
        {
          _list = new ObservableCollection<T>();
          _list.CollectionChanged += CollectionChanged;
        }
      }
      return _list;
    }
  }

  /// <summary>Gets or sets the inner XML text.</summary>
  public string? InnerText
  {
    get
    {
      if (TextValue == null && _list != null)
      {
        var stringBuilder = new StringBuilder();
        var str = string.Empty;
        foreach (var obj in _list)
          if (obj != null)
          {
            stringBuilder.Append(str);
            stringBuilder.Append(obj);
            str = " ";
          }
        TextValue = stringBuilder.ToString();
      }
      return TextValue;
    }
    set
    {
      TextValue = value;
      Parse();
    }
  }

  /// <inheritdoc />
  public IEnumerator<T> GetEnumerator()
  {
    return Items.GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }

  public void Add(T item)
  {
    _list.Add(item);
  }

  public void Clear()
  {
    _list.Clear();
  }

  public bool Contains(T item)
  {
    return _list.Contains(item);
  }

  public void CopyTo(T[] array, int arrayIndex)
  {
    _list.CopyTo(array, arrayIndex);
  }

  public bool Remove(T item)
  {
    return _list.Remove(item);
  }

  public int Count => _list.Count;

  public bool IsReadOnly => false;

  /// <summary>Convert the text to meaningful value.</summary>
  private void Parse()
  {
    _list = new ObservableCollection<T>();
    _list.CollectionChanged += CollectionChanged;
    if (TextValue == null || TextValue.Length == 0)
      return;
    foreach (var str in TextValue.Split(_listSeparators, StringSplitOptions.RemoveEmptyEntries))
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
    var strArray = TextValue.Split(_listSeparators, StringSplitOptions.RemoveEmptyEntries);
    var observableCollection = new ObservableCollection<T>();
    foreach (var str in strArray)
    {
      var obj2 = (T)Convert.ChangeType(str, typeof(T));
      observableCollection.Add(obj2);
    }
    _list = observableCollection;
    _list.CollectionChanged += CollectionChanged;
    return true;
  }

  private void CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
  {
    TextValue = null;
  }

  public static implicit operator ListOf<T>?(string? value)
  {
    if (value != null)
      return new ListOf<T>(value);
    return null;
  }

  public static implicit operator string?(ListOf<T>? value)
  {
    return value?.ToString();
  }

  public bool Equals(ListOf<T>? other)
  {
    if (other == null)
      return false;
    return Enumerable.SequenceEqual<T>(this._list, other._list);
  }

  public override int GetHashCode()
  {
    var result = _list.Count();
    foreach (var item in _list)
      result = HashCode.Combine(result, item.GetHashCode());
    return result;
  }
}