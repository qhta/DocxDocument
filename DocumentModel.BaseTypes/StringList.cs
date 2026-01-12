namespace DocumentModel;

/// <summary>
/// Represents a collection of strings that can be parsed from and converted to comma-separated values.
/// </summary>
/// <remarks>
/// This class provides a convenient way to work with lists of strings, supporting:
/// <list type="bullet">
/// <item><description>Parsing from comma-separated string values</description></item>
/// <item><description>Converting to comma-separated string representation</description></item>
/// <item><description>Standard collection operations (Add, Remove, Contains, etc.)</description></item>
/// <item><description>Implicit conversions between string and StringList</description></item>
/// </list>
/// </remarks>
[JsonConverter(typeof(StringListJsonConverter))]
public partial class StringList : ICollection, ICollection<string>, IEquatable<StringList>, IConvertible
{
  private readonly List<string> _list = new();

  /// <summary>
  /// Initializes a new instance of the <see cref="StringList"/> class.
  /// </summary>
  public StringList() { }

  /// <summary>
  /// Initializes a new instance of the <see cref="StringList"/> class with a comma-separated string.
  /// </summary>
  /// <param name="str">A comma-separated string to parse into individual string items.</param>
  /// <remarks>
  /// The string is split by commas, and each resulting substring is added as a separate item in the list.
  /// If <paramref name="str"/> is null, an empty list is created.
  /// </remarks>
  public StringList(string? str)
  {
    if (str != null)
    {
      var ss = str.Split(',');
      foreach (var s in ss)
      { _list.Add(s.Trim()); }
    }
  }

  /// <summary>
  /// Attempts to parse the specified string into a new StringList instance.
  /// </summary>
  /// <param name="str">The string to parse into a StringList.</param>
  /// <param name="result">When this method returns, contains the resulting StringList if parsing succeeded; otherwise, null.</param>
  /// <returns>true if the string was successfully parsed; otherwise, false.</returns>
  public static bool TryParse(string? str, out StringList? result)
  {
    try
    {
      result = new StringList(str);
      return true;
    }
    catch
    {
      result = null;
      return false;
    }
  }
  /// <summary>
  /// Returns an enumerator that iterates through the collection.
  /// </summary>
  /// <returns>An enumerator that can be used to iterate through the collection.</returns>
  public IEnumerator<string> GetEnumerator()
  {
    return _list.GetEnumerator();
  }

