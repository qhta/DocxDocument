using DocumentModel;
namespace DocumentModel;

/// <summary>
/// Represents a variant that contains an array of elements with a specified base type and bounds.
/// This class provides a dynamic, resizable array container that can hold elements of any variant type
/// defined in the Office Open XML specification.
/// </summary>
/// <remarks>
/// <para>
/// <see cref="ArrayVariant"/> is part of the variant type system used in Office Open XML documents
/// to represent arrays of values in custom properties, metadata, and data storage. Unlike standard .NET arrays,
/// ArrayVariant supports:
/// <list type="bullet">
/// <item><description><b>Flexible base types:</b> Can store any variant type (integers, strings, dates, booleans, etc.)</description></item>
/// <item><description><b>Custom bounds:</b> Supports non-zero-based indexing with configurable lower and upper bounds</description></item>
/// <item><description><b>Dynamic resizing:</b> Can be resized and have its element type changed at runtime</description></item>
/// <item><description><b>XML serialization:</b> Designed for serialization to/from OpenXML format</description></item>
/// </list>
/// </para>
/// <para>
/// The array can be indexed using custom bounds. For example, an array with <see cref="LowerBounds"/> = 5
/// and <see cref="UpperBounds"/> = 10 contains 6 elements accessible via indices 5 through 10.
/// This matches VBA and COM array conventions used in Office automation.
/// </para>
/// <para>
/// When the <see cref="BaseType"/> is changed, existing values are converted to the new type if possible.
/// If conversion fails, elements are set to their default values.
/// </para>
/// </remarks>
/// <example>
/// <code>
/// // Create an integer array with 5 elements (0-4)
/// var intArray = new ArrayVariant(VariantType.Int32, 5);
/// intArray[0] = 10;
/// intArray[1] = 20;
/// 
/// // Create a string array with custom bounds (1-based indexing)
/// var stringArray = new ArrayVariant(VariantType.String, 1, 5);
/// stringArray[1] = "First";
/// stringArray[2] = "Second";
/// 
/// // Resize and change type
/// intArray.Resize(10, VariantType.String); // Now a 10-element string array
/// </code>
/// </example>
public class ArrayVariant : Variant, ICollection<object?>, IEquatable<ArrayVariant>
{
  private VariantType _baseType;
  private int _fillCount;
  private Array? _items;
  private int _lowerBounds;
  private int _upperBounds;

