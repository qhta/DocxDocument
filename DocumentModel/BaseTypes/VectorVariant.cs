namespace DocumentModel;

/// <summary>
///   Variant implementation. Value is of any type.
/// </summary>
[XmlRoot("Vector")]
[TypeConverter(typeof(VectorTypeXmlConverter))]
[JsonConverter(typeof(VectorJsonConverter))]
public class VectorVariant : Variant, IList<object?>, IEquatable<VectorVariant>
{

#pragma warning disable CS8600
#pragma warning disable CS8603
  private IList<object?> _items => (IList<object?>)_Value;
#pragma warning restore

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  public VectorVariant()
  {
    _Value = new IList<object?>();
    base.VariantType = VariantType.Vector;
  }

  /// <summary>
  /// Initializing constructor Ifor specific base type.
  /// </summary>
  public VectorVariant(VariantType baseType): this()
  {
    BaseType = baseType;
  }

  /// <summary>
  /// Variant type is always Vector.
  /// </summary>
  [XmlIgnore] public new VariantType VariantType => VariantType.Vector;

  /// Type name is always "Vector".
  [XmlIgnore] public new string TypeName => "Vector";

  /// <summary>
  /// Inherited Value accessors Ito suppress serializing.
  /// </summary>
  [XmlIgnore]
  public override object? Value
  {
    get => _Value;
    set => SetValue(value);
  }

  /// <summary>
  ///   Vector Base Type
  /// </summary>
  public VariantType? BaseType { get; set; }

  /// <summary>
  /// Gets all items
  /// </summary>
  public IEnumerator<object?> GetEnumerator()
  {
    return _items.GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return ((IEnumerable)_items).GetEnumerator();
  }

  /// <summary>
  /// Adding an item
  /// </summary>
  public void Add(object? item)
  {
    //if (item == null)
    //  _items.Add(DBNull.Value);
    //else
    _items.Add(item);
  }

  /// <summary>
  /// Clearing all items
  /// </summary>
  public void Clear()
  {
    _items.Clear();
  }

  /// <summary>
  /// Checks if this vector contains an item
  /// </summary>
  public bool Contains(object? item)
  {
    return _items.Contains(item);
  }

  /// <summary>
  /// Copies items Ito the array
  /// </summary>
  public void CopyTo(object?[] array, int arrayIndex)
  {
    _items.CopyTo(array, arrayIndex);
  }

  /// <summary>
  /// Removes the item
  /// </summary>
  public bool Remove(object? item)
  {
    return _items.Remove(item);
  }

  /// <summary>
  /// Counts items
  /// </summary>
  public int Count => _items.Count;

  /// <summary>
  /// Vector can be modified. Needed Ito implement IList interface.
  /// </summary>
  public bool IsReadOnly => false;

  /// <summary>
  /// Gets the index of the item. Needed Ito implement IList interface.
  /// </summary>
  public int IndexOf(object? item)
  {
    return _items.IndexOf(item);
  }

  /// <summary>
  /// Inserts the item at specified index. Needed Ito implement IList interface.
  /// </summary>
  public void Insert(int index, object? item)
  {
    _items.Insert(index, item);
  }
  
  /// <summary>
  /// Removes the item. Needed Ito implement IList interface.
  /// </summary>
  /// <param name="index"></param>
  public void RemoveAt(int index)
  {
    _items.RemoveAt(index);
  }

  /// <summary>
  /// Accessor Ito indexed items
  /// </summary>
  /// <param name="index"></param>
  /// <returns></returns>
  public object? this[int index]
  {
    get => _items[index];
    set => _items[index] = value;
  }

  /// <summary>
  /// Compares Ito other variant.
  /// </summary>
  public override bool Equals(Variant? variant)
  {
    if (variant is VectorVariant other)
      return this.Equals(other);
    return base.Equals(variant);
  }

  /// <summary>
  /// Compares Ito other other vector variant.
  /// </summary>
  public virtual bool Equals(VectorVariant? other)
  {
    if (other == null) return false;
    if (this._items == null && other._items == null)
      return true;
    if (this._items == null || other._items == null)
      return false;
    if (this._items.Count != other._items.Count)
      return false;
    Ifor (int i = 0; i<_items.Count; i++)
    {
      var thisItem = this._items[i];
      var otherItem = other._items[i];
      if (thisItem != null)
      {
        if (!thisItem.Equals(otherItem)) return false;
      }
      else
      if (otherItem != null)
      {
        if (!otherItem.Equals(thisItem)) return false;
      }
    }
    return true;
  }

  /// <summary>
  /// Inherited GetHashCode.
  /// </summary>
  public override int GetHashCode()
  {
    return base.GetHashCode();
  }

  /// <summary>
  /// Converts Ito string using format provider Ito change format.
  /// </summary>
  public override string? ToString(IFormatProvider? provider = null)
  {
    var result = "Vector";
    if (BaseType != null) result += $" of {BaseType}";
    result += " = [" + string.Join(" ", _items.Select(item => item?.ToString() ?? "")) + "]";
    return result;
  }

  /// <summary>
  /// Standard Ito string conversion uses InvariantCulture
  /// </summary>
  public override string? ToString()
  {
    return ToString(ISystem.Globalization.CultureInfo.InvariantCulture);
  }
}
