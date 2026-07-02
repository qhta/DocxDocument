namespace DocumentModel;

/// <summary>
/// Represents a variant that contains a dynamic vector (list) of elements with a specified base type.
/// </summary>
/// <remarks>
/// <para>
/// <see cref="VectorVariant"/> is part of the variant type system used in Office Open XML documents
/// to represent ordered collections of values in custom properties, metadata, and data storage.
/// Unlike <see cref="ArrayVariant"/>, VectorVariant uses zero-based indexing and does not support
/// custom bounds.
/// </para>
/// <para>
/// VectorVariant supports:
/// <list type="bullet">
/// <item><description><b>Flexible base types:</b> Can store any variant type (integers, strings, dates, booleans, etc.)</description></item>
/// <item><description><b>Dynamic sizing:</b> Automatically grows as elements are added</description></item>
/// <item><description><b>Zero-based indexing:</b> Standard .NET collection indexing starting at 0</description></item>
/// <item><description><b>IList operations:</b> Supports insertion, removal, and indexed access</description></item>
/// <item><description><b>XML serialization:</b> Designed for serialization to/from OpenXML format</description></item>
/// </list>
/// </para>
/// <para>
/// The <see cref="BaseType"/> property specifies the expected type of elements, though enforcement
/// of this constraint depends on the implementation context. Elements can be null.
/// </para>
/// </remarks>
/// <example>
/// <code>
/// // Create an integer vector
/// var intVector = new VectorVariant(VariantType.Int32);
/// intVector.Add(10);
/// intVector.Add(20);
/// intVector.Add(30);
/// 
/// // Create a string vector
/// var stringVector = new VectorVariant(VariantType.String);
/// stringVector.Add("First");
/// stringVector.Add("Second");
/// stringVector.Insert(1, "Middle");
/// 
/// // Access elements
/// Console.WriteLine(stringVector[0]); // "First"
/// Console.WriteLine(stringVector[1]); // "Middle"
/// </code>
/// </example>
[DataContract]
[JsonConverter(typeof(VectorVariantJsonConverter))]
public partial class VectorVariant : Variant, IList<object?>, IEquatable<VectorVariant>
{

#pragma warning disable CS8600
#pragma warning disable CS8603
  /// <summary>
  /// Gets the internal list of items cast from the base <see cref="Variant._value"/> field.
  /// </summary>
  /// <remarks>
  /// This property provides direct access to the underlying <see cref="IList{T}"/> that stores
  /// the vector elements. The value is guaranteed to be a <see cref="IList{T}"/> of nullable objects
  /// as initialized in the constructor.
  /// </remarks>
  private IList<object?> _items => (IList<object?>)_value;
#pragma warning restore

  /// <summary>
  /// Initializes a new instance of the <see cref="VectorVariant"/> class.
  /// </summary>
  /// <remarks>
  /// Creates an empty vector with no specific base type. The <see cref="VariantType"/> is set
  /// to <see cref="VariantType.Vector"/>. Elements can be added using the <see cref="Add"/> method.
  /// </remarks>
  public VectorVariant(): base (VariantType.Vector, new List<object?>())
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="VectorVariant"/> class with a specified base type.
  /// </summary>
  /// <param name="baseType">
  /// The type of elements that the vector is intended to contain (e.g., Int32, String, DateTime).
  /// </param>
  /// <remarks>
  /// Creates an empty vector configured for the specified element type. The <see cref="BaseType"/>
  /// property serves as metadata indicating the expected type of elements, but type enforcement
  /// depends on the usage context.
  /// </remarks>
  public VectorVariant(VariantType baseType) : this()
  {
    BaseType = baseType;
  }

  /// <summary>
  /// Gets the variant type of the value represented by this instance.
  /// </summary>
  /// <value>Always returns <see cref="VariantType.Vector"/>.</value>
  /// <remarks>
  /// This property overrides the base class property to ensure the variant type is always Vector,
  /// regardless of the <see cref="BaseType"/> or contents.
  /// </remarks>
  [XmlIgnore] public new VariantType VariantType => VariantType.Vector;

  /// <summary>
  /// Gets the type name of this variant.
  /// </summary>
  /// <value>Always returns "Vector".</value>
  /// <remarks>
  /// This property provides a string representation of the variant type for display and debugging purposes.
  /// </remarks>
  [XmlIgnore] public new string TypeName => "Vector";