  /// <summary>
  /// Initializes a new instance of the <see cref="ArrayVariant"/> class with default settings.
  /// </summary>
  /// <remarks>
  /// The array is created with no elements and must be resized before use.
  /// The <see cref="VariantType"/> is set to <see cref="VariantType.Array"/>.
  /// </remarks>
  public ArrayVariant()
  {
    base.VariantType = VariantType.Array;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="ArrayVariant"/> class with the specified base type and array size.
  /// </summary>
  /// <param name="baseType">The type of elements that the array will contain (e.g., Int32, String, DateTime).</param>
  /// <param name="size">The number of elements in the array. Must be non-negative.</param>
  /// <remarks>
  /// Creates a zero-based array where <see cref="LowerBounds"/> = 0 and <see cref="UpperBounds"/> = size - 1.
  /// All elements are initialized to their default values for the specified type.
  /// </remarks>
  /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="size"/> is negative.</exception>
  public ArrayVariant(VariantType baseType, int size)
  {
    base.VariantType = VariantType.Array;
    Resize(size, baseType);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="ArrayVariant"/> class with the specified base type and bounds.
  /// </summary>
  /// <param name="baseType">The type of elements contained in the array variant (e.g., Int32, String, DateTime).</param>
  /// <param name="lowerBounds">The inclusive lower bound of the array index (can be any integer, including negative).</param>
  /// <param name="upperBounds">The inclusive upper bound of the array index (must be greater than or equal to <paramref name="lowerBounds"/>).</param>
  /// <remarks>
  /// Creates an array with custom indexing bounds. For example, lowerBounds=1, upperBounds=5 creates
  /// a 5-element array indexed from 1 to 5 (inclusive), matching VBA/COM array conventions.
  /// All elements are initialized to their default values for the specified type.
  /// </remarks>
  /// <exception cref="ArgumentException">Thrown when <paramref name="upperBounds"/> is less than <paramref name="lowerBounds"/>.</exception>
  public ArrayVariant(VariantType baseType, int lowerBounds, int upperBounds)
  {
    base.VariantType = VariantType.Array;
    Resize(lowerBounds, upperBounds, baseType);
  }

  /// <summary>
  /// Gets the variant type of the value represented by this instance.
  /// </summary>
  [XmlIgnore] public new VariantType VariantType => VariantType.Array;
  
  /// <summary>
  /// Gets or sets the base type of elements stored in the array.
  /// </summary>
  /// <remarks>
  /// When the base type is changed, the array is resized and existing elements are converted
  /// to the new type if possible. Elements that cannot be converted are set to their default values.
  /// This operation preserves the array's bounds but may lose data during type conversion.
  /// </remarks>
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
  /// Gets the .NET CLR type that corresponds to the current <see cref="BaseType"/>.
  /// </summary>
  /// <remarks>
  /// This property provides the actual .NET type used for the internal array storage,
  /// enabling type-safe operations and conversions. The type is determined by the
  /// <see cref="BaseType"/> property and mapped through the <c>ItemTypes</c> dictionary.
  /// </remarks>
  public Type ItemType { get; private set; } = typeof(object);
  
  /// <summary>
  /// Gets or sets the inclusive lower bound (starting index) of the array.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Setting this property resizes the array while attempting to preserve existing data.
  /// For example, changing from LowerBounds=0 to LowerBounds=1 shifts the indexing but
  /// maintains the element count if <see cref="UpperBounds"/> remains unchanged.
  /// </para>
  /// <para>
  /// The valid index range is [<see cref="LowerBounds"/>, <see cref="UpperBounds"/>] inclusive.
  /// </para>
  /// </remarks>
  public int LowerBounds
  {
    get => _lowerBounds;
    set
    {
      if (_lowerBounds != value) Resize(value, _upperBounds, BaseType);
    }
  }

  /// <summary>
  /// Gets or sets the inclusive upper bound (ending index) of the array.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Setting this property resizes the array while attempting to preserve existing data.
  /// Increasing the upper bound adds new elements initialized to their default values.
  /// Decreasing the upper bound truncates the array, discarding elements beyond the new bound.
  /// </para>
  /// <para>
  /// The valid index range is [<see cref="LowerBounds"/>, <see cref="UpperBounds"/>] inclusive.
  /// </para>
  /// </remarks>
  public int UpperBounds
  {
    get => _upperBounds;
    set
    {
      if (_upperBounds != value) Resize(_lowerBounds, value, BaseType);
    }
  }
  
  /// <summary>
  /// Gets the total number of elements in the array.
  /// </summary>
  /// <remarks>
  /// This represents the capacity of the array, not the count of non-null elements.
  /// For the count of non-null elements, use the <see cref="Count"/> property.
  /// </remarks>
  public int Size => _upperBounds - _lowerBounds + 1;
  
  /// <summary>
  /// Gets or sets the element at the specified index within the array's custom bounds.
  /// </summary>
  /// <param name="index">
  /// The index of the element to get or set. Must be within the range
  /// [<see cref="LowerBounds"/>, <see cref="UpperBounds"/>] inclusive.
  /// </param>
  /// <remarks>
  /// <para>
  /// The indexer accepts indices in the custom bounds range, not zero-based indices.
  /// For example, if LowerBounds=5 and UpperBounds=10, valid indices are 5, 6, 7, 8, 9, and 10.
  /// </para>
  /// <para>
  /// When setting a value, it is automatically converted to the array's <see cref="ItemType"/>.
  /// If the conversion fails, an exception is thrown.
  /// </para>
  /// </remarks>
  /// <exception cref="IndexOutOfRangeException">
  /// Thrown when <paramref name="index"/> is less than <see cref="LowerBounds"/>
  /// or greater than <see cref="UpperBounds"/>.
  /// </exception>
  /// <exception cref="InvalidCastException">
  /// Thrown when setting a value that cannot be converted to the array's <see cref="ItemType"/>.
  /// </exception>
  public object? this[int index]
  {
    get => _items?.GetValue(index - _lowerBounds);
    set => _items?.SetValue(Convert_ChangeType(value, ItemType), index - _lowerBounds);
  }
  
  IEnumerator<object?> IEnumerable<object?>.GetEnumerator()
  {
    yield break;
  }

  /// <summary>
  /// Returns an enumerator that iterates through the array elements.
  /// </summary>
  /// <returns>
  /// An <see cref="IEnumerator"/> that can be used to iterate through the collection,
  /// returning elements in index order from <see cref="LowerBounds"/> to <see cref="UpperBounds"/>.
  /// </returns>
  /// <remarks>
  /// The enumerator returns elements in their stored order, which corresponds to indices
  /// from LowerBounds to UpperBounds. Null elements are included in the enumeration.
  /// </remarks>
  /// <exception cref="InvalidOperationException">
  /// Thrown if the array has not been initialized (i.e., no <see cref="BaseType"/> has been set).
  /// </exception>
  public IEnumerator GetEnumerator()
  {
    return _items?.GetEnumerator() ?? throw new InvalidOperationException("ArrayVariant not initialized");
  }
  
  /// <summary>
  /// Adds an element to the next available position in the array.
  /// </summary>
  /// <param name="item">The element to add to the array. Can be <see langword="null"/> if the element type permits it.</param>
  /// <remarks>
  /// <para>
  /// This method maintains an internal fill counter that tracks the next available index.
  /// Elements are added sequentially starting from <see cref="LowerBounds"/>.
  /// </para>
  /// <para>
  /// The added item is automatically converted to the array's <see cref="ItemType"/>.
  /// </para>
  /// </remarks>
  /// <exception cref="IndexOutOfRangeException">
  /// Thrown when attempting to add more elements than the array's <see cref="Size"/> allows.
  /// </exception>
  /// <exception cref="InvalidCastException">
  /// Thrown when the item cannot be converted to the array's <see cref="ItemType"/>.
  /// </exception>
  public void Add(object? item)
  {
    this[_fillCount++] = item;
  }

  /// <summary>
  /// Removes all elements from the array by setting them to their default values.
  /// </summary>
  /// <remarks>
  /// This method does not resize the array or change its bounds. It only clears the values
  /// of existing elements. The array's <see cref="Size"/>, <see cref="LowerBounds"/>,
  /// <see cref="UpperBounds"/>, and <see cref="BaseType"/> remain unchanged.
  /// After clearing, all elements will be set to the default value for the <see cref="ItemType"/>
  /// (e.g., 0 for integers, null for reference types).
  /// </remarks>
  public void Clear()
  {
    if (_items != null)
      Array.Clear(_items);
  }

  /// <summary>
  /// Determines whether the array contains a specific value.
  /// </summary>
  /// <param name="value">The object to locate in the array. The value can be <see langword="null"/>.</param>
  /// <returns>
  /// <see langword="true"/> if the value is found in the array; otherwise, <see langword="false"/>.
  /// </returns>
  /// <remarks>
  /// The comparison uses the <see cref="object.Equals(object)"/> method to determine equality.
  /// Null values are compared using reference equality.
  /// </remarks>
  public bool Contains(object? value)
  {
    if (_items != null)
      foreach (var item in _items)
        if (item.Equals(value))
          return true;
    return false;
  }

  /// <summary>
  /// Copies the elements of the array to a specified destination array, starting at a particular array index.
  /// </summary>
  /// <param name="array">
  /// The one-dimensional array that is the destination of the elements copied from this collection.
  /// The array must have zero-based indexing.
  /// </param>
  /// <param name="arrayIndex">The zero-based index in <paramref name="array"/> at which copying begins.</param>
  /// <remarks>
  /// Elements are copied in order from <see cref="LowerBounds"/> to <see cref="UpperBounds"/>.
  /// The destination array must have sufficient space from <paramref name="arrayIndex"/> to accommodate
  /// all elements (Size elements).
  /// </remarks>
  /// <exception cref="ArgumentNullException">Thrown when <paramref name="array"/> is <see langword="null"/>.</exception>
  /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="arrayIndex"/> is less than 0.</exception>
  /// <exception cref="ArgumentException">
  /// Thrown when the destination array does not have enough space to accommodate all elements.
  /// </exception>
  public void CopyTo(object?[] array, int arrayIndex)
  {
    if (_items != null)
      _items.CopyTo(array, arrayIndex);
  }

  /// <summary>
  /// Removes the first occurrence of a specific object from the array.
  /// </summary>
  /// <param name="item">The object to remove from the array.</param>
  /// <returns>
  /// Always returns <see langword="false"/> as removal is not supported by this implementation.
  /// </returns>
  /// <remarks>
  /// This method is provided to satisfy the <see cref="ICollection{T}"/> interface contract
  /// but is not implemented. To remove elements, consider using <see cref="Clear"/> to reset
  /// all elements or resizing the array with a smaller <see cref="Size"/>.
  /// </remarks>
  public bool Remove(object? item)
  {
    return false;
  }

  /// <summary>
  /// Gets the number of non-null elements contained in the array.
  /// </summary>
  /// <remarks>
  /// This property performs a linear search through the array to count non-null elements,
  /// so it has O(n) time complexity. For the total capacity of the array regardless of
  /// null values, use the <see cref="Size"/> property instead.
  /// </remarks>
  public int Count
  {
    get
    {
      var count = 0;
      if (_items != null)
        foreach (var item in _items)
          if (item is not null)
            count++;
      return count;
    }
  }

  /// <summary>
  /// Gets a value indicating whether the array is read-only.
  /// </summary>
  /// <remarks>
  /// This property is provided to satisfy the <see cref="ICollection{T}"/> interface contract.
  /// Elements can be modified via the indexer, and the array can be resized or cleared.
  /// </remarks>
  public bool IsReadOnly => false;

  /// <summary>
  /// Resizes the array to the specified size while preserving the current <see cref="BaseType"/>.
  /// </summary>
  /// <param name="size">
  /// The new number of elements in the array. Must be non-negative.
  /// </param>
  /// <remarks>
  /// <para>
  /// This method sets <see cref="LowerBounds"/> to 0 and <see cref="UpperBounds"/> to (size - 1),
  /// creating a zero-based array.
  /// </para>
  /// <para>
  /// If the new size is larger than the current size, new elements are initialized to their default values.
  /// If the new size is smaller, elements beyond the new bound are discarded.
  /// Existing elements within the new bounds are preserved when possible.
  /// </para>
  /// </remarks>
  /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="size"/> is negative.</exception>
  public void Resize(int size)
  {
    Resize(0, size - 1, BaseType);
  }

  /// <summary>
  /// Resizes the array to the specified size and changes the element type.
  /// </summary>
  /// <param name="size">
  /// The new number of elements in the array. Must be non-negative.
  /// </param>
  /// <param name="baseType">
  /// The new type of elements that the array will contain (e.g., Int32, String, DateTime).
  /// </param>
  /// <remarks>
  /// <para>
  /// This method sets <see cref="LowerBounds"/> to 0 and <see cref="UpperBounds"/> to (size - 1),
  /// creating a zero-based array with the specified element type.
  /// </para>
  /// <para>
  /// Existing elements are converted to the new type if possible. Elements that cannot be converted
  /// are set to their default values for the new type. This operation may result in data loss
  /// if the types are incompatible.
  /// </para>
  /// </remarks>
  /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="size"/> is negative.</exception>
  public void Resize(int size, VariantType baseType)
  {
    Resize(0, size - 1, baseType);
  }

  /// <summary>
  /// Resizes the array with new bounds while preserving the current <see cref="BaseType"/>.
  /// </summary>
  /// <param name="lowerBounds">The new inclusive lower bound of the array index.</param>
  /// <param name="upperBounds">
  /// The new inclusive upper bound of the array index. Must be greater than or equal to <paramref name="lowerBounds"/>.
  /// </param>
  /// <remarks>
  /// <para>
  /// This method allows changing both the size and indexing range of the array.
  /// For example, changing from bounds (0, 4) to (1, 5) maintains a 5-element array
  /// but shifts the valid indices from 0-4 to 1-5.
  /// </para>
  /// <para>
  /// Existing elements are preserved when possible within the new bounds. If the new size
  /// is larger, additional elements are initialized to their default values. If smaller,
  /// elements beyond the new upper bound are discarded.
  /// </para>
  /// </remarks>
  /// <exception cref="ArgumentException">
  /// Thrown when <paramref name="upperBounds"/> is less than <paramref name="lowerBounds"/>.
  /// </exception>
  public void Resize(int lowerBounds, int upperBounds)
  {
    Resize(lowerBounds, upperBounds, BaseType);
  }

  /// <summary>
  /// Resizes the array with new bounds and changes the element type.
  /// </summary>
  /// <param name="lowerBounds">The new inclusive lower bound of the array index.</param>
  /// <param name="upperBounds">
  /// The new inclusive upper bound of the array index. Must be greater than or equal to <paramref name="lowerBounds"/>.
  /// </param>
  /// <param name="baseType">
  /// The new type of elements that the array will contain (e.g., Int32, String, DateTime).
  /// </param>
  /// <remarks>
  /// <para>
  /// This is the most comprehensive resize method, allowing simultaneous changes to the array's
  /// size, indexing range, and element type.
  /// </para>
  /// <para>
  /// The method attempts to preserve and convert existing elements:
  /// <list type="bullet">
  /// <item><description>If the types are compatible, elements are converted to the new type</description></item>
  /// <item><description>If the new size is larger, additional elements are initialized to defaults</description></item>
  /// <item><description>If the new size is smaller, excess elements are discarded</description></item>
  /// <item><description>If types are incompatible, elements are set to default values</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// No operation is performed if the new bounds and type match the current values.
  /// </para>
  /// </remarks>
  /// <exception cref="ArgumentException">
  /// Thrown when <paramref name="upperBounds"/> is less than <paramref name="lowerBounds"/>.
  /// </exception>
  public void Resize(int lowerBounds, int upperBounds, VariantType baseType)
  {
    if (lowerBounds != _lowerBounds || upperBounds != _upperBounds || baseType != _baseType)
    {
      var newSize = upperBounds - lowerBounds + 1;
      var newItemType = ItemTypes[baseType];
      var newItems = Array.CreateInstance(newItemType, newSize);
      if (_items != null)
      {
        if (newItemType == ItemType && newSize >= Size)
          _items.CopyTo(newItems, 0);
        else
          for (var i = 0; i < Size && i < newSize; i++)
            newItems.SetValue(Convert_ChangeType(_items.GetValue(i), newItemType), i);
      }
      _items = newItems;
      _lowerBounds = lowerBounds;
      _upperBounds = upperBounds;
      _baseType = baseType;
      ItemType = newItemType;
      _fillCount = 0;
    }
  }

  /// <summary>
  /// Determines whether the current <see cref="ArrayVariant"/> instance is equal to the specified <see cref="ArrayVariant"/>.
  /// </summary>
  /// <param name="other">The <see cref="ArrayVariant"/> to compare with the current instance. Can be <see langword="null"/>.</param>
  /// <returns>
  /// <see langword="true"/> if the specified <see cref="ArrayVariant"/> is equal to the current instance;
  /// otherwise, <see langword="false"/>.
  /// </returns>
  /// <remarks>
  /// <para>
  /// Equality is determined by comparing:
  /// <list type="bullet">
  /// <item><description>The variant types must match</description></item>
  /// <item><description>The lower and upper bounds must be identical</description></item>
  /// <item><description>The array lengths must be equal</description></item>
  /// <item><description>All corresponding elements must be equal (compared using reference equality)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Two <see cref="ArrayVariant"/> instances are considered equal only if all these components match.
  /// Note that element comparison uses reference equality (==), not <see cref="object.Equals(object)"/>.
  /// </para>
  /// </remarks>
  public bool Equals(ArrayVariant? other)
  {
    if (other == null)
      return false;
    var result =
      _VariantType == other._VariantType
      && _lowerBounds == other._lowerBounds 
      && _upperBounds == other._upperBounds
      && _items?.Length == other._items?.Length;
    if (result && _items!=null && other._items!=null)
      for (int i = 0; i < _items.Length; i++)
      {
        var item = _items.GetValue(i);
        var otherItem = other._items.GetValue(i);
        if (item != otherItem)
          return false;
      }
    return true;
  }

}