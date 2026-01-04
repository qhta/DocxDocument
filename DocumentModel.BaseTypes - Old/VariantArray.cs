using System.Collections;

namespace DocumentModel;

/// <summary>
/// Variant implementation. Value is of any type.

/// </summary>
public class VariantArray : Variant, IEnumerable
{
  internal new static Dictionary<VariantType, Type> ItemTypes = new()
  {
    { VariantType.Variant, typeof(Variant) },
    { VariantType.SByte, typeof(SByte) },
    { VariantType.Int16, typeof(Int16) },
    { VariantType.Int32, typeof(Int32) },
    { VariantType.Integer, typeof(Decimal) },
    { VariantType.Byte, typeof(Byte) },
    { VariantType.UInt16, typeof(UInt16) },
    { VariantType.UInt32, typeof(UInt32) },
    { VariantType.UnsignedInteger, typeof(Decimal) },
    { VariantType.Single, typeof(Single) },
    { VariantType.Double, typeof(Double) },
    { VariantType.Decimal, typeof(Decimal) },
    { VariantType.Bstr, typeof(String) },
    { VariantType.Date, typeof(DateTime) },
    { VariantType.Boolean, typeof(Boolean) },
    { VariantType.Currency, typeof(Decimal) },
    { VariantType.HexInt, typeof(HexInt) },
  };

  private VariantType _baseType;
  private int _lowerBounds;
  private int _upperBounds;
  private Array? _items;
  private Type _itemType = typeof(object);

  public VariantArray()
  {
  }

  public VariantArray(VariantType baseType, int lowerBounds, int upperBounds)
  {
    Resize(lowerBounds, upperBounds, baseType);
  }

  /// <summary>
  /// Array Base Type
  /// </summary>
  public VariantType BaseType
  {
    get => _baseType;
    set
    {
      if (_baseType != value)
        Resize(_lowerBounds, _upperBounds, value);
    }
  }

  /// <summary>
  /// Returns an item type that was set by BaseType
  /// </summary>
  public Type ItemType => _itemType;

  /// <summary>
  /// <para>Array Lower Bounds Attribute</para>
  /// </summary>
  public int LowerBounds
  {
    get => _lowerBounds;
    set => _lowerBounds = value;
  }

  /// <summary>
  /// <para>Array Upper Bounds Attribute</para>
  /// </summary>
  public int UpperBounds
  {
    get => _upperBounds;
    set => _upperBounds = value;
  }

  /// <summary>
  /// Returns current items count.
  /// </summary>
  public int Size => _upperBounds - _lowerBounds + 1;

  /// <summary>
  /// Resizes array with the same item type
  /// </summary>
  /// <param name="lowerBounds">New lower bounds index</param>
  /// <param name="upperBounds">New upper bounds index</param>
  public void Resize(int lowerBounds, int upperBounds) => Resize(lowerBounds, upperBounds, BaseType);

  /// <summary>
  /// Resizes array with the new item type
  /// </summary>
  /// <param name="lowerBounds">New lower bounds index</param>
  /// <param name="upperBounds">New upper bounds index</param>
  /// <param name="baseType">New variant base type</param>
  public void Resize(int lowerBounds, int upperBounds, VariantType baseType)
  {
    if (lowerBounds != _lowerBounds || upperBounds != _upperBounds || baseType != _baseType)
    {
      var newSize = upperBounds - lowerBounds + 1;
      var newItemType = ItemTypes[baseType];
      var newItems = Array.CreateInstance(newItemType, newSize);
      if (_items != null)
      {
        if (newItemType == _itemType && newSize>=Size)
          _items.CopyTo(newItems, 0);
        else
        {
          for (int i = 0; i < Size && i < newSize; i++)
            newItems.SetValue(Convert.ChangeType(_items.GetValue(i), newItemType), i);
        }
      }
      _items = newItems;
      _lowerBounds = lowerBounds;
      _upperBounds = upperBounds;
      _baseType = baseType;
      _itemType = newItemType;
    }
  }

  public object? this[int index]
  {
    get => _items?.GetValue(index-_lowerBounds);
    set => _items?.SetValue(Convert.ChangeType(value, _itemType), index - _lowerBounds);
  }

  public IEnumerator GetEnumerator()
  {
    return _items?.GetEnumerator() ?? throw new InvalidOperationException($"ArrayVariant not initialized");
  }

}