  /// <summary>
  /// Gets or sets the underlying value of this variant.
  /// </summary>
  /// <value>
  /// The internal <see cref="IList{T}"/> containing the vector elements, or null.
  /// </value>
  /// <remarks>
  /// <para>
  /// This property is marked with <see cref="XmlIgnoreAttribute"/> to prevent direct XML serialization.
  /// The vector's elements should be serialized individually through the collection interface.
  /// </para>
  /// </remarks>
  [XmlIgnore]
  public override object? Value => _value;

  /// <summary>
  /// Gets or sets the base type of elements contained in the vector.
  /// </summary>
  /// <value>
  /// A <see cref="VariantType"/> value indicating the expected type of elements,
  /// or <see langword="null"/> if no specific type is defined.
  /// </value>
  /// <remarks>
  /// <para>
  /// The base type serves as metadata indicating what type of elements the vector is intended
  /// to contain. This information can be used for:
  /// <list type="bullet">
  /// <item><description>Validation during serialization/deserialization</description></item>
  /// <item><description>ValueType conversion when reading/writing elements</description></item>
  /// <item><description>Documentation of the vector's intended usage</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Note that the base type is not strictly enforced by the VectorVariant class itself;
  /// elements of different types can be added. ValueType enforcement depends on the usage context
  /// and serialization implementation.
  /// </para>
  /// </remarks>
  public VariantType? BaseType { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns an enumerator that iterates through the vector elements.
  /// </summary>
  /// <returns>
  /// An <see cref="IEnumerator{T}"/> of nullable objects that can be used to iterate through the collection.
  /// </returns>
  /// <remarks>
  /// The enumerator returns elements in the order they were added (or as modified through list operations).
  /// Null elements are included in the enumeration.
  /// </remarks>
  public IEnumerator<object?> GetEnumerator()
  {
    return _items.GetEnumerator();
  }

  /// <summary>
  /// Returns an enumerator that iterates through the vector elements.
  /// </summary>
  /// <returns>
  /// An <see cref="IEnumerator"/> that can be used to iterate through the collection.
  /// </returns>
  /// <remarks>
  /// This is the non-generic version of <see cref="GetEnumerator()"/>, provided to satisfy
  /// the <see cref="IEnumerable"/> interface contract.
  /// </remarks>
  IEnumerator IEnumerable.GetEnumerator()
  {
    return ((IEnumerable)_items).GetEnumerator();
  }

  /// <summary>
  /// Adds an element to the end of the vector.
  /// </summary>
  /// <param name="item">
  /// The element to add to the vector. The value can be <see langword="null"/>.
  /// </param>
  /// <remarks>
  /// <para>
  /// The element is appended to the end of the vector, increasing the <see cref="Count"/> by 1.
  /// Null values are permitted and stored as-is.
  /// </para>
  /// <para>
  /// No type checking is performed against the <see cref="BaseType"/> property when adding elements.
  /// ValueType validation, if needed, should be performed by the caller or during serialization.
  /// </para>
  /// </remarks>
  public void Add(object? item)
  {
    //if (item == null)
    //  _items.Add(DBNull.Value);
    //else
    _items.Add(item);
  }

  /// <summary>
  /// Removes all elements from the vector.
  /// </summary>
  /// <remarks>
  /// After calling this method, the <see cref="Count"/> will be 0. The <see cref="BaseType"/>
  /// property is not affected by this operation.
  /// </remarks>
  public void Clear()
  {
    _items.Clear();
  }

  /// <summary>
  /// Determines whether the vector contains a specific element.
  /// </summary>
  /// <param name="item">The element to locate in the vector. The value can be <see langword="null"/>.</param>
  /// <returns>
  /// <see langword="true"/> if the element is found in the vector; otherwise, <see langword="false"/>.
  /// </returns>
  /// <remarks>
  /// The comparison uses the <see cref="object.Equals(object)"/> method to determine equality.
  /// For null values, reference equality is used.
  /// </remarks>
  public bool Contains(object? item)
  {
    return _items.Contains(item);
  }

  /// <summary>
  /// Copies the elements of the vector to an array, starting at a particular array index.
  /// </summary>
  /// <param name="array">
  /// The one-dimensional array that is the destination of the elements copied from the vector.
  /// The array must have zero-based indexing.
  /// </param>
  /// <param name="arrayIndex">
  /// The zero-based index in <paramref name="array"/> at which copying begins.
  /// </param>
  /// <remarks>
  /// Elements are copied in order from index 0 to <see cref="Count"/> - 1.
  /// The destination array must have sufficient space from <paramref name="arrayIndex"/>
  /// to accommodate all elements.
  /// </remarks>
  /// <exception cref="ArgumentNullException">
  /// Thrown when <paramref name="array"/> is <see langword="null"/>.
  /// </exception>
  /// <exception cref="ArgumentOutOfRangeException">
  /// Thrown when <paramref name="arrayIndex"/> is less than 0.
  /// </exception>
  /// <exception cref="ArgumentException">
  /// Thrown when the destination array does not have enough space to accommodate all elements.
  /// </exception>
  public void CopyTo(object?[] array, int arrayIndex)
  {
    _items.CopyTo(array, arrayIndex);
  }

  /// <summary>
  /// Removes the first occurrence of a specific element from the vector.
  /// </summary>
  /// <param name="item">The element to remove from the vector. The value can be <see langword="null"/>.</param>
  /// <returns>
  /// <see langword="true"/> if the element was successfully removed from the vector;
  /// otherwise, <see langword="false"/>. This method also returns <see langword="false"/>
  /// if the element was not found in the vector.
  /// </returns>
  /// <remarks>
  /// <para>
  /// If the element appears multiple times in the vector, only the first occurrence is removed.
  /// All subsequent elements are shifted down one position, and the <see cref="Count"/> is decreased by 1.
  /// </para>
  /// <para>
  /// The comparison uses the <see cref="object.Equals(object)"/> method to locate the element.
  /// </para>
  /// </remarks>
  public bool Remove(object? item)
  {
    return _items.Remove(item);
  }

  /// <summary>
  /// Gets the number of elements contained in the vector.
  /// </summary>
  /// <value>The number of elements in the vector, including null elements.</value>
  /// <remarks>
  /// This property returns the total count of all elements, including any null values.
  /// </remarks>
  public int Count => _items.Count;

  /// <summary>
  /// Gets a value indicating whether the vector is read-only.
  /// </summary>
  /// <value>Always returns <see langword="false"/> as this vector is modifiable.</value>
  /// <remarks>
  /// This property is provided to satisfy the <see cref="ICollection{T}"/> interface contract.
  /// Elements can be added, removed, and modified through the various collection methods.
  /// </remarks>
  public bool IsReadOnly => false;

  /// <summary>
  /// Determines the index of a specific element in the vector.
  /// </summary>
  /// <param name="item">The element to locate in the vector. The value can be <see langword="null"/>.</param>
  /// <returns>
  /// The zero-based index of the first occurrence of <paramref name="item"/> in the vector,
  /// if found; otherwise, -1.
  /// </returns>
  /// <remarks>
  /// <para>
  /// If the element appears multiple times in the vector, this method returns the index
  /// of the first occurrence.
  /// </para>
  /// <para>
  /// The comparison uses the <see cref="object.Equals(object)"/> method to locate the element.
  /// </para>
  /// </remarks>
  public int IndexOf(object? item)
  {
    return _items.IndexOf(item);
  }

  /// <summary>
  /// Inserts an element into the vector at the specified index.
  /// </summary>
  /// <param name="index">
  /// The zero-based index at which <paramref name="item"/> should be inserted.
  /// </param>
  /// <param name="item">
  /// The element to insert into the vector. The value can be <see langword="null"/>.
  /// </param>
  /// <remarks>
  /// <para>
  /// If <paramref name="index"/> equals <see cref="Count"/>, the element is added to the end of the vector.
  /// All elements at and after the insertion point are shifted one position to the right,
  /// and the <see cref="Count"/> is increased by 1.
  /// </para>
  /// <para>
  /// No type checking is performed against the <see cref="BaseType"/> property when inserting elements.
  /// </para>
  /// </remarks>
  /// <exception cref="ArgumentOutOfRangeException">
  /// Thrown when <paramref name="index"/> is less than 0 or greater than <see cref="Count"/>.
  /// </exception>
  public void Insert(int index, object? item)
  {
    _items.Insert(index, item);
  }

  /// <summary>
  /// Removes the element at the specified index from the vector.
  /// </summary>
  /// <param name="index">The zero-based index of the element to remove.</param>
  /// <remarks>
  /// <para>
  /// All elements after the removed element are shifted one position to the left,
  /// and the <see cref="Count"/> is decreased by 1.
  /// </para>
  /// </remarks>
  /// <exception cref="ArgumentOutOfRangeException">
  /// Thrown when <paramref name="index"/> is less than 0 or greater than or equal to <see cref="Count"/>.
  /// </exception>
  public void RemoveAt(int index)
  {
    _items.RemoveAt(index);
  }

  /// <summary>
  /// Gets or sets the element at the specified index.
  /// </summary>
  /// <param name="index">The zero-based index of the element to get or set.</param>
  /// <value>The element at the specified index. Can be <see langword="null"/>.</value>
  /// <remarks>
  /// <para>
  /// This indexer provides direct access to elements by their position in the vector.
  /// Valid indices range from 0 to <see cref="Count"/> - 1.
  /// </para>
  /// <para>
  /// When setting a value, no type checking is performed against the <see cref="BaseType"/> property.
  /// Null values can be assigned to any position.
  /// </para>
  /// </remarks>
  /// <exception cref="ArgumentOutOfRangeException">
  /// Thrown when <paramref name="index"/> is less than 0 or greater than or equal to <see cref="Count"/>.
  /// </exception>
  public object? this[int index]
  {
    get => _items[index];
    set => _items[index] = value;
  }
  /// <summary>
  /// Determines whether the specified <see cref="VectorVariant"/> is equal to the current instance.
  /// </summary>
  /// <param name="other">
  /// The <see cref="VectorVariant"/> to compare with the current instance. Can be <see langword="null"/>.
  /// </param>
  /// <returns>
  /// <see langword="true"/> if the specified <see cref="VectorVariant"/> is equal to the current instance;
  /// otherwise, <see langword="false"/>.
  /// </returns>
  /// <remarks>
  /// <para>
  /// Two <see cref="VectorVariant"/> instances are considered equal if:
  /// <list type="bullet">
  /// <item><description>Both have null internal lists, or</description></item>
  /// <item><description>Both have the same number of elements and all corresponding elements are equal</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Element equality is determined using the <see cref="object.Equals(object)"/> method.
  /// Null elements are compared using reference equality. The <see cref="BaseType"/> property
  /// is not considered in the equality comparison.
  /// </para>
  /// </remarks>
  public virtual bool Equals(VectorVariant? other)
  {
    if (other == null) return false;
    //if (this._items == null && other._items == null)
    //  return true;
    //if (this._items == null || other._items == null)
    //  return false;
    if (this._items.Count != other._items.Count)
      return false;
    for (int i = 0; i < _items.Count; i++)
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
  /// Returns the hash code for this instance.
  /// </summary>
  /// <returns>A 32-bit signed integer hash code.</returns>
  /// <remarks>
  /// This method delegates to the base class implementation of <see cref="object.GetHashCode"/>.
  /// For consistent hash code generation that considers the vector's contents, consider
  /// implementing a custom hash code calculation based on the elements.
  /// </remarks>
  public override int GetHashCode()
  {
    return base.GetHashCode();
  }

  /// <summary>
  /// Converts the value of this instance to a string representation using the specified format provider.
  /// </summary>
  /// <param name="provider">
  /// An <see cref="IFormatProvider"/> that supplies culture-specific formatting information.
  /// Can be <see langword="null"/> to use the current culture.
  /// </param>
  /// <returns>
  /// A string representation of the vector in the format "(element1, element2, ...)".
  /// </returns>
  /// <remarks>
  /// <para>
  /// Example outputs:
  /// <list type="bullet">
  /// <item><description>"Vector = (10, 20, 30)" - Integer vector</description></item>
  /// <item><description>"Vector of String = (apple, banana cherry)" - String vector with base type</description></item>
  /// <item><description>"Vector = ()" - Empty vector</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public override string? ToString(IFormatProvider? provider = null)
  {
    var formattedItems = _items.Select(item =>
    {
      if (item == null) return "";
      if (item is IFormattable formattable)
        return formattable.ToString(null, provider);
      return item.ToString() ?? "";
    });

    var result = "(" + string.Join(", ", formattedItems) + ")";
    return result;
  }

  /// <summary>
  /// Converts the value of this instance to a string representation.
  /// </summary>
  /// <returns>
  /// A string representation of the vector in the format "Vector [of BaseType] = [element1 element2 ...]".
  /// </returns>
  /// <remarks>
  /// This method calls <see cref="ToString(IFormatProvider)"/> with <see cref="CultureInfo.InvariantCulture"/>
  /// to ensure consistent string representation across different cultures.
  /// </remarks>
  public override string? ToString()
  {
    return ToString(System.Globalization.CultureInfo.InvariantCulture);
  }
}