  /// <summary>
  /// Returns an enumerator that iterates through a collection.
  /// </summary>
  /// <returns>An <see cref="IEnumerator"/> object that can be used to iterate through the collection.</returns>
  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }

  /// <summary>
  /// Adds an item to the collection.
  /// </summary>
  /// <param name="item">The string to add to the collection.</param>
  public void Add(string item)
  {
    _list?.Add(item);
  }

  /// <summary>
  /// Removes all items from the collection.
  /// </summary>
  public void Clear()
  {
    _list?.Clear();
  }

  /// <summary>
  /// Determines whether the collection contains a specific value.
  /// </summary>
  /// <param name="item">The string to locate in the collection.</param>
  /// <returns><see langword="true"/> if <paramref name="item"/> is found in the collection; otherwise, <see langword="false"/>.</returns>
  public bool Contains(string item)
  {
    return _list?.Contains(item) ?? false;
  }

  /// <summary>
  /// Copies the elements of the collection to an <see cref="Array"/>, starting at a particular array index.
  /// </summary>
  /// <param name="array">The one-dimensional <see cref="Array"/> that is the destination of the elements copied from the collection.</param>
  /// <param name="arrayIndex">The zero-based index in <paramref name="array"/> at which copying begins.</param>
  public void CopyTo(string[] array, int arrayIndex)
  {
    _list?.CopyTo(array, arrayIndex);
  }

  /// <summary>
  /// Removes the first occurrence of a specific object from the collection.
  /// </summary>
  /// <param name="item">The string to remove from the collection.</param>
  /// <returns><see langword="true"/> if <paramref name="item"/> was successfully removed from the collection; otherwise, <see langword="false"/>.</returns>
  public bool Remove(string item)
  {
    return _list?.Remove(item) ?? false;
  }

  /// <summary>
  /// Gets the number of elements contained in the collection.
  /// </summary>
  public int Count => _list?.Count ?? 0;

  /// <summary>
  /// Gets a value indicating whether the collection is read-only.
  /// </summary>
  /// <value>Always returns <see langword="false"/> as this collection is not read-only.</value>
  public bool IsReadOnly => false;

  /// <summary>
  /// Returns a string that represents the current object.
  /// </summary>
  /// <returns>A comma-separated string containing all items in the collection, separated by ", " (comma and space).</returns>
  /// <remarks>
  /// For example, a list containing "apple", "banana", "cherry" will be represented as "apple, banana, cherry".
  /// </remarks>
  public override string ToString()
  {
    return String.Join(", ", _list.ToArray());
  }

  /// <summary>
  /// Implicitly converts a string to a <see cref="StringList"/>.
  /// </summary>
  /// <param name="str">The comma-separated string to convert.</param>
  /// <returns>A <see cref="StringList"/> containing the parsed items, or <see langword="null"/> if <paramref name="str"/> is null.</returns>
  /// <remarks>
  /// The string is split by commas to create the list items.
  /// </remarks>
  public static implicit operator StringList?(string? str) => (str != null) ? new StringList(str) : null;

  /// <summary>
  /// Implicitly converts a <see cref="StringList"/> to a string.
  /// </summary>
  /// <param name="value">The <see cref="StringList"/> to convert.</param>
  /// <returns>A comma-separated string representation of the list, or <see langword="null"/> if <paramref name="value"/> is null.</returns>
  /// <remarks>
  /// Items are joined with ", " (comma and space) as the separator.
  /// </remarks>
  public static implicit operator string?(StringList? value) => value?.ToString(CultureInfo.InvariantCulture);

  /// <summary>
  /// Determines whether the specified object is equal to the current object.
  /// </summary>
  /// <param name="obj">The object to compare with the current object.</param>
  /// <returns><see langword="true"/> if the specified object is equal to the current object; otherwise, <see langword="false"/>.</returns>
  /// <remarks>
  /// Equality is determined by:
  /// <list type="bullet">
  /// <item><description>If <paramref name="obj"/> is a <see cref="StringList"/>, compares all items in order</description></item>
  /// <item><description>If <paramref name="obj"/> is a string, returns true only if this list contains exactly one item equal to that string</description></item>
  /// <item><description>Otherwise, returns false</description></item>
  /// </list>
  /// </remarks>
  public override bool Equals(object? obj)
  {
    if (obj == null) return false;
    if (obj is StringList other)
      return Equals(other);
    if (obj is string str)
      return Count == 1 && _list[0].Equals(str);
    return false;
  }

  /// <summary>
  /// Indicates whether the current object is equal to another object of the same type.
  /// </summary>
  /// <param name="other">An object to compare with this object.</param>
  /// <returns><see langword="true"/> if the current object is equal to the <paramref name="other"/> parameter; otherwise, <see langword="false"/>.</returns>
  /// <remarks>
  /// Two <see cref="StringList"/> instances are considered equal if they have the same number of items
  /// and all corresponding items are equal in the same order.
  /// </remarks>
  public bool Equals(StringList? other)
  {
    if (other == null) return false;
    if (this.Count != other.Count) return false;
    for (int i = 0; i < this.Count; i++)
      if (!this._list[i].Equals(other._list[i])) return false;
    return true;
  }

  /// <summary>
  /// Returns the hash code for this instance.
  /// </summary>
  /// <returns>A 32-bit signed integer hash code.</returns>
  /// <remarks>
  /// The hash code is computed by combining the hash codes of all items in the collection.
  /// </remarks>
  public override int GetHashCode()
  {
    var result = 0;
    foreach (var item in _list)
      result = HashCode.Combine(result, item.GetHashCode());
    return result;
  }

  /// <summary>
  /// Copies the elements of the <see cref="ICollection"/> to an <see cref="Array"/>, starting at a particular array index.
  /// </summary>
  /// <param name="array">The one-dimensional <see cref="Array"/> that is the destination of the elements copied from the collection.</param>
  /// <param name="index">The zero-based index in <paramref name="array"/> at which copying begins.</param>
  /// <remarks>
  /// This method only performs the copy if <paramref name="array"/> is of type string[].
  /// </remarks>
  void ICollection.CopyTo(Array array, int index)
  {
    if (array is string[] ss)
      _list.CopyTo(ss, index);
  }

  /// <summary>
  /// Gets a value indicating whether access to the <see cref="ICollection"/> is synchronized (thread safe).
  /// </summary>
  /// <value>This implementation always returns <see langword="false"/> as the collection is not synchronized.</value>
  bool ICollection.IsSynchronized => false;

  /// <summary>
  /// Gets an object that can be used to synchronize access to the <see cref="ICollection"/>.
  /// </summary>
  /// <value>An object that can be used to synchronize access to the collection.</value>
  object ICollection.SyncRoot { get; } = new object();

  #region IConvertible Implementation

  /// <summary>
  /// Returns the <see cref="TypeCode"/> for this instance.
  /// </summary>
  /// <returns><see cref="TypeCode.Object"/> as this is a collection type.</returns>
  public TypeCode GetTypeCode()
  {
    return TypeCode.Object;
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent Boolean value.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns><see langword="true"/> if the list is not empty; otherwise, <see langword="false"/>.</returns>
  public bool ToBoolean(IFormatProvider? provider)
  {
    return Count > 0;
  }

  /// <summary>
  /// This conversion is not supported for string list types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public byte ToByte(IFormatProvider? provider)
  {
    throw new InvalidCastException("Cannot convert StringList to Byte.");
  }

  /// <summary>
  /// This conversion is not supported for string list types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public char ToChar(IFormatProvider? provider)
  {
    throw new InvalidCastException("Cannot convert StringList to Char.");
  }

  /// <summary>
  /// This conversion is not supported for string list types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidCastException("Cannot convert StringList to DateTime.");
  }

  /// <summary>
  /// This conversion is not supported for string list types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public decimal ToDecimal(IFormatProvider? provider)
  {
    throw new InvalidCastException("Cannot convert StringList to Decimal.");
  }

  /// <summary>
  /// This conversion is not supported for string list types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public double ToDouble(IFormatProvider? provider)
  {
    throw new InvalidCastException("Cannot convert StringList to Double.");
  }

  /// <summary>
  /// This conversion is not supported for string list types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public short ToInt16(IFormatProvider? provider)
  {
    throw new InvalidCastException("Cannot convert StringList to Int16.");
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 32-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>The number of items in the list.</returns>
  public int ToInt32(IFormatProvider? provider)
  {
    return Count;
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 64-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>The number of items in the list.</returns>
  public long ToInt64(IFormatProvider? provider)
  {
    return Count;
  }

  /// <summary>
  /// This conversion is not supported for string list types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public sbyte ToSByte(IFormatProvider? provider)
  {
    throw new InvalidCastException("Cannot convert StringList to SByte.");
  }

  /// <summary>
  /// This conversion is not supported for string list types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public float ToSingle(IFormatProvider? provider)
  {
    throw new InvalidCastException("Cannot convert StringList to Single.");
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent string.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A string representation with all items separated by ", " (comma and space), or an empty string if the list is empty.</returns>
  public string ToString(IFormatProvider? provider)
  {
    return ToString();
  }

  /// <summary>
  /// Converts the value of this instance to the specified type.
  /// </summary>
  /// <param name="conversionType">The type to which to convert the value of this instance.</param>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>
  /// An object of the specified type with a value equivalent to the value of this instance.
  /// Supports conversion to <see cref="String"/>, <see cref="Boolean"/>, <see cref="Int32"/>, <see cref="Int64"/>, and <see cref="StringList"/>.
  /// </returns>
  /// <exception cref="InvalidCastException">This conversion is not supported for the specified type.</exception>
  public object ToType(Type conversionType, IFormatProvider? provider)
  {
    if (conversionType == typeof(string))
      return ToString(provider);

    if (conversionType == typeof(bool))
      return ToBoolean(provider);

    if (conversionType == typeof(int))
      return ToInt32(provider);

    if (conversionType == typeof(long))
      return ToInt64(provider);

    if (conversionType == typeof(StringList))
      return this;

    throw new InvalidCastException($"Cannot convert StringList to {conversionType.Name}.");
  }

  /// <summary>
  /// This conversion is not supported for string list types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public ushort ToUInt16(IFormatProvider? provider)
  {
    throw new InvalidCastException("Cannot convert StringList to UInt16.");
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 32-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>The number of items in the list as an unsigned integer.</returns>
  public uint ToUInt32(IFormatProvider? provider)
  {
    return (uint)Count;
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 64-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>The number of items in the list as an unsigned long integer.</returns>
  public ulong ToUInt64(IFormatProvider? provider)
  {
    return (ulong)Count;
  }

  #endregion
}