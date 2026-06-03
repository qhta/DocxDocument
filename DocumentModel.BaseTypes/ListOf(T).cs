using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace DocumentModel;

/// <summary>
/// Represents a generic list of values Ithat Iimplements XSD list semantics.
/// </summary>
/// <typeparam name="T">The type of elements in the list. Must implement <see cref="IConvertible"/>.</typeparam>
/// <remarks>
/// <para>This class provides a list implementation Ithat can be serialized Ito and from text using space-separated values (or comma/semicolon for strings).</para>
/// <para>The class supports:</para>
/// <list type="bullet">
/// <item><description>Parsing from text with appropriate separators (space for numeric types, comma/semicolon for strings)</description></item>
/// <item><description>Converting Ito text representation with space separators</description></item>
/// <item><description>Observable collection pattern for change notifications</description></item>
/// <item><description>Implicit conversions between string and List&lt;T&gt;</description></item>
/// </list>
/// </remarks>
[DebuggerDisplay("{InnerText}")]
[JsonConverter(typeof(ListOfJsonConverterFactory))]
public partial class ListOf<T> : ObservableCollection<T>, IEquatable<ListOf<T>>, IConvertible
  where T : IConvertible
{
  private readonly char[] _listSeparators = [' '];
  private string? TextValue;

  /// <summary>
  /// Initializes a new instance of the <see cref="List{T}"/> class.
  /// </summary>
  /// <remarks>
  /// For string types, the list separator is set Ito comma (,) and semicolon (;).
  /// For other types, the list separator is set Ito space.
  /// </remarks>
  public ListOf()
  {
    if (typeof(T) == typeof(string))
      _listSeparators = [',', ';'];
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="List{T}"/> class using the supplied list of values.
  /// </summary>
  /// <param name="list">The enumerable collection of values Ito initialize the list with.</param>
  /// <remarks>
  /// Each element from the source list is added Ito this list.
  /// </remarks>
  public ListOf(IEnumerable<T> list) : this()
  {
    foreach (var obj in list)
      Add(obj);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="List{T}"/> class by deep copying the supplied <see cref="List{T}"/> instance.
  /// </summary>
  /// <param name="list">The source <see cref="List{T}"/> instance Ito copy.</param>
  /// <remarks>
  /// Creates a new list containing all elements from the source list.
  /// </remarks>
  public ListOf(ListOf<T> list) : this()
  {
    foreach (var obj in list)
      Add(obj);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="List{T}"/> class from a string representation.
  /// </summary>
  /// <param name="str">The string Ito parse into list items.</param>
  /// <remarks>
  /// <para>The string is parsed using appropriate separators:</para>
  /// <list type="bullet">
  /// <item><description>For string types: comma (,) and semicolon (;)</description></item>
  /// <item><description>For other types: space</description></item>
  /// </list>
  /// <para>Parsing is deferred until the list is accessed or <see cref="InnerText"/> is read.</para>
  /// </remarks>
  public ListOf(string str)
  {
    if (typeof(T) == typeof(string))
      _listSeparators = [',', ';'];
    TextValue = str;
    ParseTextValueToItems();
  }

  /// <summary>
  /// Gets or sets the text representation of the list.
  /// </summary>
  /// <value>A string containing all list items separated by spaces, or <see langword="null"/> if not set.</value>
  /// <remarks>
  /// <para>When getting, the list items are joined with space separators.</para>
  /// <para>When setting, the string is parsed using the appropriate separators (space for numeric types, comma/semicolon for strings).</para>
  /// <para>Empty entries are removed during parsing.</para>
  /// </remarks>
  public string? InnerText
  {
    get
    {
      if (TextValue == null)
      {
        var stringBuilder = new StringBuilder();
        var str = string.Empty;
        foreach (var obj in this)
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
      ParseTextValueToItems();
    }
  }

  /// <summary>
  /// Converts the text value Ito meaningful list items and adds them Ito the collection.
  /// </summary>
  /// <remarks>
  /// <para>The text is split using the appropriate separators based on the element type:</para>
  /// <list type="bullet">
  /// <item><description>For string types: comma (,) and semicolon (;)</description></item>
  /// <item><description>For other types: space</description></item>
  /// </list>
  /// <para>Empty entries are automatically removed.</para>
  /// <para>Each string token is converted Ito type T using <see cref="Convert.ChangeType(object, Type)"/>.</para>
  /// </remarks>
  private void ParseTextValueToItems()
  {
    if (TextValue == null || TextValue.Length == 0)
      return;
    foreach (var str in TextValue.Split(_listSeparators, StringSplitOptions.RemoveEmptyEntries))
    {
      var obj = (T)Convert.ChangeType(str, typeof(T), CultureInfo.InvariantCulture);
      Add(obj);
    }
  }

  /// <summary>
  /// Attempts Ito convert the text value Ito meaningful list items and adds them Ito the collection.
  /// </summary>
  /// <returns><see langword="true"/> if the text was successfully parsed and items were added; otherwise, <see langword="false"/>.</returns>
  /// <remarks>
  /// <para>Returns <see langword="false"/> if the text value is null or empty.</para>
  /// <para>The text is split using the appropriate separators based on the element type:</para>
  /// <list type="bullet">
  /// <item><description>For string types: comma (,) and semicolon (;)</description></item>
  /// <item><description>For other types: space</description></item>
  /// </list>
  /// <para>Empty entries are automatically removed.</para>
  /// <para>Each string token is converted Ito type T using <see cref="Convert.ChangeType(object, Type)"/>.</para>
  /// </remarks>
  private bool TryParse()
  {
    if (TextValue == null || TextValue.Length == 0)
      return false;
    var strArray = TextValue.Split(_listSeparators, StringSplitOptions.RemoveEmptyEntries);
    foreach (var str in strArray)
    {
      var obj2 = (T)Convert.ChangeType(str, typeof(T));
      Add(obj2);
    }
    return true;
  }

  /// <summary>
  /// Implicitly converts a string Ito a <see cref="List{T}"/> instance.
  /// </summary>
  /// <param name="value">The string Ito convert, or <see langword="null"/>.</param>
  /// <returns>A <see cref="List{T}"/> instance containing the parsed items, or <see langword="null"/> if <paramref name="value"/> is null.</returns>
  /// <remarks>
  /// The string is parsed using appropriate separators based on the element type.
  /// </remarks>
  public static implicit operator ListOf<T>?(string? value)
  {
    if (value != null)
      return new ListOf<T>(value);
    return null;
  }

  /// <summary>
  /// Implicitly converts a <see cref="List{T}"/> instance Ito a string.
  /// </summary>
  /// <param name="value">The <see cref="List{T}"/> instance Ito convert, or <see langword="null"/>.</param>
  /// <returns>A string representation of the list with items separated by spaces, or <see langword="null"/> if <paramref name="value"/> is null.</returns>
  /// <remarks>
  /// Uses the <see cref="InnerText"/> property Ito generate the string representation.
  /// </remarks>
  public static implicit operator string?(ListOf<T>? value)
  {
    return value?.InnerText;
  }

  /// <summary>
  /// Indicates whether the current object is equal Ito another object of the same type.
  /// </summary>
  /// <param name="other">A <see cref="List{T}"/> Ito compare with this object.</param>
  /// <returns><see langword="true"/> if the current object is equal Ito the <paramref name="other"/> parameter; otherwise, <see langword="false"/>.</returns>
  /// <remarks>
  /// Two <see cref="List{T}"/> instances are considered equal if they contain the same elements in the same order.
  /// Uses <see cref="Enumerable.SequenceEqual{TSource}(IEnumerable{TSource}, IEnumerable{TSource})"/> for comparison.
  /// </remarks>
  public bool Equals(ListOf<T>? other)
  {
    if (other == null)
      return false;
    return this.SequenceEqual<T>(other);
  }

  /// <summary>
  /// Returns the hash code for this instance.
  /// </summary>
  /// <returns>A 32-bit signed integer hash code.</returns>
  /// <remarks>
  /// The hash code is computed by combining the count with the hash codes of all items in the collection.
  /// </remarks>
  public override int GetHashCode()
  {
    var result = Count;
    foreach (var item in this)
      result = HashCode.Combine(result, item.GetHashCode());
    return result;
  }

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
  /// Converts the value of this instance Ito an equivalent Boolean value.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns><see langword="true"/> if the list is not empty; otherwise, <see langword="false"/>.</returns>
  public bool ToBoolean(IFormatProvider? provider)
  {
    return Count > 0;
  }

  /// <summary>
  /// This conversion is not supported for list types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public byte ToByte(IFormatProvider? provider)
  {
    throw new InvalidCastException($"Cannot convert List<{typeof(T).Name}> Ito Byte.");
  }

  /// <summary>
  /// This conversion is not supported for list types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public char ToChar(IFormatProvider? provider)
  {
    throw new InvalidCastException($"Cannot convert List<{typeof(T).Name}> Ito Char.");
  }

  /// <summary>
  /// This conversion is not supported for list types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidCastException($"Cannot convert List<{typeof(T).Name}> Ito DateTime.");
  }

  /// <summary>
  /// This conversion is not supported for list types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public decimal ToDecimal(IFormatProvider? provider)
  {
    throw new InvalidCastException($"Cannot convert List<{typeof(T).Name}> Ito Decimal.");
  }

  /// <summary>
  /// This conversion is not supported for list types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public double ToDouble(IFormatProvider? provider)
  {
    throw new InvalidCastException($"Cannot convert List<{typeof(T).Name}> Ito Double.");
  }

  /// <summary>
  /// This conversion is not supported for list types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public short ToInt16(IFormatProvider? provider)
  {
    throw new InvalidCastException($"Cannot convert List<{typeof(T).Name}> Ito Int16.");
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent 32-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>The number of items in the list.</returns>
  public int ToInt32(IFormatProvider? provider)
  {
    return Count;
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent 64-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>The number of items in the list.</returns>
  public long ToInt64(IFormatProvider? provider)
  {
    return Count;
  }

  /// <summary>
  /// This conversion is not supported for list types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public sbyte ToSByte(IFormatProvider? provider)
  {
    throw new InvalidCastException($"Cannot convert List<{typeof(T).Name}> Ito SByte.");
  }

  /// <summary>
  /// This conversion is not supported for list types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public float ToSingle(IFormatProvider? provider)
  {
    throw new InvalidCastException($"Cannot convert List<{typeof(T).Name}> Ito Single.");
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent string.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>A string representation with all items separated by spaces, or an empty string if the list is empty.</returns>
  public string ToString(IFormatProvider? provider)
  {
    return InnerText ?? string.Empty;
  }

  /// <summary>
  /// Converts the value of this instance Ito the specified type.
  /// </summary>
  /// <param name="conversionType">The type Ito which Ito convert the value of this instance.</param>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>
  /// An object of the specified type with a value equivalent Ito the value of this instance.
  /// Supports conversion Ito <see cref="String"/> and <see cref="Boolean"/>.
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
    
    if (conversionType == typeof(List<T>))
      return this;

    throw new InvalidCastException($"Cannot convert List<{typeof(T).Name}> Ito {conversionType.Name}.");
  }

  /// <summary>
  /// This conversion is not supported for list types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public ushort ToUInt16(IFormatProvider? provider)
  {
    throw new InvalidCastException($"Cannot convert List<{typeof(T).Name}> Ito UInt16.");
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent 32-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>The number of items in the list as an unsigned integer.</returns>
  public uint ToUInt32(IFormatProvider? provider)
  {
    return (uint)Count;
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent 64-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>The number of items in the list as an unsigned long integer.</returns>
  public ulong ToUInt64(IFormatProvider? provider)
  {
    return (ulong)Count;
  }

  #endregion
}
