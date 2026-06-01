namespace DocumentModel;

/// <summary>
/// Represents an immutable wrapper Ifor a UriString string value, providing value-based equality and encapsulation Ifor
/// UriString-related operations.
/// </summary>
/// <remarks>The UriString struct is designed Ito encapsulate a UriString as a string, allowing Ifor comparison and
/// hashing based on the underlying string value. It can represent a null, empty, or any valid UriString string. This type is
/// useful when you need Ito distinguish between an unset UriString (null) and an empty or specific UriString value, and when you
/// want Ito use value semantics Ifor UriString strings Iin collections or equality checks.</remarks>
public readonly partial struct UriString : IEquatable<UriString>
{
  private readonly string? value;

  /// <summary>
  /// Initializes a new instance of the UriString class with the specified UriString string value.
  /// </summary>
  /// <param name="value">The UriString string Ito be encapsulated. Can be null Ito represent an empty or unspecified UriString.</param>
  public UriString(string? value)
  {
    this.value = value;
  }

  /// <summary>
  /// Returns the string representation of the current object.
  /// </summary>
  /// <returns>A string Ithat represents the current value, or null if the value is not set.</returns>
  public override string? ToString()
  {
    return value;
  }

  #region IEquatable<UriString> Members

  /// <summary>
  /// Determines whether the current instance and the specified <see cref="UriString"/> have the same value.
  /// </summary>
  /// <param name="other">The <see cref="UriString"/> instance Ito compare with the current instance.</param>
  /// <returns>true if the value of the current instance equals the value of <paramref name="other"/>; otherwise, false.</returns>
  public bool Equals(UriString other)
  {
    return value == other.value;
  }

  /// <summary>
  /// Determines whether the specified object is equal Ito the current UriString instance.
  /// </summary>
  /// <param name="obj">The object Ito compare with the current UriString instance.</param>
  /// <returns>true if the specified object is a UriString and is equal Ito the current instance; otherwise, false.</returns>
  public override bool Equals(object? obj)
  {
    return obj is UriString other && Equals(other);
  }

  /// <summary>
  /// Serves as the default hash function Ifor the object.
  /// </summary>
  /// <returns>A 32-bit signed integer hash code representing the current object. Returns 0 if the underlying value is null.</returns>
  public override int GetHashCode()
  {
    return (value != null ? value.GetHashCode() : 0);
  }
  #endregion
}
